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
            this.lbl_Kaarten = new System.Windows.Forms.Label();
            this.btn_StartSpel = new System.Windows.Forms.Button();
            this.lbl_Punten = new System.Windows.Forms.Label();
            this.lb_SpelerLijst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SpelerToevoegen = new System.Windows.Forms.Button();
            this.btn_VerwijderSpeler = new System.Windows.Forms.Button();
            this.spelregelsTonenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TrekKaart
            // 
            this.btn_TrekKaart.Enabled = false;
            this.btn_TrekKaart.Location = new System.Drawing.Point(305, 47);
            this.btn_TrekKaart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btn_EindigBeurt.Location = new System.Drawing.Point(305, 177);
            this.btn_EindigBeurt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lbl_SpelerNaam.Location = new System.Drawing.Point(512, 63);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algemeenToolStripMenuItem
            // 
            this.algemeenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spelregelsTonenToolStripMenuItem});
            this.algemeenToolStripMenuItem.Name = "algemeenToolStripMenuItem";
            this.algemeenToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.algemeenToolStripMenuItem.Text = "Menu";
            // 
            // lbl_Kaarten
            // 
            this.lbl_Kaarten.AutoSize = true;
            this.lbl_Kaarten.Location = new System.Drawing.Point(512, 126);
            this.lbl_Kaarten.Name = "lbl_Kaarten";
            this.lbl_Kaarten.Size = new System.Drawing.Size(74, 16);
            this.lbl_Kaarten.TabIndex = 7;
            this.lbl_Kaarten.Text = "<[kaarten]>";
            this.lbl_Kaarten.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_StartSpel
            // 
            this.btn_StartSpel.Location = new System.Drawing.Point(305, 354);
            this.btn_StartSpel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lbl_Punten.Location = new System.Drawing.Point(512, 210);
            this.lbl_Punten.Name = "lbl_Punten";
            this.lbl_Punten.Size = new System.Drawing.Size(61, 16);
            this.lbl_Punten.TabIndex = 9;
            this.lbl_Punten.Text = "<punten>";
            // 
            // lb_SpelerLijst
            // 
            this.lb_SpelerLijst.FormattingEnabled = true;
            this.lb_SpelerLijst.ItemHeight = 16;
            this.lb_SpelerLijst.Items.AddRange(new object[] {
            "Dealer"});
            this.lb_SpelerLijst.Location = new System.Drawing.Point(15, 86);
            this.lb_SpelerLijst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_SpelerLijst.Name = "lb_SpelerLijst";
            this.lb_SpelerLijst.Size = new System.Drawing.Size(120, 180);
            this.lb_SpelerLijst.TabIndex = 10;
            this.lb_SpelerLijst.SelectedIndexChanged += new System.EventHandler(this.lb_SpelerLijst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spelers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Naam:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aantal punten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kaarten:";
            // 
            // btn_SpelerToevoegen
            // 
            this.btn_SpelerToevoegen.Location = new System.Drawing.Point(17, 304);
            this.btn_SpelerToevoegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SpelerToevoegen.Name = "btn_SpelerToevoegen";
            this.btn_SpelerToevoegen.Size = new System.Drawing.Size(119, 28);
            this.btn_SpelerToevoegen.TabIndex = 15;
            this.btn_SpelerToevoegen.Text = "Voeg speler toe";
            this.btn_SpelerToevoegen.UseVisualStyleBackColor = true;
            this.btn_SpelerToevoegen.Click += new System.EventHandler(this.btn_SpelerToevoegen_Click);
            // 
            // btn_VerwijderSpeler
            // 
            this.btn_VerwijderSpeler.Location = new System.Drawing.Point(144, 304);
            this.btn_VerwijderSpeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_VerwijderSpeler.Name = "btn_VerwijderSpeler";
            this.btn_VerwijderSpeler.Size = new System.Drawing.Size(119, 28);
            this.btn_VerwijderSpeler.TabIndex = 16;
            this.btn_VerwijderSpeler.Text = "Verwijder speler";
            this.btn_VerwijderSpeler.UseVisualStyleBackColor = true;
            this.btn_VerwijderSpeler.Click += new System.EventHandler(this.btn_VerwijderSpeler_Click);
            // 
            // spelregelsTonenToolStripMenuItem
            // 
            this.spelregelsTonenToolStripMenuItem.Name = "spelregelsTonenToolStripMenuItem";
            this.spelregelsTonenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.spelregelsTonenToolStripMenuItem.Text = "Spelregels tonen";
            this.spelregelsTonenToolStripMenuItem.Click += new System.EventHandler(this.spelregelsTonenToolStripMenuItem_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_VerwijderSpeler);
            this.Controls.Add(this.btn_SpelerToevoegen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Blackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbl_Kaarten;
        private System.Windows.Forms.Button btn_StartSpel;
        private System.Windows.Forms.Label lbl_Punten;
        private System.Windows.Forms.ListBox lb_SpelerLijst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SpelerToevoegen;
        private System.Windows.Forms.Button btn_VerwijderSpeler;
        private System.Windows.Forms.ToolStripMenuItem spelregelsTonenToolStripMenuItem;
    }
}

