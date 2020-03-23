namespace AWE_3_1
{
    partial class Aufgabe3
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
            this.btnA3Start = new System.Windows.Forms.Button();
            this.txtA3Endwert = new System.Windows.Forms.TextBox();
            this.lblA3Endwert = new System.Windows.Forms.Label();
            this.lblA3Startwert = new System.Windows.Forms.Label();
            this.txtA3Startwert = new System.Windows.Forms.TextBox();
            this.lbxA3Ausgabe = new System.Windows.Forms.ListBox();
            this.txtA3Zahl = new System.Windows.Forms.TextBox();
            this.lblA3Zahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA3Start
            // 
            this.btnA3Start.Location = new System.Drawing.Point(13, 13);
            this.btnA3Start.Name = "btnA3Start";
            this.btnA3Start.Size = new System.Drawing.Size(75, 23);
            this.btnA3Start.TabIndex = 0;
            this.btnA3Start.Text = "Start";
            this.btnA3Start.UseVisualStyleBackColor = true;
            // 
            // txtA3Endwert
            // 
            this.txtA3Endwert.Location = new System.Drawing.Point(65, 96);
            this.txtA3Endwert.Name = "txtA3Endwert";
            this.txtA3Endwert.Size = new System.Drawing.Size(76, 20);
            this.txtA3Endwert.TabIndex = 10;
            // 
            // lblA3Endwert
            // 
            this.lblA3Endwert.AutoSize = true;
            this.lblA3Endwert.Location = new System.Drawing.Point(10, 99);
            this.lblA3Endwert.Name = "lblA3Endwert";
            this.lblA3Endwert.Size = new System.Drawing.Size(49, 13);
            this.lblA3Endwert.TabIndex = 9;
            this.lblA3Endwert.Text = "Endwert:";
            // 
            // lblA3Startwert
            // 
            this.lblA3Startwert.AutoSize = true;
            this.lblA3Startwert.Location = new System.Drawing.Point(10, 74);
            this.lblA3Startwert.Name = "lblA3Startwert";
            this.lblA3Startwert.Size = new System.Drawing.Size(52, 13);
            this.lblA3Startwert.TabIndex = 8;
            this.lblA3Startwert.Text = "Startwert:";
            // 
            // txtA3Startwert
            // 
            this.txtA3Startwert.Location = new System.Drawing.Point(65, 71);
            this.txtA3Startwert.Name = "txtA3Startwert";
            this.txtA3Startwert.Size = new System.Drawing.Size(76, 20);
            this.txtA3Startwert.TabIndex = 7;
            // 
            // lbxA3Ausgabe
            // 
            this.lbxA3Ausgabe.FormattingEnabled = true;
            this.lbxA3Ausgabe.Location = new System.Drawing.Point(13, 122);
            this.lbxA3Ausgabe.Name = "lbxA3Ausgabe";
            this.lbxA3Ausgabe.Size = new System.Drawing.Size(128, 186);
            this.lbxA3Ausgabe.TabIndex = 6;
            // 
            // txtA3Zahl
            // 
            this.txtA3Zahl.Location = new System.Drawing.Point(65, 45);
            this.txtA3Zahl.Name = "txtA3Zahl";
            this.txtA3Zahl.Size = new System.Drawing.Size(76, 20);
            this.txtA3Zahl.TabIndex = 11;
            // 
            // lblA3Zahl
            // 
            this.lblA3Zahl.AutoSize = true;
            this.lblA3Zahl.Location = new System.Drawing.Point(10, 48);
            this.lblA3Zahl.Name = "lblA3Zahl";
            this.lblA3Zahl.Size = new System.Drawing.Size(31, 13);
            this.lblA3Zahl.TabIndex = 12;
            this.lblA3Zahl.Text = "Zahl:";
            // 
            // Aufgabe3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 322);
            this.Controls.Add(this.lblA3Zahl);
            this.Controls.Add(this.txtA3Zahl);
            this.Controls.Add(this.txtA3Endwert);
            this.Controls.Add(this.lblA3Endwert);
            this.Controls.Add(this.lblA3Startwert);
            this.Controls.Add(this.txtA3Startwert);
            this.Controls.Add(this.lbxA3Ausgabe);
            this.Controls.Add(this.btnA3Start);
            this.Name = "Aufgabe3";
            this.Text = "Aufgabe3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA3Start;
        private System.Windows.Forms.TextBox txtA3Endwert;
        private System.Windows.Forms.Label lblA3Endwert;
        private System.Windows.Forms.Label lblA3Startwert;
        private System.Windows.Forms.TextBox txtA3Startwert;
        private System.Windows.Forms.ListBox lbxA3Ausgabe;
        private System.Windows.Forms.TextBox txtA3Zahl;
        private System.Windows.Forms.Label lblA3Zahl;
    }
}