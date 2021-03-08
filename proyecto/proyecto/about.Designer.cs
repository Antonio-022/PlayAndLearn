namespace proyecto
{
    partial class about
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
            this.button112 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button112
            // 
            this.button112.BackColor = System.Drawing.SystemColors.Menu;
            this.button112.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button112.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button112.Location = new System.Drawing.Point(374, 178);
            this.button112.Name = "button112";
            this.button112.Size = new System.Drawing.Size(75, 30);
            this.button112.TabIndex = 7;
            this.button112.Text = "ok";
            this.button112.UseVisualStyleBackColor = false;
            this.button112.Click += new System.EventHandler(this.button112_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "About...";
            // 
            // label189
            // 
            this.label189.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label189.ForeColor = System.Drawing.Color.White;
            this.label189.Location = new System.Drawing.Point(-4, 32);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(468, 157);
            this.label189.TabIndex = 9;
            this.label189.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label189.Click += new System.EventHandler(this.label189_Click);
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(461, 220);
            this.Controls.Add(this.label189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button112);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "about";
            this.Text = "about";
            this.Load += new System.EventHandler(this.about_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button112;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label189;
    }
}