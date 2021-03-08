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
    public partial class version : Form
    {
        public version()
        {
            InitializeComponent();
        }
        private void version_Load(object sender, EventArgs e)
        {
            Location = new Point(420, 240);
            label18.Text = "version: 0.2beta" + Environment.NewLine + "by program x" + Environment.NewLine + "upds- ingenieria de sistemas";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
