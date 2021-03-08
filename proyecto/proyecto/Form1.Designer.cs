namespace proyecto
{
    partial class logo1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logo1));
            this.start2 = new System.Windows.Forms.Button();
            this.close1 = new System.Windows.Forms.PictureBox();
            this.cerrar1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.close1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start2
            // 
            this.start2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start2.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start2.Image = ((System.Drawing.Image)(resources.GetObject("start2.Image")));
            this.start2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start2.Location = new System.Drawing.Point(594, 515);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(194, 76);
            this.start2.TabIndex = 0;
            this.start2.Text = "start class";
            this.start2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.start2.UseVisualStyleBackColor = true;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // close1
            // 
            this.close1.BackColor = System.Drawing.Color.Transparent;
            this.close1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close1.BackgroundImage")));
            this.close1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close1.Location = new System.Drawing.Point(5, 1);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(31, 26);
            this.close1.TabIndex = 6;
            this.close1.TabStop = false;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // cerrar1
            // 
            this.cerrar1.BackColor = System.Drawing.Color.Transparent;
            this.cerrar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar1.BackgroundImage")));
            this.cerrar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar1.Location = new System.Drawing.Point(56, 1);
            this.cerrar1.Name = "cerrar1";
            this.cerrar1.Size = new System.Drawing.Size(32, 26);
            this.cerrar1.TabIndex = 5;
            this.cerrar1.TabStop = false;
            this.cerrar1.Click += new System.EventHandler(this.cerrar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cerrar1);
            this.panel1.Controls.Add(this.close1);
            this.panel1.Location = new System.Drawing.Point(1275, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 30);
            this.panel1.TabIndex = 7;
            // 
            // logo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logo1";
            this.Text = "logo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.logo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.PictureBox close1;
        private System.Windows.Forms.PictureBox cerrar1;
        private System.Windows.Forms.Panel panel1;
    }
}

