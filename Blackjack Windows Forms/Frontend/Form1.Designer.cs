namespace Blackjack_Windows_Forms.Frontend
{
    partial class Blackjack
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
            this.btn_TrekKaart = new System.Windows.Forms.Button();
            this.btn_EindigBeurt = new System.Windows.Forms.Button();
            this.lbl_SpelerNaam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algemeenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spelregelsTonenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voegSpelersToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herstartSpelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Kaarten = new System.Windows.Forms.Label();
            this.btn_StartSpel = new System.Windows.Forms.Button();
            this.lbl_Punten = new System.Windows.Forms.Label();
            this.lb_SpelerLijst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TrekKaart
            // 
            this.btn_TrekKaart.Enabled = false;
            this.btn_TrekKaart.Location = new System.Drawing.Point(155, 78);
            this.btn_TrekKaart.Name = "btn_TrekKaart";
            this.btn_TrekKaart.Size = new System.Drawing.Size(144, 111);
            this.btn_TrekKaart.TabIndex = 0;
            this.btn_TrekKaart.Text = "Trek kaart";
            this.btn_TrekKaart.UseVisualStyleBackColor = true;
            this.btn_TrekKaart.Click += new System.EventHandler(this.btn_TrekKaart_Click);
            // 
            // btn_EindigBeurt
            // 
            this.btn_EindigBeurt.Enabled = false;
            this.btn_EindigBeurt.Location = new System.Drawing.Point(543, 78);
            this.btn_EindigBeurt.Name = "btn_EindigBeurt";
            this.btn_EindigBeurt.Size = new System.Drawing.Size(144, 111);
            this.btn_EindigBeurt.TabIndex = 1;
            this.btn_EindigBeurt.Text = "Eindig beurt";
            this.btn_EindigBeurt.UseVisualStyleBackColor = true;
            this.btn_EindigBeurt.Click += new System.EventHandler(this.btn_EindigBeurt_Click);
            // 
            // lbl_SpelerNaam
            // 
            this.lbl_SpelerNaam.AutoSize = true;
            this.lbl_SpelerNaam.Location = new System.Drawing.Point(368, 125);
            this.lbl_SpelerNaam.Name = "lbl_SpelerNaam";
            this.lbl_SpelerNaam.Size = new System.Drawing.Size(101, 16);
            this.lbl_SpelerNaam.TabIndex = 2;
            this.lbl_SpelerNaam.Text = "<Speler Naam>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algemeenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algemeenToolStripMenuItem
            // 
            this.algemeenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spelregelsTonenToolStripMenuItem,
            this.voegSpelersToeToolStripMenuItem,
            this.herstartSpelToolStripMenuItem});
            this.algemeenToolStripMenuItem.Name = "algemeenToolStripMenuItem";
            this.algemeenToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.algemeenToolStripMenuItem.Text = "Algemeen";
            // 
            // spelregelsTonenToolStripMenuItem
            // 
            this.spelregelsTonenToolStripMenuItem.Name = "spelregelsTonenToolStripMenuItem";
            this.spelregelsTonenToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.spelregelsTonenToolStripMenuItem.Text = "Spelregels tonen";
            // 
            // voegSpelersToeToolStripMenuItem
            // 
            this.voegSpelersToeToolStripMenuItem.Name = "voegSpelersToeToolStripMenuItem";
            this.voegSpelersToeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voegSpelersToeToolStripMenuItem.Text = "Verander spelers";
            this.voegSpelersToeToolStripMenuItem.Click += new System.EventHandler(this.voegSpelersToeToolStripMenuItem_Click);
            // 
            // herstartSpelToolStripMenuItem
            // 
            this.herstartSpelToolStripMenuItem.Name = "herstartSpelToolStripMenuItem";
            this.herstartSpelToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.herstartSpelToolStripMenuItem.Text = "Herstart spel";
            // 
            // lbl_Kaarten
            // 
            this.lbl_Kaarten.AutoSize = true;
            this.lbl_Kaarten.Location = new System.Drawing.Point(368, 206);
            this.lbl_Kaarten.Name = "lbl_Kaarten";
            this.lbl_Kaarten.Size = new System.Drawing.Size(74, 16);
            this.lbl_Kaarten.TabIndex = 7;
            this.lbl_Kaarten.Text = "<[kaarten]>";
            this.lbl_Kaarten.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_StartSpel
            // 
            this.btn_StartSpel.Location = new System.Drawing.Point(371, 305);
            this.btn_StartSpel.Name = "btn_StartSpel";
            this.btn_StartSpel.Size = new System.Drawing.Size(129, 68);
            this.btn_StartSpel.TabIndex = 8;
            this.btn_StartSpel.Text = "Start spel";
            this.btn_StartSpel.UseVisualStyleBackColor = true;
            this.btn_StartSpel.Click += new System.EventHandler(this.btn_StartSpel_Click);
            // 
            // lbl_Punten
            // 
            this.lbl_Punten.AutoSize = true;
            this.lbl_Punten.Location = new System.Drawing.Point(368, 243);
            this.lbl_Punten.Name = "lbl_Punten";
            this.lbl_Punten.Size = new System.Drawing.Size(148, 16);
            this.lbl_Punten.TabIndex = 9;
            this.lbl_Punten.Text = "Aantal punten: <punten>";
            // 
            // lb_SpelerLijst
            // 
            this.lb_SpelerLijst.FormattingEnabled = true;
            this.lb_SpelerLijst.ItemHeight = 16;
            this.lb_SpelerLijst.Location = new System.Drawing.Point(35, 222);
            this.lb_SpelerLijst.Name = "lb_SpelerLijst";
            this.lb_SpelerLijst.Size = new System.Drawing.Size(120, 180);
            this.lb_SpelerLijst.TabIndex = 10;
            this.lb_SpelerLijst.SelectedIndexChanged += new System.EventHandler(this.lb_SpelerLijst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spelers";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_SpelerLijst);
            this.Controls.Add(this.lbl_Punten);
            this.Controls.Add(this.btn_StartSpel);
            this.Controls.Add(this.lbl_Kaarten);
            this.Controls.Add(this.lbl_SpelerNaam);
            this.Controls.Add(this.btn_EindigBeurt);
            this.Controls.Add(this.btn_TrekKaart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Blackjack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TrekKaart;
        private System.Windows.Forms.Button btn_EindigBeurt;
        private System.Windows.Forms.Label lbl_SpelerNaam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algemeenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spelregelsTonenToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Kaarten;
        private System.Windows.Forms.ToolStripMenuItem voegSpelersToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herstartSpelToolStripMenuItem;
        private System.Windows.Forms.Button btn_StartSpel;
        private System.Windows.Forms.Label lbl_Punten;
        private System.Windows.Forms.ListBox lb_SpelerLijst;
        private System.Windows.Forms.Label label1;
    }
}

