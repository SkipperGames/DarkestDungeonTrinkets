using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace DarkestDungeon
{
    public partial class BuffSearch : Form
    {

        #region FIELDS
        private string installDir = "D:/SteamLibrary/steamapps/common/DarkestDungeon";
        const string buffFilePath = "/shared/buffs/buff_library.json";
        const string trinketsFilePath = "/trinkets/default.trinkets.json";
        
        private JObject parsedBuffs;
        private JObject parsedTrinkets;
        private int itemIndex = -1;

        public FormInteraction.FormDelegate trinketSearchDelegate;

        private Random rand = new Random(
            Guid.NewGuid().GetHashCode() +
            DateTime.Now.Millisecond +
            DateTime.Now.Second +
            DateTime.Now.Minute +
            DateTime.Now.Hour +
            DateTime.Now.Day +
            DateTime.Now.DayOfYear +
            DateTime.Now.Year);

        private string[] statTypes = new string[25]
        {
            "bleed_chance",
            "combat_stat_add", "combat_stat_multiply",
            "damage_received_percent", "debuff_chance",
            "food_consumption_percent",
            "hp_heal_amount", "hp_heal_percent", "hp_heal_received_percent",
            "monsters_surprise_chance", "move_chance",
            "party_surprise_chance", "poison_chance",
            "remove_negative_quirk_chance", "resistance",
            "resolve_check_percent", "resolve_xp_bonus_percent",
            "scouting_chance", "starving_damage_percent", "stress_dmg_percent", "stress_dmg_received_percent", "stress_heal_percent", "stress_heal_received_percent", "stun_chance",
            "upgrade_discount",
        };
        #endregion FIELDS

        public BuffSearch()
        {
            InitializeComponent();

            parsedBuffs = JObject.Parse(
                File.ReadAllText(installDir + buffFilePath));
            parsedTrinkets = JObject.Parse(
                File.ReadAllText(installDir + trinketsFilePath));

            lbx_savedBuffs.SelectedIndexChanged += 
                lbx_buffs_SelectedIndexChanged;

            lbx_buffs.MouseDown += lbx_buffs_MouseDown;
            lbx_buffs.MouseMove += lbx_buffs_MouseMove;
            lbx_savedBuffs.DragEnter += lbx_savedBuffs_DragEnter;
            lbx_savedBuffs.DragDrop += lbx_savedBuffs_DragDrop;
            lbx_savedBuffs.MouseDown += lbx_savedBuffs_MouseDown;

            cbx_statType.DataSource = statTypes;

            lbx_trinketsFound.DisplayMember = "id";
        }

        private void lbx_buffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var buff = parsedBuffs.SelectToken(
                ((sender as ListBox).SelectedItem as JValue).Path).Parent.Parent;

            lb_amountValue.Text =
                buff["amount"].ToString();
            lb_removeInactiveValue.Text =
                buff["remove_if_not_active"].ToString();
            lb_inverseRuleValue.Text =
                buff["is_false_rule"].ToString();
            lb_ruleDataKeyValue.Text =
                buff["rule_data"].Value<string>("float");

            var trinkets =
                from t in parsedTrinkets["trinkets"]
                where t["buffs"].Children().Contains(buff["id"])
                select t["id"];

            lbx_trinketsFound.DataSource =
                trinkets.ToArray();

            gbx_trinketsFound.Text =
                string.Format(
                    "found {0} trinkets containing this buff",
                    lbx_trinketsFound.Items.Count);

            lb_numBuffs.Text =
                string.Format("Buffs::Count({0})",
                lbx_buffs.Items.Count);
        }

        private void cbx_statType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result =
                from buff in parsedBuffs["buffs"]
                where buff.Value<string>("stat_type") == (string)cbx_statType.SelectedValue
                select buff;

            var subresult =
                from buff in result
                select buff.Value<string>("stat_sub_type");

            cbx_statSubType.DataSource =
                subresult.Distinct().ToArray();
        }

        private void cbx_statSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result =
                from buff in parsedBuffs["buffs"]
                where buff.Value<string>("stat_type") == (string)cbx_statType.SelectedValue
                where buff.Value<string>("stat_sub_type") == (string)cbx_statSubType.SelectedValue
                select buff;

            var subresult =
                from buff in result
                select buff.Value<string>("rule_type");

            cbx_ruleType.DataSource =
                subresult.Distinct().ToArray();
        }

        private void cbx_ruleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result =
                from buff in parsedBuffs["buffs"]
                where buff.Value<string>("stat_type") == (string)cbx_statType.SelectedValue
                where buff.Value<string>("stat_sub_type") == (string)cbx_statSubType.SelectedValue
                where buff.Value<string>("rule_type") == (string)cbx_ruleType.SelectedValue
                select buff;

            var subresult =
                from buff in result
                select buff["rule_data"].Value<string>("string");

            cbx_ruleDataValue.DataSource =
                subresult.Distinct().ToArray();
        }

        private void cbx_ruleDataValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result =
                from buff in parsedBuffs["buffs"]
                where buff.Value<string>("stat_type") == (string)cbx_statType.SelectedValue
                where buff.Value<string>("stat_sub_type") == (string)cbx_statSubType.SelectedValue
                where buff.Value<string>("rule_type") == (string)cbx_ruleType.SelectedValue
                where buff["rule_data"].Value<string>("string") == (string)cbx_ruleDataValue.SelectedValue
                select buff["id"];

            lbx_buffs.DataSource = result.ToArray();
        }

        private void lbx_buffs_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbx_buffs.Items.Count == 0) return;
            
            itemIndex = 
                lbx_buffs.
                IndexFromPoint(e.X, e.Y);
        }

        private void lbx_buffs_MouseMove(object sender, MouseEventArgs e)
        {
            if (!lbx_buffs.ClientRectangle.Contains(e.X, e.Y))
            {
                string item = (lbx_buffs.Items[itemIndex] as JValue).Path;
                lbx_savedBuffs.AllowDrop = true;
                lbx_trinketsFound.AllowDrop = false;
                lbx_buffs.DoDragDrop(item, DragDropEffects.Copy);
            }
        }

        private void lbx_savedBuffs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lbx_savedBuffs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                var item = parsedBuffs.SelectToken(
                    (string)e.Data.GetData(DataFormats.StringFormat));

                if (lbx_savedBuffs.Items.Contains(item)) return;

                lbx_savedBuffs.Items.Add(
                    parsedBuffs.SelectToken(
                        (string)e.Data.GetData(DataFormats.StringFormat)));

                lbx_savedBuffs.AllowDrop = false;
            }
        }

        private void lbx_savedBuffs_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbx_savedBuffs.Items.Count == 0) return;

            int index =
                lbx_savedBuffs.
                IndexFromPoint(e.X, e.Y);

            if (index == -1) return;

            if (e.Button == MouseButtons.Right)
                lbx_savedBuffs.Items.RemoveAt(index);
        }

        private void b_showInTrinketSearch_Click(object sender, EventArgs e)
        {
            trinketSearchDelegate(lbx_trinketsFound.DataSource);
        }

        public void ShowBuffsFromTrinketSearch(object data)
        {
            this.BringToFront();
            lbx_buffs.DataSource = data;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}