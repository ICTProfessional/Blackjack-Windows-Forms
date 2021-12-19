namespace Blackjack_Windows_Forms.Frontend
{
    partial class ResultaatScherm
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
            this.lbl_WinnaarNaam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_PlayerData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_WinnaarNaam
            // 
            this.lbl_WinnaarNaam.AutoSize = true;
            this.lbl_WinnaarNaam.Location = new System.Drawing.Point(237, 12);
            this.lbl_WinnaarNaam.Name = "lbl_WinnaarNaam";
            this.lbl_WinnaarNaam.Size = new System.Drawing.Size(64, 16);
            this.lbl_WinnaarNaam.TabIndex = 0;
            this.lbl_WinnaarNaam.Text = "<naam>...";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(226, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_PlayerData
            // 
            this.lb_PlayerData.FormattingEnabled = true;
            this.lb_PlayerData.ItemHeight = 16;
            this.lb_PlayerData.Location = new System.Drawing.Point(12, 12);
            this.lb_PlayerData.Name = "lb_PlayerData";
            this.lb_PlayerData.Size = new System.Drawing.Size(162, 84);
            this.lb_PlayerData.TabIndex = 8;
            this.lb_PlayerData.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ResultaatScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(469, 190);
            this.Controls.Add(this.lb_PlayerData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_WinnaarNaam);
            this.Name = "ResultaatScherm";
            this.Text = "ResultaatScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WinnaarNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_PlayerData;
    }
}