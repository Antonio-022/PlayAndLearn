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
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
            
        }

        private void message_Load(object sender, EventArgs e)
        {
            label12.Text = "are you sure end the program?";
            Location = new Point(420, 240);
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            {
                this.Close();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }
