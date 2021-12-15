namespace Blackjack_Windows_Forms
{
    partial class Form1
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
            this.lbl_SpelerGeld = new System.Windows.Forms.Label();
            this.lbl_SpelerInzet = new System.Windows.Forms.Label();
            this.lbl_Kaarten = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TrekKaart
            // 
            this.btn_TrekKaart.Location = new System.Drawing.Point(155, 78);
            this.btn_TrekKaart.Name = "btn_TrekKaart";
            this.btn_TrekKaart.Size = new System.Drawing.Size(144, 111);
            this.btn_TrekKaart.TabIndex = 0;
            this.btn_TrekKaart.Text = "Trek kaart";
            this.btn_TrekKaart.UseVisualStyleBackColor = true;
            this.btn_TrekKaart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_EindigBeurt
            // 
            this.btn_EindigBeurt.Location = new System.Drawing.Point(543, 78);
            this.btn_EindigBeurt.Name = "btn_EindigBeurt";
            this.btn_EindigBeurt.Size = new System.Drawing.Size(144, 111);
            this.btn_EindigBeurt.TabIndex = 1;
            this.btn_EindigBeurt.Text = "Eindig beurt";
            this.btn_EindigBeurt.UseVisualStyleBackColor = true;
            // 
            // lbl_SpelerNaam
            // 
            this.lbl_SpelerNaam.AutoSize = true;
            this.lbl_SpelerNaam.Location = new System.Drawing.Point(355, 78);
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
            this.spelregelsTonenToolStripMenuItem});
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
            // lbl_SpelerGeld
            // 
            this.lbl_SpelerGeld.AutoSize = true;
            this.lbl_SpelerGeld.Location = new System.Drawing.Point(363, 125);
            this.lbl_SpelerGeld.Name = "lbl_SpelerGeld";
            this.lbl_SpelerGeld.Size = new System.Drawing.Size(93, 16);
            this.lbl_SpelerGeld.TabIndex = 5;
            this.lbl_SpelerGeld.Text = "<Speler Geld>";
            // 
            // lbl_SpelerInzet
            // 
            this.lbl_SpelerInzet.AutoSize = true;
            this.lbl_SpelerInzet.Location = new System.Drawing.Point(363, 173);
            this.lbl_SpelerInzet.Name = "lbl_SpelerInzet";
            this.lbl_SpelerInzet.Size = new System.Drawing.Size(91, 16);
            this.lbl_SpelerInzet.TabIndex = 6;
            this.lbl_SpelerInzet.Text = "<Speler Inzet>";
            // 
            // lbl_Kaarten
            // 
            this.lbl_Kaarten.AutoSize = true;
            this.lbl_Kaarten.Location = new System.Drawing.Point(313, 246);
            this.lbl_Kaarten.Name = "lbl_Kaarten";
            this.lbl_Kaarten.Size = new System.Drawing.Size(203, 16);
            this.lbl_Kaarten.TabIndex = 7;
            this.lbl_Kaarten.Text = "Harten 8, Klaveren 9, Harten boer";
            this.lbl_Kaarten.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Kaarten);
            this.Controls.Add(this.lbl_SpelerInzet);
            this.Controls.Add(this.lbl_SpelerGeld);
            this.Controls.Add(this.lbl_SpelerNaam);
            this.Controls.Add(this.btn_EindigBeurt);
            this.Controls.Add(this.btn_TrekKaart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lbl_SpelerGeld;
        private System.Windows.Forms.Label lbl_SpelerInzet;
        private System.Windows.Forms.Label lbl_Kaarten;
    }
}

