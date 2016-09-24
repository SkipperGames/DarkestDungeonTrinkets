using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DarkestDungeon
{
    public partial class TrinketSearch : Form
    {

        #region FIELDS
        private string installDir = "D:/SteamLibrary/steamapps/common/DarkestDungeon";

        const string trinketsFilePath = "/trinkets/default.trinkets.json";
        const string trinketIconsDir = "/panels/icons_equip/trinket/";
        const string buffFilePath = "/shared/buffs/buff_library.json";

        private TrinketCollection tcollection;

        private BuffSearch buffSearch = new BuffSearch();
        private JObject parsedBuffs;

        private XDocument trinketNamesDoc;

        private Random rand = new Random(
            Guid.NewGuid().GetHashCode() +
            DateTime.Now.Millisecond +
            DateTime.Now.Second +
            DateTime.Now.Minute +
            DateTime.Now.Hour +
            DateTime.Now.Day +
            DateTime.Now.DayOfYear +
            DateTime.Now.Year);

        private string[] classes = new string[16]
        {
            "none",
            "abomination", "antiquarian", "arbalest",
            "bounty_hunter",
            "crusader",
            "grave_robber",
            "hellion", "highwayman", "houndmaster",
            "jester",
            "leper",
            "man_at_arms",
            "occultist",
            "plague_doctor",
            "vestal",
        };

        private string[] rarities = new string[13]
        {
            "any",
            "darkest_dungeon",
            "ancestral_shambler",
            "ancestral",
            "collector",
            "madman",
            "very_rare",
            "rare",
            "uncommon",
            "common",
            "very_common",
            "trophy",
            "kickstarter"
        };

        private string[] dungeons = new string[4]
        {
            "anywhere", "warrens", "weald", "crypts"
        };
        #endregion FIELDS

        public TrinketSearch()
        {
            InitializeComponent();

            tcollection =
                JsonConvert.DeserializeObject<TrinketCollection>(
                    File.ReadAllText(installDir + trinketsFilePath));

            parsedBuffs = JObject.Parse(
                File.ReadAllText(installDir + buffFilePath));
            
            trinketNamesDoc = XDocument.Load(
                Application.StartupPath + "/trinket_names.string_table.xml");

            lbx_trinkets.DisplayMember = "Id";
            lbx_trinkets.DataSource = 
                tcollection.trinkets.OrderBy(
                x => x).ToList();

            lb_numTrinkets.Text =
                string.Format("Trinkets::Count({0})",
                lbx_trinkets.Items.Count);

            cbx_classRequirement.DataSource = classes;

            cbx_rarity.DataSource = rarities;

            nud_priceMin.Maximum =
                nud_priceMax.Value =
                nud_priceMax.Maximum =
                tcollection.trinkets.Select(
                    x => x.price).Max();

            ToolTip limitTooltip = new ToolTip();
            limitTooltip.SetToolTip(gbx_limit,
                "Is the trinket unique? Can possess only one (1)?");

            cbx_dungeon.DataSource = dungeons;

            lb_trinketProperties.Font =
                new System.Drawing.Font("Consolas", 8);

            buffSearch.trinketSearchDelegate = ShowTrinketsFromBuffSearch;
            
        }

        private void lbx_trinkets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trinket trinket = (Trinket)lbx_trinkets.SelectedValue;

            string url = 
                string.Format(
                    "{0}{1}inv_trinket+{2}.png",
                    installDir, trinketIconsDir, trinket.id);

            try
            {
                pbx_trinketImage.Load(url);
            }
            catch (FileNotFoundException)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format(
                        "FileNotFoundException at Form1::lbx_trinkets_SelectedIndexChanged\nURL {0} not found.", url));
            }
            
            string xpath = 
                "./root/language[@id='english']/entry[@id='str_inventory_title_trinket" +
                    trinket.id + "']";

            string name = trinketNamesDoc.
                XPathSelectElement(xpath).Value;

            lb_trinketProperties.Text =
                "\nname______________" + name +
                "\nclass restriction_" + (trinket.hero_class_requirements.Length > 0 ? trinket.hero_class_requirements[0] : "none") +
                "\nrarity____________" + trinket.rarity +
                "\nprice_____________" + trinket.price +
                "\nis unique_________" + (trinket.limit == 0 ? "no" : "yes") +
                "\nfound_____________" + (string.IsNullOrEmpty(trinket.origin_dungeon) ? 
                (trinket.rarity == "kickstarter" ? "nowhere (use console)" : "anywhere") :
                trinket.origin_dungeon);

            List<JToken> list = new List<JToken>(trinket.buffs.Length);
            for (int i = 0; i < trinket.buffs.Length; i++)
            {
                string path = 
                    "$.buffs[?(@.id == \'" + trinket.buffs[i] + "\')]";
                list.AddRange(
                    parsedBuffs.SelectTokens(path).Values("id"));
            }

            lbx_buffs.DataSource = list.ToArray();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            IEnumerable<Trinket> results =
                tcollection.trinkets;

            results = results.Where(
                x =>
                (cbx_classRequirement.SelectedIndex == 0 ? true :
                x.hero_class_requirements.Length == 0 ? false :
                x.hero_class_requirements[0] == 
                classes[cbx_classRequirement.SelectedIndex]));

            results = results.Where(
                x =>
                (cbx_rarity.SelectedIndex == 0 ? true :
                x.rarity ==
                rarities[cbx_rarity.SelectedIndex]));

            results = results.Where(
                x =>
                (x.price >= (int)nud_priceMin.Value) && 
                (x.price <= (int)nud_priceMax.Value));

            if (!rb_limitBoth.Checked)
            {
                results = results.Where(
                    x => x.limit == (rb_limitNo.Checked ? 0 : 1));
            }

            results = results.Where(
                x => 
                (cbx_dungeon.SelectedIndex == 0 ? true :
                x.origin_dungeon ==
                dungeons[cbx_dungeon.SelectedIndex]));
            
            lbx_trinkets.DataSource = results.OrderBy(t => t).ToArray();
            lb_numTrinkets.Text =
                string.Format("Trinkets::Count({0})",
                lbx_trinkets.Items.Count);
        }

        private void b_random_Click(object sender, EventArgs e)
        {
            b_reset_Click(sender, e);
            lbx_trinkets.SelectedIndex =
                rand.Next(0, lbx_trinkets.Items.Count);
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            lbx_trinkets.DataSource =
                tcollection.trinkets.OrderBy(
                x => x).ToList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                installDir = dialog.SelectedPath;

                //todo:
                //create config file in appdata
                //save game installdir to file
                //properly initialize() trinket data
            }
        }

        private void b_showInBuffSearch_Click(object sender, EventArgs e)
        {
            buffSearch.ShowBuffsFromTrinketSearch(lbx_buffs.DataSource);
            buffSearch.Show();
            buffSearch.BringToFront();
        }

        public void ShowTrinketsFromBuffSearch(object data)
        {
            this.BringToFront();
            lbx_trinkets.DataSource = data;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buffSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffSearch.Show();
        }
    }
}