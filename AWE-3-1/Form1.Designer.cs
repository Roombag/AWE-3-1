namespace AWE_3_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAufg1 = new System.Windows.Forms.Button();
            this.btnAufg2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAufg1
            // 
            this.btnAufg1.Location = new System.Drawing.Point(12, 12);
            this.btnAufg1.Name = "btnAufg1";
            this.btnAufg1.Size = new System.Drawing.Size(96, 23);
            this.btnAufg1.TabIndex = 0;
            this.btnAufg1.Text = "Aufgabe 1";
            this.btnAufg1.UseVisualStyleBackColor = true;
            // 
            // btnAufg2
            // 
            this.btnAufg2.Location = new System.Drawing.Point(12, 41);
            this.btnAufg2.Name = "btnAufg2";
            this.btnAufg2.Size = new System.Drawing.Size(96, 23);
            this.btnAufg2.TabIndex = 1;
            this.btnAufg2.Text = "Aufgabe 2";
            this.btnAufg2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 450);
            this.Controls.Add(this.btnAufg2);
            this.Controls.Add(this.btnAufg1);
            this.Name = "Form1";
            this.Text = "3-1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAufg1;
        private System.Windows.Forms.Button btnAufg2;
    }
}

