namespace AWE_3_1
{
    partial class Aufgabe7
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
            this.lblA7Anzahl = new System.Windows.Forms.Label();
            this.txtA7Eingabe = new System.Windows.Forms.TextBox();
            this.lbxA7Ausgabe = new System.Windows.Forms.ListBox();
            this.btnA7Zuruecksetzen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA7Anzahl
            // 
            this.lblA7Anzahl.AutoSize = true;
            this.lblA7Anzahl.Location = new System.Drawing.Point(13, 13);
            this.lblA7Anzahl.Name = "lblA7Anzahl";
            this.lblA7Anzahl.Size = new System.Drawing.Size(122, 13);
            this.lblA7Anzahl.TabIndex = 0;
            this.lblA7Anzahl.Text = "Anzahl Fibonaccizahlen:";
            this.lblA7Anzahl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtA7Eingabe
            // 
            this.txtA7Eingabe.Location = new System.Drawing.Point(16, 30);
            this.txtA7Eingabe.Name = "txtA7Eingabe";
            this.txtA7Eingabe.Size = new System.Drawing.Size(100, 20);
            this.txtA7Eingabe.TabIndex = 1;
            // 
            // lbxA7Ausgabe
            // 
            this.lbxA7Ausgabe.FormattingEnabled = true;
            this.lbxA7Ausgabe.Location = new System.Drawing.Point(16, 57);
            this.lbxA7Ausgabe.Name = "lbxA7Ausgabe";
            this.lbxA7Ausgabe.Size = new System.Drawing.Size(336, 277);
            this.lbxA7Ausgabe.TabIndex = 2;
            // 
            // btnA7Zuruecksetzen
            // 
            this.btnA7Zuruecksetzen.Location = new System.Drawing.Point(16, 341);
            this.btnA7Zuruecksetzen.Name = "btnA7Zuruecksetzen";
            this.btnA7Zuruecksetzen.Size = new System.Drawing.Size(100, 23);
            this.btnA7Zuruecksetzen.TabIndex = 3;
            this.btnA7Zuruecksetzen.Text = "Zurücksetzen";
            this.btnA7Zuruecksetzen.UseVisualStyleBackColor = true;
            // 
            // Aufgabe7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 378);
            this.Controls.Add(this.btnA7Zuruecksetzen);
            this.Controls.Add(this.lbxA7Ausgabe);
            this.Controls.Add(this.txtA7Eingabe);
            this.Controls.Add(this.lblA7Anzahl);
            this.Name = "Aufgabe7";
            this.Text = "Aufgabe7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA7Anzahl;
        private System.Windows.Forms.TextBox txtA7Eingabe;
        private System.Windows.Forms.ListBox lbxA7Ausgabe;
        private System.Windows.Forms.Button btnA7Zuruecksetzen;
    }
}