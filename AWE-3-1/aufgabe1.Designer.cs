namespace AWE_3_1
{
    partial class Aufgabe1
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
            this.btnA1aStart = new System.Windows.Forms.Button();
            this.btnA1bStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA1aStart
            // 
            this.btnA1aStart.Location = new System.Drawing.Point(12, 12);
            this.btnA1aStart.Name = "btnA1aStart";
            this.btnA1aStart.Size = new System.Drawing.Size(75, 23);
            this.btnA1aStart.TabIndex = 0;
            this.btnA1aStart.Text = "Start a)";
            this.btnA1aStart.UseVisualStyleBackColor = true;
            // 
            // btnA1bStart
            // 
            this.btnA1bStart.Location = new System.Drawing.Point(372, 12);
            this.btnA1bStart.Name = "btnA1bStart";
            this.btnA1bStart.Size = new System.Drawing.Size(75, 23);
            this.btnA1bStart.TabIndex = 1;
            this.btnA1bStart.Text = "Start b)";
            this.btnA1bStart.UseVisualStyleBackColor = true;
            // 
            // Aufgabe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnA1bStart);
            this.Controls.Add(this.btnA1aStart);
            this.Name = "Aufgabe1";
            this.Text = "Aufgabe1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA1aStart;
        private System.Windows.Forms.Button btnA1bStart;
    }
}