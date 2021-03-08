using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proyecto
{
    public partial class logo1 : Form
    {
        public logo1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }


        private void close1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar1_Click(object sender, EventArgs e)
        {
            SoundPlayer end = new SoundPlayer(@"C:\Windows\media\Windows Exclamation.wav");
            end.Play();
            Form show_e = new message();
            show_e.ShowDialog();
        }

        private void start2_Click(object sender, EventArgs e)
        {
            Form iniciar = new contenedor2();
            iniciar.Show();
            SoundPlayer end = new SoundPlayer(@"C:\Windows\media\Windows unlock.wav");
            end.Play();

        }

        private void logo1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
