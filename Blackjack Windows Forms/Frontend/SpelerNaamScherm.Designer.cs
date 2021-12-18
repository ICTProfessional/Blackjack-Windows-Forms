namespace Blackjack_Windows_Forms.Frontend
{
    partial class SpelerNaamScherm
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
            this.lbl_SpelerNaam = new System.Windows.Forms.Label();
            this.txt_SpelerNaam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SpelerNaam
            // 
            this.lbl_SpelerNaam.AutoSize = true;
            this.lbl_SpelerNaam.Location = new System.Drawing.Point(69, 11);
            this.lbl_SpelerNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SpelerNaam.Name = "lbl_SpelerNaam";
            this.lbl_SpelerNaam.Size = new System.Drawing.Size(124, 13);
            this.lbl_SpelerNaam.TabIndex = 0;
            this.lbl_SpelerNaam.Text = "Voer naam van speler in:";
            // 
            // txt_SpelerNaam
            // 
            this.txt_SpelerNaam.Location = new System.Drawing.Point(71, 43);
            this.txt_SpelerNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SpelerNaam.Name = "txt_SpelerNaam";
            this.txt_SpelerNaam.Size = new System.Drawing.Size(138, 20);
            this.txt_SpelerNaam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(118, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SpelerNaamScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_SpelerNaam);
            this.Controls.Add(this.lbl_SpelerNaam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpelerNaamScherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpelerNaamScherm";
            this.Load += new System.EventHandler(this.SpelerNaamScherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SpelerNaam;
        private System.Windows.Forms.TextBox txt_SpelerNaam;
        private System.Windows.Forms.Button button1;
    }
}