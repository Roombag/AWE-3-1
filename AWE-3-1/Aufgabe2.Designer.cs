namespace AWE_3_1
{
    partial class Aufgabe2
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
            this.btnA2Start = new System.Windows.Forms.Button();
            this.lbxA2Ausgabe = new System.Windows.Forms.ListBox();
            this.txtA2Startwert = new System.Windows.Forms.TextBox();
            this.lblA2Startwert = new System.Windows.Forms.Label();
            this.lblA2Endwert = new System.Windows.Forms.Label();
            this.txtA2Endwert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnA2Start
            // 
            this.btnA2Start.Location = new System.Drawing.Point(13, 13);
            this.btnA2Start.Name = "btnA2Start";
            this.btnA2Start.Size = new System.Drawing.Size(75, 23);
            this.btnA2Start.TabIndex = 0;
            this.btnA2Start.Text = "Start";
            this.btnA2Start.UseVisualStyleBackColor = true;
            // 
            // lbxA2Ausgabe
            // 
            this.lbxA2Ausgabe.FormattingEnabled = true;
            this.lbxA2Ausgabe.Location = new System.Drawing.Point(15, 97);
            this.lbxA2Ausgabe.Name = "lbxA2Ausgabe";
            this.lbxA2Ausgabe.Size = new System.Drawing.Size(128, 186);
            this.lbxA2Ausgabe.TabIndex = 1;
            // 
            // txtA2Startwert
            // 
            this.txtA2Startwert.Location = new System.Drawing.Point(67, 46);
            this.txtA2Startwert.Name = "txtA2Startwert";
            this.txtA2Startwert.Size = new System.Drawing.Size(76, 20);
            this.txtA2Startwert.TabIndex = 2;
            // 
            // lblA2Startwert
            // 
            this.lblA2Startwert.AutoSize = true;
            this.lblA2Startwert.Location = new System.Drawing.Point(12, 49);
            this.lblA2Startwert.Name = "lblA2Startwert";
            this.lblA2Startwert.Size = new System.Drawing.Size(52, 13);
            this.lblA2Startwert.TabIndex = 3;
            this.lblA2Startwert.Text = "Startwert:";
            // 
            // lblA2Endwert
            // 
            this.lblA2Endwert.AutoSize = true;
            this.lblA2Endwert.Location = new System.Drawing.Point(12, 74);
            this.lblA2Endwert.Name = "lblA2Endwert";
            this.lblA2Endwert.Size = new System.Drawing.Size(49, 13);
            this.lblA2Endwert.TabIndex = 4;
            this.lblA2Endwert.Text = "Endwert:";
            // 
            // txtA2Endwert
            // 
            this.txtA2Endwert.Location = new System.Drawing.Point(67, 71);
            this.txtA2Endwert.Name = "txtA2Endwert";
            this.txtA2Endwert.Size = new System.Drawing.Size(76, 20);
            this.txtA2Endwert.TabIndex = 5;
            // 
            // Aufgabe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtA2Endwert);
            this.Controls.Add(this.lblA2Endwert);
            this.Controls.Add(this.lblA2Startwert);
            this.Controls.Add(this.txtA2Startwert);
            this.Controls.Add(this.lbxA2Ausgabe);
            this.Controls.Add(this.btnA2Start);
            this.Name = "Aufgabe2";
            this.Text = "Aufgabe2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA2Start;
        private System.Windows.Forms.ListBox lbxA2Ausgabe;
        private System.Windows.Forms.TextBox txtA2Startwert;
        private System.Windows.Forms.Label lblA2Startwert;
        private System.Windows.Forms.Label lblA2Endwert;
        private System.Windows.Forms.TextBox txtA2Endwert;
    }
}