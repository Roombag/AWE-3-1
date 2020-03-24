namespace AWE_3_1
{
    partial class Aufgabe4
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
            this.btnA4Start = new System.Windows.Forms.Button();
            this.txtA4Eingabe = new System.Windows.Forms.TextBox();
            this.lblA4Eingabe = new System.Windows.Forms.Label();
            this.lbxA4Ausgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnA4Start
            // 
            this.btnA4Start.Location = new System.Drawing.Point(13, 13);
            this.btnA4Start.Name = "btnA4Start";
            this.btnA4Start.Size = new System.Drawing.Size(75, 23);
            this.btnA4Start.TabIndex = 0;
            this.btnA4Start.Text = "Start";
            this.btnA4Start.UseVisualStyleBackColor = true;
            this.btnA4Start.Click += new System.EventHandler(this.btnA4Start_Click);
            // 
            // txtA4Eingabe
            // 
            this.txtA4Eingabe.Location = new System.Drawing.Point(15, 55);
            this.txtA4Eingabe.Name = "txtA4Eingabe";
            this.txtA4Eingabe.Size = new System.Drawing.Size(146, 20);
            this.txtA4Eingabe.TabIndex = 1;
            // 
            // lblA4Eingabe
            // 
            this.lblA4Eingabe.AutoSize = true;
            this.lblA4Eingabe.Location = new System.Drawing.Point(12, 39);
            this.lblA4Eingabe.Name = "lblA4Eingabe";
            this.lblA4Eingabe.Size = new System.Drawing.Size(49, 13);
            this.lblA4Eingabe.TabIndex = 2;
            this.lblA4Eingabe.Text = "Eingabe:";
            // 
            // lbxA4Ausgabe
            // 
            this.lbxA4Ausgabe.FormattingEnabled = true;
            this.lbxA4Ausgabe.Location = new System.Drawing.Point(15, 81);
            this.lbxA4Ausgabe.Name = "lbxA4Ausgabe";
            this.lbxA4Ausgabe.Size = new System.Drawing.Size(146, 186);
            this.lbxA4Ausgabe.TabIndex = 3;
            // 
            // Aufgabe4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 281);
            this.Controls.Add(this.lbxA4Ausgabe);
            this.Controls.Add(this.lblA4Eingabe);
            this.Controls.Add(this.txtA4Eingabe);
            this.Controls.Add(this.btnA4Start);
            this.Name = "Aufgabe4";
            this.Text = "Aufgabe4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA4Start;
        private System.Windows.Forms.TextBox txtA4Eingabe;
        private System.Windows.Forms.Label lblA4Eingabe;
        private System.Windows.Forms.ListBox lbxA4Ausgabe;
    }
}