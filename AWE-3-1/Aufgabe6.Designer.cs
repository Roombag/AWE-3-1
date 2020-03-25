namespace AWE_3_1
{
    partial class Aufgabe6
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
            this.btnA6Naechste = new System.Windows.Forms.Button();
            this.txtA6Eingabe = new System.Windows.Forms.TextBox();
            this.lbxA6Ausgabe = new System.Windows.Forms.ListBox();
            this.txtA6Durchschnitt = new System.Windows.Forms.TextBox();
            this.lblA6Durchschnitt = new System.Windows.Forms.Label();
            this.btnA6Zurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA6Naechste
            // 
            this.btnA6Naechste.Location = new System.Drawing.Point(13, 39);
            this.btnA6Naechste.Name = "btnA6Naechste";
            this.btnA6Naechste.Size = new System.Drawing.Size(114, 23);
            this.btnA6Naechste.TabIndex = 0;
            this.btnA6Naechste.Text = "nächste Zahl/Start";
            this.btnA6Naechste.UseVisualStyleBackColor = true;
            this.btnA6Naechste.Click += new System.EventHandler(this.btnA6Naechste_Click);
            // 
            // txtA6Eingabe
            // 
            this.txtA6Eingabe.Location = new System.Drawing.Point(13, 13);
            this.txtA6Eingabe.Name = "txtA6Eingabe";
            this.txtA6Eingabe.Size = new System.Drawing.Size(114, 20);
            this.txtA6Eingabe.TabIndex = 1;
            // 
            // lbxA6Ausgabe
            // 
            this.lbxA6Ausgabe.FormattingEnabled = true;
            this.lbxA6Ausgabe.Location = new System.Drawing.Point(13, 69);
            this.lbxA6Ausgabe.Name = "lbxA6Ausgabe";
            this.lbxA6Ausgabe.Size = new System.Drawing.Size(114, 134);
            this.lbxA6Ausgabe.TabIndex = 2;
            // 
            // txtA6Durchschnitt
            // 
            this.txtA6Durchschnitt.Location = new System.Drawing.Point(12, 226);
            this.txtA6Durchschnitt.Name = "txtA6Durchschnitt";
            this.txtA6Durchschnitt.Size = new System.Drawing.Size(115, 20);
            this.txtA6Durchschnitt.TabIndex = 3;
            // 
            // lblA6Durchschnitt
            // 
            this.lblA6Durchschnitt.AutoSize = true;
            this.lblA6Durchschnitt.Location = new System.Drawing.Point(13, 210);
            this.lblA6Durchschnitt.Name = "lblA6Durchschnitt";
            this.lblA6Durchschnitt.Size = new System.Drawing.Size(70, 13);
            this.lblA6Durchschnitt.TabIndex = 4;
            this.lblA6Durchschnitt.Text = "Durchschnitt:";
            // 
            // btnA6Zurueck
            // 
            this.btnA6Zurueck.Location = new System.Drawing.Point(12, 253);
            this.btnA6Zurueck.Name = "btnA6Zurueck";
            this.btnA6Zurueck.Size = new System.Drawing.Size(115, 23);
            this.btnA6Zurueck.TabIndex = 5;
            this.btnA6Zurueck.Text = "Zurücksetzen";
            this.btnA6Zurueck.UseVisualStyleBackColor = true;
            this.btnA6Zurueck.Click += new System.EventHandler(this.btnA6Zurueck_Click);
            // 
            // Aufgabe6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 293);
            this.Controls.Add(this.btnA6Zurueck);
            this.Controls.Add(this.lblA6Durchschnitt);
            this.Controls.Add(this.txtA6Durchschnitt);
            this.Controls.Add(this.lbxA6Ausgabe);
            this.Controls.Add(this.txtA6Eingabe);
            this.Controls.Add(this.btnA6Naechste);
            this.Name = "Aufgabe6";
            this.Text = "Aufgabe6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA6Naechste;
        private System.Windows.Forms.TextBox txtA6Eingabe;
        private System.Windows.Forms.ListBox lbxA6Ausgabe;
        private System.Windows.Forms.TextBox txtA6Durchschnitt;
        private System.Windows.Forms.Label lblA6Durchschnitt;
        private System.Windows.Forms.Button btnA6Zurueck;
    }
}