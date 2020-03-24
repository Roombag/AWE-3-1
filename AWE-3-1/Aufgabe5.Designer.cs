namespace AWE_3_1
{
    partial class Aufgabe5
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
            this.lbxA5Ausgabe = new System.Windows.Forms.ListBox();
            this.lblA5Eingabe = new System.Windows.Forms.Label();
            this.txtA5Eingabe = new System.Windows.Forms.TextBox();
            this.btnA5Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxA5Ausgabe
            // 
            this.lbxA5Ausgabe.FormattingEnabled = true;
            this.lbxA5Ausgabe.Location = new System.Drawing.Point(14, 80);
            this.lbxA5Ausgabe.Name = "lbxA5Ausgabe";
            this.lbxA5Ausgabe.Size = new System.Drawing.Size(146, 186);
            this.lbxA5Ausgabe.TabIndex = 7;
            // 
            // lblA5Eingabe
            // 
            this.lblA5Eingabe.AutoSize = true;
            this.lblA5Eingabe.Location = new System.Drawing.Point(11, 38);
            this.lblA5Eingabe.Name = "lblA5Eingabe";
            this.lblA5Eingabe.Size = new System.Drawing.Size(49, 13);
            this.lblA5Eingabe.TabIndex = 6;
            this.lblA5Eingabe.Text = "Eingabe:";
            // 
            // txtA5Eingabe
            // 
            this.txtA5Eingabe.Location = new System.Drawing.Point(14, 54);
            this.txtA5Eingabe.Name = "txtA5Eingabe";
            this.txtA5Eingabe.Size = new System.Drawing.Size(146, 20);
            this.txtA5Eingabe.TabIndex = 5;
            // 
            // btnA5Start
            // 
            this.btnA5Start.Location = new System.Drawing.Point(12, 12);
            this.btnA5Start.Name = "btnA5Start";
            this.btnA5Start.Size = new System.Drawing.Size(75, 23);
            this.btnA5Start.TabIndex = 4;
            this.btnA5Start.Text = "Start";
            this.btnA5Start.UseVisualStyleBackColor = true;
            // 
            // Aufgabe5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxA5Ausgabe);
            this.Controls.Add(this.lblA5Eingabe);
            this.Controls.Add(this.txtA5Eingabe);
            this.Controls.Add(this.btnA5Start);
            this.Name = "Aufgabe5";
            this.Text = "Aufgabe5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxA5Ausgabe;
        private System.Windows.Forms.Label lblA5Eingabe;
        private System.Windows.Forms.TextBox txtA5Eingabe;
        private System.Windows.Forms.Button btnA5Start;
    }
}