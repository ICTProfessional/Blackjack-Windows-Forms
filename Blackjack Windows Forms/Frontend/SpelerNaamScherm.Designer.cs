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
            this.lbl_SpelerNaam.Location = new System.Drawing.Point(92, 13);
            this.lbl_SpelerNaam.Name = "lbl_SpelerNaam";
            this.lbl_SpelerNaam.Size = new System.Drawing.Size(185, 16);
            this.lbl_SpelerNaam.TabIndex = 0;
            this.lbl_SpelerNaam.Text = "Voer naam van speler <int> in:";
            // 
            // txt_SpelerNaam
            // 
            this.txt_SpelerNaam.Location = new System.Drawing.Point(95, 53);
            this.txt_SpelerNaam.Name = "txt_SpelerNaam";
            this.txt_SpelerNaam.Size = new System.Drawing.Size(182, 22);
            this.txt_SpelerNaam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(157, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SpelerNaamScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_SpelerNaam);
            this.Controls.Add(this.lbl_SpelerNaam);
            this.Name = "SpelerNaamScherm";
            this.Text = "SpelerNaamScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SpelerNaam;
        private System.Windows.Forms.TextBox txt_SpelerNaam;
        private System.Windows.Forms.Button button1;
    }
}