namespace proyecto
{
    partial class message
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
            this.button23 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button23.Location = new System.Drawing.Point(270, 162);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(160, 61);
            this.button23.TabIndex = 2;
            this.button23.Text = "not";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(43, 162);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(160, 61);
            this.button15.TabIndex = 3;
            this.button15.Text = "yes";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 95);
            this.label12.TabIndex = 4;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(477, 259);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button15);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "message";
            this.Load += new System.EventHandler(this.message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label12;
       /* private System.Windows.Forms.Panel panel1;/*/
    }
}