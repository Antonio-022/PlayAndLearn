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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button112_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label189_Click(object sender, EventArgs e)
        {
            
        }

        private void about_Load(object sender, EventArgs e)
        {
            label189.Text = "" + Environment.NewLine + "test by:\t Ivar Tapecua" + Environment.NewLine +"information by:\t Gerson Vega";
            Location = new Point(420, 240);
        }
    }
}
