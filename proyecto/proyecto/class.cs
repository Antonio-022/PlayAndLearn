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
    public partial class class_0 : Form
    {
        public class_0()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pictureBoX25.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            if (panel10.Width == 286)
            {
                panel10.Width = 64;
;
            }

            pictureBox13.Visible = true;
            pictureBox12.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            if (panel10.Width == 64)
            {
                panel10.Width = 286;

            }

            pictureBox13.Visible = false;
            pictureBox12.Visible = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer full= new SoundPlayer(@"C:\Windows\media\Windows Exclamation.wav");
            full.Play();
            pictureBox70.Visible = true;
            DialogResult ling = MessageBox.Show("are you sure to leave the class?", Text, MessageBoxButtons.YesNo);
                if(ling == DialogResult.Yes)
            {
                this.Close();
            }
            pictureBox70.Visible = false;

        }

        private void theme_one_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Simple Past" + Environment.NewLine + "examples.-" + Environment.NewLine + "Affirmative Sentence.-   She lived in Japan last year." +
                Environment.NewLine + "                           (Ella vivió en Japón el año pasado)" +
                Environment.NewLine + "Negative Prayer Auxiliary DID NOT = DIDN'T" +
                Environment.NewLine + "He didn't walk to school.(Él no caminó para ir a la escuela)" +
                Environment.NewLine + "Negative Prayer.-   Did you work very hard last week?" +
                Environment.NewLine + "                (¿Tú trabajaste muy duro la semana pasada?)";
        }

        private void theme_two_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "short comparative adjective" + Environment.NewLine + "in the short comparative adjectives 'ER' is added at the end of the adjective" +
                Environment.NewLine + "examples.-" +
                Environment.NewLine + "long --------> longer" +
                Environment.NewLine + "old --------> older" +
                Environment.NewLine + "exception: adjectives that end in a consonant is added 'THAN'         after  the adjective" +
                Environment.NewLine + "Mary is shorter than Lucy";
        }

        private void theme_tree_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Superlative Form" + Environment.NewLine + "the superlative form of short adjectives is formed by adding EST to the adjective" +
                Environment.NewLine + "examples.-" +
                Environment.NewLine + "young ----------> youngest" +
                Environment.NewLine + "rich ----------> richest" +
                Environment.NewLine + "Note: you must place 'THE' in front of the adjective" +
                Environment.NewLine + "The richest man in the world";
        }

        private void theme_four_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Long Adjectives" + Environment.NewLine + "long adjectives from two or more syllables are compared " +
                Environment.NewLine + "with MORE+ AD+THAN and the superlative form is formed with THE MOST+AD" +
                Environment.NewLine + "Adjective       Comparative       Superlative" +
                Environment.NewLine + "     Famous -----> more famous -----> the most famous";
        }

        private void theme_five_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Adverbs Ending in 'and'" + Environment.NewLine + "the adverbs that end LY are compared to MORE THAN " +
                Environment.NewLine + "and their superlative form is THE MOST" +
                Environment.NewLine + "examples.-" +
                Environment.NewLine + "Adverb       Comparative       Superlative" +
                Environment.NewLine + "Slowly -------> more slowly -------> the most slowly";
        }

        private void theme_six_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Perfect Present" + Environment.NewLine + "examples.-" +
                Environment.NewLine + "present perfect affirmative" +
                Environment.NewLine + "I have worked for my uncle. (Yo he trabajado para mi tío)" +
                Environment.NewLine + "present perfect negative" +
                Environment.NewLine + "She has not finished her homework. (Ella no ha terminado su tarea)" +
                Environment.NewLine + "present perfect interrogative" +
                Environment.NewLine + "Has it rained in the last month? (¿Ha llovido en el último mes?)";
        }

        private void theme_seven_Click(object sender, EventArgs e)
        {
            pictureBoX25.Visible = false;
            pictureBox26.Visible = true;
            label1.Text = "Simple future" + Environment.NewLine + "examples.-" +
                 Environment.NewLine + "simple future affirmative" +
                Environment.NewLine + "She will like to sit  in the sun. (A ella le gustará sentarse en el sol)" +
                Environment.NewLine + "simple future negative" +
                Environment.NewLine + "Will she kiss me every morning? (¿Ella me besará cada mañana?)" +
                Environment.NewLine + "simple future interrogative" +
                Environment.NewLine + "Will he walk to school? (¿Él caminará para ir a la escuela?)";
        }


        private void class_0_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
