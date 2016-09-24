namespace DarkestDungeon
{
    partial class BuffSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_buffs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_numBuffs = new System.Windows.Forms.Label();
            this.gbx_searchProperties = new System.Windows.Forms.GroupBox();
            this.cbx_ruleDataValue = new System.Windows.Forms.ComboBox();
            this.lb_ruleDataValue = new System.Windows.Forms.Label();
            this.lb_ruleDataKeyValue = new System.Windows.Forms.Label();
            this.lb_ruleDataKey = new System.Windows.Forms.Label();
            this.lb_inverseRuleValue = new System.Windows.Forms.Label();
            this.lb_inverseRule = new System.Windows.Forms.Label();
            this.lb_ruleType = new System.Windows.Forms.Label();
            this.cbx_ruleType = new System.Windows.Forms.ComboBox();
            this.lb_removeInactiveValue = new System.Windows.Forms.Label();
            this.lb_removeInactive = new System.Windows.Forms.Label();
            this.lb_amountValue = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_statSubType = new System.Windows.Forms.Label();
            this.cbx_statSubType = new System.Windows.Forms.ComboBox();
            this.lb_statType = new System.Windows.Forms.Label();
            this.cbx_statType = new System.Windows.Forms.ComboBox();
            this.gbx_trinketsFound = new System.Windows.Forms.GroupBox();
            this.b_showInTrinketSearch = new System.Windows.Forms.Button();
            this.lbx_trinketsFound = new System.Windows.Forms.ListBox();
            this.lbx_savedBuffs = new System.Windows.Forms.ListBox();
            this.lb_savedBuffs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbx_searchProperties.SuspendLayout();
            this.gbx_trinketsFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_buffs
            // 
            this.lbx_buffs.FormattingEnabled = true;
            this.lbx_buffs.Location = new System.Drawing.Point(12, 52);
            this.lbx_buffs.Name = "lbx_buffs";
            this.lbx_buffs.Size = new System.Drawing.Size(242, 342);
            this.lbx_buffs.TabIndex = 0;
            this.lbx_buffs.SelectedIndexChanged += new System.EventHandler(this.lbx_buffs_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openToolStripMenuItem.Text = "Open Directory";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enToolStripMenuItem,
            this.frToolStripMenuItem,
            this.deToolStripMenuItem,
            this.esToolStripMenuItem,
            this.brToolStripMenuItem,
            this.ruToolStripMenuItem,
            this.czToolStripMenuItem,
            this.csToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // enToolStripMenuItem
            // 
            this.enToolStripMenuItem.Checked = true;
            this.enToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enToolStripMenuItem.Name = "enToolStripMenuItem";
            this.enToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.enToolStripMenuItem.Text = "en";
            // 
            // frToolStripMenuItem
            // 
            this.frToolStripMenuItem.Name = "frToolStripMenuItem";
            this.frToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.frToolStripMenuItem.Text = "fr";
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deToolStripMenuItem.Text = "de";
            // 
            // esToolStripMenuItem
            // 
            this.esToolStripMenuItem.Name = "esToolStripMenuItem";
            this.esToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.esToolStripMenuItem.Text = "es";
            // 
            // brToolStripMenuItem
            // 
            this.brToolStripMenuItem.Name = "brToolStripMenuItem";
            this.brToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.brToolStripMenuItem.Text = "pl (br)";
            // 
            // ruToolStripMenuItem
            // 
            this.ruToolStripMenuItem.Name = "ruToolStripMenuItem";
            this.ruToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ruToolStripMenuItem.Text = "ru";
            // 
            // czToolStripMenuItem
            // 
            this.czToolStripMenuItem.Name = "czToolStripMenuItem";
            this.czToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.czToolStripMenuItem.Text = "pl";
            // 
            // csToolStripMenuItem
            // 
            this.csToolStripMenuItem.Name = "csToolStripMenuItem";
            this.csToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.csToolStripMenuItem.Text = "cs";
            // 
            // lb_numBuffs
            // 
            this.lb_numBuffs.AutoSize = true;
            this.lb_numBuffs.Location = new System.Drawing.Point(12, 36);
            this.lb_numBuffs.Name = "lb_numBuffs";
            this.lb_numBuffs.Size = new System.Drawing.Size(31, 13);
            this.lb_numBuffs.TabIndex = 7;
            this.lb_numBuffs.Text = "Buffs";
            // 
            // gbx_searchProperties
            // 
            this.gbx_searchProperties.Controls.Add(this.cbx_ruleDataValue);
            this.gbx_searchProperties.Controls.Add(this.lb_ruleDataValue);
            this.gbx_searchProperties.Controls.Add(this.lb_ruleDataKeyValue);
            this.gbx_searchProperties.Controls.Add(this.lb_ruleDataKey);
            this.gbx_searchProperties.Controls.Add(this.lb_inverseRuleValue);
            this.gbx_searchProperties.Controls.Add(this.lb_inverseRule);
            this.gbx_searchProperties.Controls.Add(this.lb_ruleType);
            this.gbx_searchProperties.Controls.Add(this.cbx_ruleType);
            this.gbx_searchProperties.Controls.Add(this.lb_removeInactiveValue);
            this.gbx_searchProperties.Controls.Add(this.lb_removeInactive);
            this.gbx_searchProperties.Controls.Add(this.lb_amountValue);
            this.gbx_searchProperties.Controls.Add(this.lb_amount);
            this.gbx_searchProperties.Controls.Add(this.lb_statSubType);
            this.gbx_searchProperties.Controls.Add(this.cbx_statSubType);
            this.gbx_searchProperties.Controls.Add(this.lb_statType);
            this.gbx_searchProperties.Controls.Add(this.cbx_statType);
            this.gbx_searchProperties.Location = new System.Drawing.Point(260, 36);
            this.gbx_searchProperties.Name = "gbx_searchProperties";
            this.gbx_searchProperties.Size = new System.Drawing.Size(352, 220);
            this.gbx_searchProperties.TabIndex = 8;
            this.gbx_searchProperties.TabStop = false;
            this.gbx_searchProperties.Text = "Search Properties";
            // 
            // cbx_ruleDataValue
            // 
            this.cbx_ruleDataValue.FormattingEnabled = true;
            this.cbx_ruleDataValue.Location = new System.Drawing.Point(134, 181);
            this.cbx_ruleDataValue.Name = "cbx_ruleDataValue";
            this.cbx_ruleDataValue.Size = new System.Drawing.Size(160, 21);
            this.cbx_ruleDataValue.TabIndex = 15;
            this.cbx_ruleDataValue.SelectedIndexChanged += new System.EventHandler(this.cbx_ruleDataValue_SelectedIndexChanged);
            // 
            // lb_ruleDataValue
            // 
            this.lb_ruleDataValue.AutoSize = true;
            this.lb_ruleDataValue.Location = new System.Drawing.Point(6, 184);
            this.lb_ruleDataValue.Name = "lb_ruleDataValue";
            this.lb_ruleDataValue.Size = new System.Drawing.Size(67, 13);
            this.lb_ruleDataValue.TabIndex = 14;
            this.lb_ruleDataValue.Text = "rule sub type";
            // 
            // lb_ruleDataKeyValue
            // 
            this.lb_ruleDataKeyValue.AutoSize = true;
            this.lb_ruleDataKeyValue.Location = new System.Drawing.Point(134, 158);
            this.lb_ruleDataKeyValue.Name = "lb_ruleDataKeyValue";
            this.lb_ruleDataKeyValue.Size = new System.Drawing.Size(33, 13);
            this.lb_ruleDataKeyValue.TabIndex = 13;
            this.lb_ruleDataKeyValue.Text = "value";
            // 
            // lb_ruleDataKey
            // 
            this.lb_ruleDataKey.AutoSize = true;
            this.lb_ruleDataKey.Location = new System.Drawing.Point(6, 158);
            this.lb_ruleDataKey.Name = "lb_ruleDataKey";
            this.lb_ruleDataKey.Size = new System.Drawing.Size(105, 13);
            this.lb_ruleDataKey.TabIndex = 12;
            this.lb_ruleDataKey.Text = "rule sub type amount";
            // 
            // lb_inverseRuleValue
            // 
            this.lb_inverseRuleValue.AutoSize = true;
            this.lb_inverseRuleValue.Location = new System.Drawing.Point(134, 144);
            this.lb_inverseRuleValue.Name = "lb_inverseRuleValue";
            this.lb_inverseRuleValue.Size = new System.Drawing.Size(33, 13);
            this.lb_inverseRuleValue.TabIndex = 11;
            this.lb_inverseRuleValue.Text = "value";
            // 
            // lb_inverseRule
            // 
            this.lb_inverseRule.AutoSize = true;
            this.lb_inverseRule.Location = new System.Drawing.Point(6, 144);
            this.lb_inverseRule.Name = "lb_inverseRule";
            this.lb_inverseRule.Size = new System.Drawing.Size(71, 13);
            this.lb_inverseRule.TabIndex = 10;
            this.lb_inverseRule.Text = "is inverse rule";
            // 
            // lb_ruleType
            // 
            this.lb_ruleType.AutoSize = true;
            this.lb_ruleType.Location = new System.Drawing.Point(6, 116);
            this.lb_ruleType.Name = "lb_ruleType";
            this.lb_ruleType.Size = new System.Drawing.Size(47, 13);
            this.lb_ruleType.TabIndex = 9;
            this.lb_ruleType.Text = "rule type";
            // 
            // cbx_ruleType
            // 
            this.cbx_ruleType.FormattingEnabled = true;
            this.cbx_ruleType.Location = new System.Drawing.Point(134, 113);
            this.cbx_ruleType.Name = "cbx_ruleType";
            this.cbx_ruleType.Size = new System.Drawing.Size(160, 21);
            this.cbx_ruleType.TabIndex = 8;
            this.cbx_ruleType.SelectedIndexChanged += new System.EventHandler(this.cbx_ruleType_SelectedIndexChanged);
            // 
            // lb_removeInactiveValue
            // 
            this.lb_removeInactiveValue.AutoSize = true;
            this.lb_removeInactiveValue.Location = new System.Drawing.Point(134, 90);
            this.lb_removeInactiveValue.Name = "lb_removeInactiveValue";
            this.lb_removeInactiveValue.Size = new System.Drawing.Size(33, 13);
            this.lb_removeInactiveValue.TabIndex = 7;
            this.lb_removeInactiveValue.Text = "value";
            // 
            // lb_removeInactive
            // 
            this.lb_removeInactive.AutoSize = true;
            this.lb_removeInactive.Location = new System.Drawing.Point(6, 90);
            this.lb_removeInactive.Name = "lb_removeInactive";
            this.lb_removeInactive.Size = new System.Drawing.Size(90, 13);
            this.lb_removeInactive.TabIndex = 6;
            this.lb_removeInactive.Text = "remove if inactive";
            // 
            // lb_amountValue
            // 
            this.lb_amountValue.AutoSize = true;
            this.lb_amountValue.Location = new System.Drawing.Point(134, 76);
            this.lb_amountValue.Name = "lb_amountValue";
            this.lb_amountValue.Size = new System.Drawing.Size(33, 13);
            this.lb_amountValue.TabIndex = 5;
            this.lb_amountValue.Text = "value";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(6, 76);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(42, 13);
            this.lb_amount.TabIndex = 4;
            this.lb_amount.Text = "amount";
            // 
            // lb_statSubType
            // 
            this.lb_statSubType.AutoSize = true;
            this.lb_statSubType.Location = new System.Drawing.Point(6, 49);
            this.lb_statSubType.Name = "lb_statSubType";
            this.lb_statSubType.Size = new System.Drawing.Size(67, 13);
            this.lb_statSubType.TabIndex = 3;
            this.lb_statSubType.Text = "stat sub type";
            // 
            // cbx_statSubType
            // 
            this.cbx_statSubType.FormattingEnabled = true;
            this.cbx_statSubType.Location = new System.Drawing.Point(134, 48);
            this.cbx_statSubType.Name = "cbx_statSubType";
            this.cbx_statSubType.Size = new System.Drawing.Size(160, 21);
            this.cbx_statSubType.TabIndex = 2;
            this.cbx_statSubType.SelectedIndexChanged += new System.EventHandler(this.cbx_statSubType_SelectedIndexChanged);
            // 
            // lb_statType
            // 
            this.lb_statType.AutoSize = true;
            this.lb_statType.Location = new System.Drawing.Point(6, 23);
            this.lb_statType.Name = "lb_statType";
            this.lb_statType.Size = new System.Drawing.Size(47, 13);
            this.lb_statType.TabIndex = 1;
            this.lb_statType.Text = "stat type";
            // 
            // cbx_statType
            // 
            this.cbx_statType.FormattingEnabled = true;
            this.cbx_statType.Location = new System.Drawing.Point(134, 20);
            this.cbx_statType.Name = "cbx_statType";
            this.cbx_statType.Size = new System.Drawing.Size(160, 21);
            this.cbx_statType.TabIndex = 0;
            this.cbx_statType.SelectedIndexChanged += new System.EventHandler(this.cbx_statType_SelectedIndexChanged);
            // 
            // gbx_trinketsFound
            // 
            this.gbx_trinketsFound.Controls.Add(this.b_showInTrinketSearch);
            this.gbx_trinketsFound.Controls.Add(this.lbx_trinketsFound);
            this.gbx_trinketsFound.Location = new System.Drawing.Point(260, 263);
            this.gbx_trinketsFound.Name = "gbx_trinketsFound";
            this.gbx_trinketsFound.Size = new System.Drawing.Size(352, 326);
            this.gbx_trinketsFound.TabIndex = 9;
            this.gbx_trinketsFound.TabStop = false;
            this.gbx_trinketsFound.Text = "found # trinkets containing this buff";
            // 
            // b_showInTrinketSearch
            // 
            this.b_showInTrinketSearch.Location = new System.Drawing.Point(8, 290);
            this.b_showInTrinketSearch.Name = "b_showInTrinketSearch";
            this.b_showInTrinketSearch.Size = new System.Drawing.Size(160, 23);
            this.b_showInTrinketSearch.TabIndex = 1;
            this.b_showInTrinketSearch.Text = "show in trinket search";
            this.b_showInTrinketSearch.UseVisualStyleBackColor = true;
            this.b_showInTrinketSearch.Click += new System.EventHandler(this.b_showInTrinketSearch_Click);
            // 
            // lbx_trinketsFound
            // 
            this.lbx_trinketsFound.FormattingEnabled = true;
            this.lbx_trinketsFound.Location = new System.Drawing.Point(8, 20);
            this.lbx_trinketsFound.Name = "lbx_trinketsFound";
            this.lbx_trinketsFound.Size = new System.Drawing.Size(160, 264);
            this.lbx_trinketsFound.TabIndex = 0;
            // 
            // lbx_savedBuffs
            // 
            this.lbx_savedBuffs.FormattingEnabled = true;
            this.lbx_savedBuffs.Location = new System.Drawing.Point(12, 427);
            this.lbx_savedBuffs.Name = "lbx_savedBuffs";
            this.lbx_savedBuffs.Size = new System.Drawing.Size(242, 160);
            this.lbx_savedBuffs.TabIndex = 10;
            // 
            // lb_savedBuffs
            // 
            this.lb_savedBuffs.AutoSize = true;
            this.lb_savedBuffs.Location = new System.Drawing.Point(12, 408);
            this.lb_savedBuffs.Name = "lb_savedBuffs";
            this.lb_savedBuffs.Size = new System.Drawing.Size(62, 13);
            this.lb_savedBuffs.TabIndex = 11;
            this.lb_savedBuffs.Text = "saved buffs";
            // 
            // BuffSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.lb_savedBuffs);
            this.Controls.Add(this.lbx_savedBuffs);
            this.Controls.Add(this.gbx_trinketsFound);
            this.Controls.Add(this.gbx_searchProperties);
            this.Controls.Add(this.lb_numBuffs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbx_buffs);
            this.Name = "BuffSearch";
            this.Text = "Darkest Dungeon Buff Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_searchProperties.ResumeLayout(false);
            this.gbx_searchProperties.PerformLayout();
            this.gbx_trinketsFound.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_buffs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csToolStripMenuItem;
        private System.Windows.Forms.Label lb_numBuffs;
        private System.Windows.Forms.GroupBox gbx_searchProperties;
        private System.Windows.Forms.ComboBox cbx_statType;
        private System.Windows.Forms.Label lb_statType;
        private System.Windows.Forms.ComboBox cbx_statSubType;
        private System.Windows.Forms.Label lb_statSubType;
        private System.Windows.Forms.Label lb_amountValue;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_removeInactive;
        private System.Windows.Forms.Label lb_removeInactiveValue;
        private System.Windows.Forms.Label lb_ruleType;
        private System.Windows.Forms.ComboBox cbx_ruleType;
        private System.Windows.Forms.Label lb_inverseRuleValue;
        private System.Windows.Forms.Label lb_inverseRule;
        private System.Windows.Forms.Label lb_ruleDataKeyValue;
        private System.Windows.Forms.Label lb_ruleDataKey;
        private System.Windows.Forms.Label lb_ruleDataValue;
        private System.Windows.Forms.ComboBox cbx_ruleDataValue;
        private System.Windows.Forms.GroupBox gbx_trinketsFound;
        private System.Windows.Forms.ListBox lbx_trinketsFound;
        private System.Windows.Forms.Button b_showInTrinketSearch;
        private System.Windows.Forms.ListBox lbx_savedBuffs;
        private System.Windows.Forms.Label lb_savedBuffs;
    }
}