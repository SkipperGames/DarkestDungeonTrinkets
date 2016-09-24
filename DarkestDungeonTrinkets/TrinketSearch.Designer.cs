namespace DarkestDungeon
{
    partial class TrinketSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrinketSearch));
            this.lbx_trinkets = new System.Windows.Forms.ListBox();
            this.lb_numTrinkets = new System.Windows.Forms.Label();
            this.gbx_searchProperties = new System.Windows.Forms.GroupBox();
            this.b_random = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.cbx_dungeon = new System.Windows.Forms.ComboBox();
            this.lb_dungeon = new System.Windows.Forms.Label();
            this.gbx_limit = new System.Windows.Forms.GroupBox();
            this.rb_limitNo = new System.Windows.Forms.RadioButton();
            this.rb_limitYes = new System.Windows.Forms.RadioButton();
            this.lb_priceTo = new System.Windows.Forms.Label();
            this.lb_priceMax = new System.Windows.Forms.Label();
            this.nud_priceMax = new System.Windows.Forms.NumericUpDown();
            this.lb_priceMin = new System.Windows.Forms.Label();
            this.nud_priceMin = new System.Windows.Forms.NumericUpDown();
            this.lb_price = new System.Windows.Forms.Label();
            this.cbx_rarity = new System.Windows.Forms.ComboBox();
            this.lb_rarity = new System.Windows.Forms.Label();
            this.cbx_classRequirement = new System.Windows.Forms.ComboBox();
            this.lb_class = new System.Windows.Forms.Label();
            this.pbx_trinketImage = new System.Windows.Forms.PictureBox();
            this.gbx_properties = new System.Windows.Forms.GroupBox();
            this.b_showInBuffSearch = new System.Windows.Forms.Button();
            this.lbx_buffs = new System.Windows.Forms.ListBox();
            this.lb_trinketProperties = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buffSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.rb_limitBoth = new System.Windows.Forms.RadioButton();
            this.gbx_searchProperties.SuspendLayout();
            this.gbx_limit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_trinketImage)).BeginInit();
            this.gbx_properties.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_trinkets
            // 
            this.lbx_trinkets.FormattingEnabled = true;
            this.lbx_trinkets.Location = new System.Drawing.Point(12, 52);
            this.lbx_trinkets.Name = "lbx_trinkets";
            this.lbx_trinkets.Size = new System.Drawing.Size(193, 537);
            this.lbx_trinkets.TabIndex = 0;
            this.lbx_trinkets.SelectedIndexChanged += new System.EventHandler(this.lbx_trinkets_SelectedIndexChanged);
            // 
            // lb_numTrinkets
            // 
            this.lb_numTrinkets.AutoSize = true;
            this.lb_numTrinkets.Location = new System.Drawing.Point(12, 36);
            this.lb_numTrinkets.Name = "lb_numTrinkets";
            this.lb_numTrinkets.Size = new System.Drawing.Size(45, 13);
            this.lb_numTrinkets.TabIndex = 1;
            this.lb_numTrinkets.Text = "Trinkets";
            // 
            // gbx_searchProperties
            // 
            this.gbx_searchProperties.Controls.Add(this.b_random);
            this.gbx_searchProperties.Controls.Add(this.b_reset);
            this.gbx_searchProperties.Controls.Add(this.b_search);
            this.gbx_searchProperties.Controls.Add(this.cbx_dungeon);
            this.gbx_searchProperties.Controls.Add(this.lb_dungeon);
            this.gbx_searchProperties.Controls.Add(this.gbx_limit);
            this.gbx_searchProperties.Controls.Add(this.lb_priceTo);
            this.gbx_searchProperties.Controls.Add(this.lb_priceMax);
            this.gbx_searchProperties.Controls.Add(this.nud_priceMax);
            this.gbx_searchProperties.Controls.Add(this.lb_priceMin);
            this.gbx_searchProperties.Controls.Add(this.nud_priceMin);
            this.gbx_searchProperties.Controls.Add(this.lb_price);
            this.gbx_searchProperties.Controls.Add(this.cbx_rarity);
            this.gbx_searchProperties.Controls.Add(this.lb_rarity);
            this.gbx_searchProperties.Controls.Add(this.cbx_classRequirement);
            this.gbx_searchProperties.Controls.Add(this.lb_class);
            this.gbx_searchProperties.Location = new System.Drawing.Point(212, 36);
            this.gbx_searchProperties.Name = "gbx_searchProperties";
            this.gbx_searchProperties.Size = new System.Drawing.Size(400, 220);
            this.gbx_searchProperties.TabIndex = 2;
            this.gbx_searchProperties.TabStop = false;
            this.gbx_searchProperties.Text = "Search Properties";
            // 
            // b_random
            // 
            this.b_random.Location = new System.Drawing.Point(87, 191);
            this.b_random.Name = "b_random";
            this.b_random.Size = new System.Drawing.Size(75, 23);
            this.b_random.TabIndex = 17;
            this.b_random.Text = "random";
            this.b_random.UseVisualStyleBackColor = true;
            this.b_random.Click += new System.EventHandler(this.b_random_Click);
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(168, 191);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 16;
            this.b_reset.Text = "reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(6, 191);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 23);
            this.b_search.TabIndex = 15;
            this.b_search.Text = "search";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // cbx_dungeon
            // 
            this.cbx_dungeon.FormattingEnabled = true;
            this.cbx_dungeon.Location = new System.Drawing.Point(110, 129);
            this.cbx_dungeon.Name = "cbx_dungeon";
            this.cbx_dungeon.Size = new System.Drawing.Size(121, 21);
            this.cbx_dungeon.TabIndex = 14;
            // 
            // lb_dungeon
            // 
            this.lb_dungeon.AutoSize = true;
            this.lb_dungeon.Location = new System.Drawing.Point(6, 132);
            this.lb_dungeon.Name = "lb_dungeon";
            this.lb_dungeon.Size = new System.Drawing.Size(77, 13);
            this.lb_dungeon.TabIndex = 13;
            this.lb_dungeon.Text = "origin dungeon";
            // 
            // gbx_limit
            // 
            this.gbx_limit.Controls.Add(this.rb_limitBoth);
            this.gbx_limit.Controls.Add(this.rb_limitYes);
            this.gbx_limit.Controls.Add(this.rb_limitNo);
            this.gbx_limit.Location = new System.Drawing.Point(274, 128);
            this.gbx_limit.Name = "gbx_limit";
            this.gbx_limit.Size = new System.Drawing.Size(120, 86);
            this.gbx_limit.TabIndex = 12;
            this.gbx_limit.TabStop = false;
            this.gbx_limit.Text = "Limit?";
            // 
            // rb_limitNo
            // 
            this.rb_limitNo.AutoSize = true;
            this.rb_limitNo.Location = new System.Drawing.Point(62, 19);
            this.rb_limitNo.Name = "rb_limitNo";
            this.rb_limitNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_limitNo.Size = new System.Drawing.Size(37, 17);
            this.rb_limitNo.TabIndex = 1;
            this.rb_limitNo.Text = "no";
            this.rb_limitNo.UseVisualStyleBackColor = true;
            // 
            // rb_limitYes
            // 
            this.rb_limitYes.AutoSize = true;
            this.rb_limitYes.Location = new System.Drawing.Point(58, 42);
            this.rb_limitYes.Name = "rb_limitYes";
            this.rb_limitYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_limitYes.Size = new System.Drawing.Size(41, 17);
            this.rb_limitYes.TabIndex = 0;
            this.rb_limitYes.Text = "yes";
            this.rb_limitYes.UseVisualStyleBackColor = true;
            // 
            // lb_priceTo
            // 
            this.lb_priceTo.AutoSize = true;
            this.lb_priceTo.Location = new System.Drawing.Point(245, 104);
            this.lb_priceTo.Name = "lb_priceTo";
            this.lb_priceTo.Size = new System.Drawing.Size(16, 13);
            this.lb_priceTo.TabIndex = 11;
            this.lb_priceTo.Text = "to";
            // 
            // lb_priceMax
            // 
            this.lb_priceMax.AutoSize = true;
            this.lb_priceMax.Location = new System.Drawing.Point(271, 83);
            this.lb_priceMax.Name = "lb_priceMax";
            this.lb_priceMax.Size = new System.Drawing.Size(26, 13);
            this.lb_priceMax.TabIndex = 10;
            this.lb_priceMax.Text = "max";
            // 
            // nud_priceMax
            // 
            this.nud_priceMax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_priceMax.Location = new System.Drawing.Point(274, 102);
            this.nud_priceMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_priceMax.Name = "nud_priceMax";
            this.nud_priceMax.Size = new System.Drawing.Size(120, 20);
            this.nud_priceMax.TabIndex = 9;
            // 
            // lb_priceMin
            // 
            this.lb_priceMin.AutoSize = true;
            this.lb_priceMin.Location = new System.Drawing.Point(107, 83);
            this.lb_priceMin.Name = "lb_priceMin";
            this.lb_priceMin.Size = new System.Drawing.Size(23, 13);
            this.lb_priceMin.TabIndex = 8;
            this.lb_priceMin.Text = "min";
            // 
            // nud_priceMin
            // 
            this.nud_priceMin.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_priceMin.Location = new System.Drawing.Point(110, 102);
            this.nud_priceMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_priceMin.Name = "nud_priceMin";
            this.nud_priceMin.Size = new System.Drawing.Size(120, 20);
            this.nud_priceMin.TabIndex = 7;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(6, 104);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(66, 13);
            this.lb_price.TabIndex = 6;
            this.lb_price.Text = "price (range)";
            // 
            // cbx_rarity
            // 
            this.cbx_rarity.FormattingEnabled = true;
            this.cbx_rarity.Location = new System.Drawing.Point(110, 47);
            this.cbx_rarity.Name = "cbx_rarity";
            this.cbx_rarity.Size = new System.Drawing.Size(121, 21);
            this.cbx_rarity.TabIndex = 5;
            // 
            // lb_rarity
            // 
            this.lb_rarity.AutoSize = true;
            this.lb_rarity.Location = new System.Drawing.Point(6, 50);
            this.lb_rarity.Name = "lb_rarity";
            this.lb_rarity.Size = new System.Drawing.Size(29, 13);
            this.lb_rarity.TabIndex = 4;
            this.lb_rarity.Text = "rarity";
            // 
            // cbx_classRequirement
            // 
            this.cbx_classRequirement.FormattingEnabled = true;
            this.cbx_classRequirement.Location = new System.Drawing.Point(110, 19);
            this.cbx_classRequirement.Name = "cbx_classRequirement";
            this.cbx_classRequirement.Size = new System.Drawing.Size(121, 21);
            this.cbx_classRequirement.TabIndex = 3;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(6, 22);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(79, 13);
            this.lb_class.TabIndex = 2;
            this.lb_class.Text = "class restriction";
            // 
            // pbx_trinketImage
            // 
            this.pbx_trinketImage.BackColor = System.Drawing.Color.Black;
            this.pbx_trinketImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbx_trinketImage.ErrorImage")));
            this.pbx_trinketImage.Location = new System.Drawing.Point(6, 19);
            this.pbx_trinketImage.Name = "pbx_trinketImage";
            this.pbx_trinketImage.Size = new System.Drawing.Size(72, 144);
            this.pbx_trinketImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_trinketImage.TabIndex = 3;
            this.pbx_trinketImage.TabStop = false;
            // 
            // gbx_properties
            // 
            this.gbx_properties.Controls.Add(this.b_showInBuffSearch);
            this.gbx_properties.Controls.Add(this.lbx_buffs);
            this.gbx_properties.Controls.Add(this.lb_trinketProperties);
            this.gbx_properties.Controls.Add(this.pbx_trinketImage);
            this.gbx_properties.Location = new System.Drawing.Point(212, 262);
            this.gbx_properties.Name = "gbx_properties";
            this.gbx_properties.Size = new System.Drawing.Size(400, 328);
            this.gbx_properties.TabIndex = 4;
            this.gbx_properties.TabStop = false;
            this.gbx_properties.Text = "Trinket Properties";
            // 
            // b_showInBuffSearch
            // 
            this.b_showInBuffSearch.Location = new System.Drawing.Point(6, 283);
            this.b_showInBuffSearch.Name = "b_showInBuffSearch";
            this.b_showInBuffSearch.Size = new System.Drawing.Size(160, 23);
            this.b_showInBuffSearch.TabIndex = 6;
            this.b_showInBuffSearch.Text = "show in buff search";
            this.b_showInBuffSearch.UseVisualStyleBackColor = true;
            this.b_showInBuffSearch.Click += new System.EventHandler(this.b_showInBuffSearch_Click);
            // 
            // lbx_buffs
            // 
            this.lbx_buffs.FormattingEnabled = true;
            this.lbx_buffs.Location = new System.Drawing.Point(6, 169);
            this.lbx_buffs.Name = "lbx_buffs";
            this.lbx_buffs.Size = new System.Drawing.Size(160, 108);
            this.lbx_buffs.TabIndex = 5;
            // 
            // lb_trinketProperties
            // 
            this.lb_trinketProperties.AutoSize = true;
            this.lb_trinketProperties.Location = new System.Drawing.Point(87, 20);
            this.lb_trinketProperties.Name = "lb_trinketProperties";
            this.lb_trinketProperties.Size = new System.Drawing.Size(33, 13);
            this.lb_trinketProperties.TabIndex = 4;
            this.lb_trinketProperties.Text = "value";
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
            this.menuStrip1.TabIndex = 5;
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buffSearchToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // buffSearchToolStripMenuItem
            // 
            this.buffSearchToolStripMenuItem.Name = "buffSearchToolStripMenuItem";
            this.buffSearchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.buffSearchToolStripMenuItem.Text = "Buff Search";
            this.buffSearchToolStripMenuItem.Click += new System.EventHandler(this.buffSearchToolStripMenuItem_Click);
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
            // rb_limitBoth
            // 
            this.rb_limitBoth.AutoSize = true;
            this.rb_limitBoth.Checked = true;
            this.rb_limitBoth.Location = new System.Drawing.Point(6, 19);
            this.rb_limitBoth.Name = "rb_limitBoth";
            this.rb_limitBoth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_limitBoth.Size = new System.Drawing.Size(46, 17);
            this.rb_limitBoth.TabIndex = 2;
            this.rb_limitBoth.TabStop = true;
            this.rb_limitBoth.Text = "both";
            this.rb_limitBoth.UseVisualStyleBackColor = true;
            // 
            // TrinketSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.gbx_properties);
            this.Controls.Add(this.gbx_searchProperties);
            this.Controls.Add(this.lb_numTrinkets);
            this.Controls.Add(this.lbx_trinkets);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrinketSearch";
            this.Text = "Darkest Dungeon Trinkets";
            this.gbx_searchProperties.ResumeLayout(false);
            this.gbx_searchProperties.PerformLayout();
            this.gbx_limit.ResumeLayout(false);
            this.gbx_limit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_trinketImage)).EndInit();
            this.gbx_properties.ResumeLayout(false);
            this.gbx_properties.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_trinkets;
        private System.Windows.Forms.Label lb_numTrinkets;
        private System.Windows.Forms.GroupBox gbx_searchProperties;
        private System.Windows.Forms.ComboBox cbx_classRequirement;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.ComboBox cbx_rarity;
        private System.Windows.Forms.Label lb_rarity;
        private System.Windows.Forms.NumericUpDown nud_priceMax;
        private System.Windows.Forms.Label lb_priceMin;
        private System.Windows.Forms.NumericUpDown nud_priceMin;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_priceMax;
        private System.Windows.Forms.Label lb_priceTo;
        private System.Windows.Forms.GroupBox gbx_limit;
        private System.Windows.Forms.RadioButton rb_limitNo;
        private System.Windows.Forms.RadioButton rb_limitYes;
        private System.Windows.Forms.ComboBox cbx_dungeon;
        private System.Windows.Forms.Label lb_dungeon;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.PictureBox pbx_trinketImage;
        private System.Windows.Forms.GroupBox gbx_properties;
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
        private System.Windows.Forms.Button b_random;
        private System.Windows.Forms.ToolStripMenuItem buffSearchToolStripMenuItem;
        private System.Windows.Forms.Label lb_trinketProperties;
        private System.Windows.Forms.ListBox lbx_buffs;
        private System.Windows.Forms.Button b_showInBuffSearch;
        private System.Windows.Forms.RadioButton rb_limitBoth;
    }
}

