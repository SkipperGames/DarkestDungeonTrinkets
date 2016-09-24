using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Bson;

namespace DarkestDungeon
{
    public partial class SaveData : Form
    {


        public SaveData()
        {
            InitializeComponent();

            LootDefinitions loot =
                JsonConvert.DeserializeObject<LootDefinitions>(
                    File.ReadAllText(
                        "D:/SteamLibrary/steamapps/common/DarkestDungeon/loot/loot.json"));
        }
    }
}
