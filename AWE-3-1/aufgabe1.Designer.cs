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
            this.lstShow = new System.Windows.Forms.ListBox();
            this.lstA1Index = new System.Windows.Forms.ListBox();
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
            this.btnA1aStart.Click += new System.EventHandler(this.btnA1aStart_Click);
            // 
            // btnA1bStart
            // 
            this.btnA1bStart.Location = new System.Drawing.Point(93, 12);
            this.btnA1bStart.Name = "btnA1bStart";
            this.btnA1bStart.Size = new System.Drawing.Size(75, 23);
            this.btnA1bStart.TabIndex = 1;
            this.btnA1bStart.Text = "Start b)";
            this.btnA1bStart.UseVisualStyleBackColor = true;
            this.btnA1bStart.Click += new System.EventHandler(this.btnA1bStart_Click);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(12, 41);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(156, 160);
            this.lstShow.TabIndex = 2;
            // 
            // lstA1Index
            // 
            this.lstA1Index.FormattingEnabled = true;
            this.lstA1Index.Location = new System.Drawing.Point(175, 41);
            this.lstA1Index.Name = "lstA1Index";
            this.lstA1Index.Size = new System.Drawing.Size(149, 160);
            this.lstA1Index.TabIndex = 3;
            // 
            // Aufgabe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 213);
            this.Controls.Add(this.lstA1Index);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.btnA1bStart);
            this.Controls.Add(this.btnA1aStart);
            this.Name = "Aufgabe1";
            this.Text = "Aufgabe1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA1aStart;
        private System.Windows.Forms.Button btnA1bStart;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.ListBox lstA1Index;
    }
}