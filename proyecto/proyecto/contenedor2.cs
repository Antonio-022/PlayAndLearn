using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyecto
{
    public partial class contenedor2 : Form
    {
        public contenedor2()
        {
            InitializeComponent();
            timer1.Start();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            button4.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
                timer3.Start();
          
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (panel1.Width == 286)
            {
                panel1.Width = 64;
                timer2.Stop();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
           if (panel1.Width == 64)
            {
                panel1.Width = 286;
            }
                timer3.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form version_0 = new version();
            version_0.ShowDialog();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            Form start_2 = new class_0();
            start_2.Show();
        }

        private void button_2_Click_1(object sender, EventArgs e)
        {
            Form start1 = new test1();
            start1.Show();
        }

        private void button_1_Click_1(object sender, EventArgs e)
        {
            lcuadro.Text = Environment.NewLine + "By Program x" + Environment.NewLine + "" + Environment.NewLine + "Programers : \t Antonio Arauz" + Environment.NewLine + "\t                 Gerson Vega" + Environment.NewLine + "\t                  Ivar Tapecua" + Environment.NewLine + "Information By : \t Lider Moreno";
        }

        private void contenedor2_Load(object sender, EventArgs e)
        {

        }

        private void label1hora_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
