using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;

namespace DarkestDungeon
{
    struct RuleData
    {
        public float @float;
        public string @string;
    }

    class Buff : IComparable<Buff>
    {
        static int placeholderId = 0;

        public string Id { get { return id; } }
        public string id =
            string.Format("placeholder_buff_{0}", ++placeholderId);
        
        //public string StatType { get { return stat_type; } }
        public string stat_type = "";
        
        public string stat_sub_type = "";
        
        public float amount = 0f;

        public bool remove_if_not_active = false;
        
        public string rule_type = "always";
        
        public bool is_false_rule = false;

        public RuleData rule_data = 
            new RuleData() { @float = 0f, @string = "" };

        public int CompareTo(Buff other)
        {
            return id.CompareTo(other.id);
        }
    }

    class Trinket : IComparable<Trinket>
    {
        static int placeholderId = 0;

        public string Id { get { return id; } }
        public string id = 
            string.Format("placeholder_trinket_{0}", ++placeholderId);
        
        public string[] buffs = 
            new string[1] { "TRINKET_PLACEHOLDER_BUFF" };

        public string[] hero_class_requirements = 
            new string[0];
        
        public string rarity = "very_common";
        
        public int price = 0;
        
        public int limit = 0;
        
        public string origin_dungeon = "";
        
        public int CompareTo(Trinket other)
        {
            return id.CompareTo(other.id);
        }
    }

    class TrinketCollection
    {
        public string[] rarities = new string[12];
        public List<Trinket> trinkets = new List<Trinket>(488);
    }

    class BuffCollection
    {
        public List<Buff> buffs = new List<Buff>(1803);
    }

    class LootDefinitions
    {
        public DarknessBonus[] darkness_bonuses;
        public LootTable[] loot_tables;
    }

    class DarknessBonus
    {
        public string type;
        public DarknessBonusData[] bonuses;
    }

    class DarknessBonusData
    {
        public int darkness;
        public float chance;
        public string[] codes;
    }

    class LootTable
    {
        public string id;
        public int difficulty;
        public string dungeon;
        public LootTableEntry[] entries;
    }

    class LootTableEntry
    {
        public string type;
        public float chances;
        public LootTableEntryData data;
    }

    class LootTableEntryData
    {
        public string table = "";
        public string type = "";
        public string id = "";
        public int amount = 0;
    }

    public class FormInteraction
    {
        public delegate void FormDelegate(object data);
    }
}