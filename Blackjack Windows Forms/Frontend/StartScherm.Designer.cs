namespace Blackjack_Windows_Forms.Frontend
{
    partial class StartScherm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_AantalSpelers = new System.Windows.Forms.NumericUpDown();
            this.btn_StartSpel = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_AantalSpelers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom bij Blackjack!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoeveel mensen spelen mee?";
            // 
            // num_AantalSpelers
            // 
            this.num_AantalSpelers.Location = new System.Drawing.Point(314, 116);
            this.num_AantalSpelers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_AantalSpelers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_AantalSpelers.Name = "num_AantalSpelers";
            this.num_AantalSpelers.Size = new System.Drawing.Size(120, 22);
            this.num_AantalSpelers.TabIndex = 2;
            this.num_AantalSpelers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_StartSpel
            // 
            this.btn_StartSpel.Location = new System.Drawing.Point(314, 274);
            this.btn_StartSpel.Name = "btn_StartSpel";
            this.btn_StartSpel.Size = new System.Drawing.Size(113, 41);
            this.btn_StartSpel.TabIndex = 3;
            this.btn_StartSpel.Text = "Start spel";
            this.btn_StartSpel.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(119, 184);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(238, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Wat is de naam van speler <nummer>?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // StartScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btn_StartSpel);
            this.Controls.Add(this.num_AantalSpelers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartScherm";
            this.Text = "StartScherm";
            ((System.ComponentModel.ISupportInitialize)(this.num_AantalSpelers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_AantalSpelers;
        private System.Windows.Forms.Button btn_StartSpel;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}