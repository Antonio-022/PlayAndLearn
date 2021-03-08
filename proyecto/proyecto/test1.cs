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
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pictureBox30.Visible = true;
            pictureBox35.Visible = true;
            IMGWELLCOME.Visible = true;
            tes.Text = "*WELCOME TO THE TEST*";
            clock.Visible = false;
        }

        private void test1_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer end = new SoundPlayer(@"C:\Windows\media\Windows Exclamation.wav");
            end.Play();
            pictureBox21.Visible = true;
                DialogResult resul = MessageBox.Show("are you sure to leave the test?", Text, MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    this.Close();
                }
                else pictureBox21.Visible = false;
            }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer4.Start();
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer5.Start();
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (panel0.Width == 286)
            {
                panel0.Width = 64;
                timer5.Stop();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel0.Width == 64)
            {
                panel0.Width = 286;
                timer4.Stop();
            }
        }
             private int Ndor()
        {
            int cambio = Convert.ToInt32(numerador.Text) + 1;
            numerador.Text = Convert.ToString(cambio);
            return (cambio);
        }
        private int[] ordenar(int[] ord)
        {
            for (int i = 1; i <= 10; i++)
            {
                switch (i)
                {
                    case 1:
                        r1.Text = Convert.ToString(ord[i]);
                        break;
                    case 2:
                        r2.Text = Convert.ToString(ord[i]);
                        break;
                    case 3:
                        r3.Text = Convert.ToString(ord[i]);
                        break;
                    case 4:
                        r4.Text = Convert.ToString(ord[i]);
                        break;
                    case 5:
                        r5.Text = Convert.ToString(ord[i]);
                        break;
                    case 6:
                        r6.Text = Convert.ToString(ord[i]);
                        break;
                    case 7:
                        r7.Text = Convert.ToString(ord[i]);
                        break;
                    case 8:
                        r8.Text = Convert.ToString(ord[i]);
                        break;
                    case 9:
                        r9.Text = Convert.ToString(ord[i]);
                        break;
                    case 10:
                        r10.Text = Convert.ToString(ord[i]);
                        break;
                }
            }
            return (ord);
        }
        private string CONTROL (string PRG)
        {
            switch (PRG)
            {
                case "1":
                    P1_OP1.Visible = false;
                    P1_OP2.Visible = false;
                    P1_OP3.Visible = false;
                    P1_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "2":
                    P2_OP1.Visible = false;
                    P2_OP4.Visible = false;
                    P2_OP3.Visible = false;
                    P2_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "3":
                    P3_OP3.Visible = false;
                    P3_OP4.Visible = false;
                    P3_OP2.Visible = false;
                    P3_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;

                    break;
                case "4":
                    P4_OP1.Visible = false;
                    P4_OP4.Visible = false;
                    P4_OP2.Visible = false;
                    P4_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "5":
                    P5_OP1.Visible = false;
                    P5_OP3.Visible = false;
                    P5_OP2.Visible = false;
                    P5_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "6":
                    P6_OP1.Visible = false;
                    P6_OP4.Visible = false;
                    P6_OP2.Visible = false;
                    P6_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "7":
                    P7_OP1.Visible = false;
                    P7_OP4.Visible = false;
                    P7_OP3.Visible = false;
                    P7_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "8":
                    P8_OP1.Visible = false;
                    P8_OP4.Visible = false;
                    P8_OP2.Visible = false;
                    P8_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "9":
                    P9_OP3.Visible = false;
                    P9_OP4.Visible = false;
                    P9_OP2.Visible = false;
                    P9_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "10":
                    P10_OP3.Visible = false;
                    P10_OP4.Visible = false;
                    P10_OP1.Visible = false;
                    P10_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "11":
                    P11_OP3.Visible = false;
                    P11_OP2.Visible = false;
                    P11_OP1.Visible = false;
                    P11_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "12":
                    P12_OP3.Visible = false;
                    P12_OP2.Visible = false;
                    P12_OP4.Visible = false;
                    P12_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "13":
                    P13_OP3.Visible = false;
                    P13_OP1.Visible = false;
                    P13_OP4.Visible = false;
                    P13_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "14":
                    P14_OP2.Visible = false;
                    P14_OP1.Visible = false;
                    P14_OP4.Visible = false;
                    P14_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "15":
                    P15_OP2.Visible = false;
                    P15_OP1.Visible = false;
                    P15_OP3.Visible = false;
                    P15_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;

                    break;
                case "16":
                    P16_OP2.Visible = false;
                    P16_OP4.Visible = false;
                    P16_OP3.Visible = false;
                    P16_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "17":
                    P17_OP1.Visible = false;
                    P17_OP4.Visible = false;
                    P17_OP3.Visible = false;
                    P17_VER.Visible = false;
                    BIEN.Visible = false;
                    MAL.Visible = false;
                    break;
                case "0":
                    break;
            }
            return (PRG);
        }
        private int[] numeros()
        {
            int[] v;
            int ns;
            v = new int[11];
            Random asar = new Random();
            for (int i = 1; i < 11; i++)
            {
                ns = asar.Next(1, 17);
                v[i] = ns;
                for (int j = 0; j < i; j++)
                {
                    if (v[j] == v[i])
                    {
                        i--;
                        break;
                    }
                }
            }
            ordenar(v);
            return (v);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            timer7.Start();
            button1.Visible = true;
            pictureBox35.Visible = false;
            pictureBox30.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;

            if (numerador.Text != "10")
            {
                CONTROL(CALL.Text);
                r1.Visible = false; r2.Visible = false; r3.Visible = false; r4.Visible = false; r5.Visible = false; r6.Visible = false; r7.Visible = false; r8.Visible = false; r9.Visible = false; r10.Visible = false;
                int sdi, prg = 0;
                numerador.Visible = true;
                sdi = Ndor();
                int sd = Convert.ToInt32(numerador.Text);
                if (sd <= 1)
                {
                    button2.Visible = false;
                    button2.Location = new Point(750, 664);
                    int[] vec = numeros();
                    button2.Text = "next";
                    IMGWELLCOME.Visible = false;
                    tes.Text = "*knowledge test*";
                    clock.Visible = true;
                    label1.Visible = true;
                    tes.Location = new Point(537, 193);
                }
                else button2.Visible = false;
                switch (sdi)
                {
                    case 1:
                        prg = Convert.ToInt32(r1.Text);
                        break;
                    case 2:
                        prg = Convert.ToInt32(r2.Text);
                        break;
                    case 3:
                        prg = Convert.ToInt32(r3.Text);
                        break;
                    case 4:
                        prg = Convert.ToInt32(r4.Text);
                        break;
                    case 5:
                        prg = Convert.ToInt32(r5.Text);
                        break;
                    case 6:
                        prg = Convert.ToInt32(r6.Text);
                        break;
                    case 7:
                        prg = Convert.ToInt32(r7.Text);
                        break;
                    case 8:
                        prg = Convert.ToInt32(r8.Text);
                        break;
                    case 9:
                        prg = Convert.ToInt32(r9.Text);
                        break;
                    case 10:
                        prg = Convert.ToInt32(r10.Text);
                        break;
                }
                switch (prg)
                {
                    case 1:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "I have not ______ for my uncle";
                        P1_VER.Text = "worked";
                        P1_OP1.Text = "everywhere";
                        P1_OP2.Text = "seasons";
                        P1_OP3.Text = "yesterday";
                        P1_OP1.Visible = true;
                        P1_OP2.Visible = true;
                        P1_OP3.Visible = true;
                        P1_VER.Visible = true;
                        CALL.Text = "1";
                        break;
                    case 2:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+"He has not finished _______ my book";
                        P2_VER.Text = "reading";
                        P2_OP1.Text = "false";
                        P2_OP4.Text = "forgiven";
                        P2_OP3.Text = "seen";
                        P2_OP1.Visible = true;
                        P2_OP4.Visible = true;
                        P2_OP3.Visible = true;
                        P2_VER.Visible = true;
                        CALL.Text = "2";
                        break;
                    case 3:
                        pregunta1.Text = "*Identify the Type of Sentence*"+ Environment.NewLine + "" + Environment.NewLine+ "They have not completed the project";
                        P3_VER.Text = "present perfect negative";
                        P3_OP2.Text = "regular verb";
                        P3_OP4.Text = "affirmative sentence";
                        P3_OP3.Text = "simple past";
                        P3_OP2.Visible = true;
                        P3_OP4.Visible = true;
                        P3_OP3.Visible = true;
                        P3_VER.Visible = true;
                        CALL.Text = "3";
                        break;
                    case 4:
                        pregunta1.Text = "*Identify the Type of Sentence*"+ Environment.NewLine + "" + Environment.NewLine+ "She didn't live in Japan last year";
                        P4_VER.Font = new Font("Monotype Corsiva", 14);
                        P4_VER.Text = "simple past negative";
                        P4_OP2.Text = "long adverb";
                        P4_OP4.Text = "adjetive";
                        P4_OP1.Text = "none";
                        P4_OP2.Visible = true;
                        P4_OP4.Visible = true;
                        P4_OP1.Visible = true;
                        P4_VER.Visible = true;
                        CALL.Text = "4";

                        break;
                    case 5:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "I ______ paint my house last weekend";
                        P5_VER.Text = "didn't";
                        P5_OP2.Text = "run";
                        P5_OP3.Text = "loved";
                        P5_OP1.Text = "kiss you";
                        P5_OP2.Visible = true;
                        P5_OP3.Visible = true;
                        P5_OP1.Visible = true;
                        P5_VER.Visible = true;
                        CALL.Text = "5";
                        break;
                    case 6:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "Did you work very hard ____ week?";
                        P6_VER.Text = "last";
                        P6_OP2.Text = "time";
                        P6_OP4.Text = "class";
                        P6_OP1.Text = "everthing";
                        P6_OP2.Visible = true;
                        P6_OP4.Visible = true;
                        P6_OP1.Visible = true;
                        P6_VER.Visible = true;
                        CALL.Text = "6";
                        break;
                    case 7:
                        pregunta1.Text = "*Identify the Type of Sentence*"+ Environment.NewLine + "" + Environment.NewLine+"Did they learn how to swim two years ago?";
                        P7_VER.Font = new Font("Monotype Corsiva", 14);
                        P7_VER.Text = "past simple interrogative";
                        P7_OP3.Text = "simple present";
                        P7_OP4.Text = "question";
                        P7_OP1.Text = "none";
                        P7_OP3.Visible = true;
                        P7_OP4.Visible = true;
                        P7_OP1.Visible = true;
                        P7_VER.Visible = true;
                        CALL.Text = "7";
                        break;
                    case 8:
                        pregunta1.Text = "*Identify the Type of Sentence*"+Environment.NewLine +""+Environment.NewLine+"She will not like to sit in the table";
                        P8_VER.Font = new Font("Monotype Corsiva",14);
                        P8_VER.Text = "simple future Negative";
                        P8_OP2.Text = "history";
                        P8_OP4.Text = "unlikely";
                        P8_OP1.Text = "perfection";
                        P8_OP2.Visible = true;
                        P8_OP4.Visible = true;
                        P8_OP1.Visible = true;
                        P8_VER.Visible = true;
                        CALL.Text = "8";
                        break;
                    case 9:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "You will not work very ____";
                        P9_VER.Text = "hard";
                        P9_OP2.Text = "tall";
                        P9_OP4.Text = "store";
                        P9_OP3.Text = "house";
                        P9_OP2.Visible = true;
                        P9_OP4.Visible = true;
                        P9_OP3.Visible = true;
                        P9_VER.Visible = true;
                        CALL.Text = "9";
                        break;
                    case 10:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "The store will not be ____ until seven o’clock";
                        P10_VER.Text = "open";
                        P10_OP1.Text = "time";
                        P10_OP4.Text = "school";
                        P10_OP3.Text = "people";
                        P10_OP1.Visible = true;
                        P10_OP4.Visible = true;
                        P10_OP3.Visible = true;
                        P10_VER.Visible = true;
                        CALL.Text = "10";
                        break;
                    case 11:
                        pregunta1.Text = "*Identify the Type of Sentence*"+ Environment.NewLine + "" + Environment.NewLine+ "Will we play in the park next week?";
                        P11_VER.Font = new Font("Monotype Corsiva", 14);
                        P11_VER.Text = "simple interrogative future";
                        P11_OP1.Text = "none";
                        P11_OP2.Text = "complex adjective";
                        P11_OP3.Text = "simple future";
                        P11_OP1.Visible = true;
                        P11_OP2.Visible = true;
                        P11_OP3.Visible = true;
                        P11_VER.Visible = true;
                        CALL.Text = "11";
                        break;
                    case 12:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "Will ____ play tennis next Sunday?";
                        P12_VER.Text = "they";
                        P12_OP4.Text = "sorry";
                        P12_OP2.Text = "tomorrow";
                        P12_OP3.Text = "mind";
                        P12_OP4.Visible = true;
                        P12_OP2.Visible = true;
                        P12_OP3.Visible = true;
                        P12_VER.Visible = true;
                        CALL.Text = "12";
                        break;
                    case 13:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "______ I speak several foreign languages";
                        P13_VER.Text = "will";
                        P13_OP4.Text = "wit";
                        P13_OP1.Text = "car";
                        P13_OP3.Text = "none";
                        P13_OP4.Visible = true;
                        P13_OP1.Visible = true;
                        P13_OP3.Visible = true;
                        P13_VER.Visible = true;
                        CALL.Text = "13";

                        break;
                    case 14:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+"We will ______ to school by bus";
                        P14_VER.Text = "go";
                        P14_OP4.Text = "table";
                        P14_OP1.Text = "flay";
                        P14_OP2.Text = "easy";
                        P14_OP4.Visible = true;
                        P14_OP1.Visible = true;
                        P14_OP2.Visible = true;
                        P14_VER.Visible = true;
                        CALL.Text = "14";
                        break;
                    case 15:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine + "" + Environment.NewLine+ "Have we ______ for more than two hours?";
                        P15_VER.Text = "talked";
                        P15_OP3.Text = "present perfect ";
                        P15_OP1.Text = "simple present ";
                        P15_OP2.Text = "example";
                        P15_OP3.Visible = true;
                        P15_OP1.Visible = true;
                        P15_OP2.Visible = true;
                        P15_VER.Visible = true;
                        CALL.Text = "15";
                        break;
                    case 16:
                        pregunta1.Text = "*Identify the Type of Sentence*"+ Environment.NewLine + "" + Environment.NewLine+ "Have you worked in that firm for many years?";
                        P16_VER.Font = new Font("Monotype Corsiva", 14);
                        P16_VER.Text = "present perfect interrogative";
                        P16_OP3.Text = "simple future";
                        P16_OP4.Text = "present compound";
                        P16_OP2.Text = "none";
                        P16_OP3.Visible = true;
                        P16_OP4.Visible = true;
                        P16_OP2.Visible = true;
                        P16_VER.Visible = true;
                        CALL.Text = "16";
                        break;
                    case 17:
                        pregunta1.Text = "*Complete the sentences with the correct answer*" + Environment.NewLine +""+Environment.NewLine+"Has he finish___ reading my book?";
                        P17_VER.Text = "'ed'";
                        P17_OP3.Text = "'it'";
                        P17_OP4.Text = "'list'";
                        P17_OP1.Text = "'ing'";
                        P17_OP3.Visible = true;
                        P17_OP4.Visible = true;
                        P17_OP1.Visible = true;
                        P17_VER.Visible = true;
                        CALL.Text = "17";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                CONTROL(CALL.Text);
                pregunta1.Location = new Point(528, 422);
                pregunta1.Visible = false;
                pregunta1.Text = "finish test";
                button2.Visible = false;
                back0.Enabled = false;
                back2.Visible = true;
                clock.Visible = false;
                label1.Visible = false;
            }  
            BIEN.Visible = false;
            MAL.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer end = new SoundPlayer(@"C:\Windows\media\Windows Exclamation.wav");
            end.Play();
            pictureBox21.Visible = true;
            DialogResult result1 = MessageBox.Show("are you sure to give up?",Text,MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else pictureBox21.Visible = false;
        }
        private void P1_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P1_VER.BackColor = Color.ForestGreen;
            P1_OP1.Enabled = false;
            P1_OP3.Enabled = false;
            P1_OP2.Enabled = false;
            P1_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P1_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P1_OP2.BackColor = Color.Red;
            P1_OP1.Enabled = false;
            P1_OP3.Enabled = false;
            P1_VER.Enabled = false;
            P1_OP2.Enabled = false;
            MAL.Visible = true;
        }
        private void P1_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P1_OP1.BackColor = Color.Red;
            P1_OP2.Enabled = false;
            P1_OP3.Enabled = false;
            P1_VER.Enabled = false;
            P1_OP1.Enabled = false;
            MAL.Visible = true;
        }
        private void P1_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P1_OP3.BackColor = Color.Red;
            P1_OP1.Enabled = false;
            P1_OP2.Enabled = false;
            P1_VER.Enabled = false;
            P1_OP3.Enabled = false;
            MAL.Visible = true;
        }
        private void P2_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P2_OP3.Enabled = false;
            P2_OP1.BackColor = Color.Red;
            P2_OP4.Enabled = false;
            P2_VER.Enabled = false;
            P2_OP1.Enabled = false;
            MAL.Visible = true;
        }
        private void P2_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P2_OP3.BackColor = Color.Red;
            P2_OP1.Enabled = false;
            P2_OP4.Enabled = false;
            P2_VER.Enabled = false;
            P2_OP3.Enabled = false;
            MAL.Visible = true;
        }
        private void P2_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P2_OP3.Enabled = false;
            P2_OP1.Enabled = false;
            P2_OP4.BackColor = Color.Red;
            P2_VER.Enabled = false;
            P2_OP4.Enabled = false;
            MAL.Visible = true;
        }
        private void P2_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P2_VER.BackColor = Color.ForestGreen;
            P2_OP1.Enabled = false;
            P2_OP3.Enabled = false;
            P2_OP4.Enabled = false;
            P2_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P3_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P3_VER.BackColor = Color.ForestGreen;
            P3_OP2.Enabled = false;
            P3_OP3.Enabled = false;
            P3_OP4.Enabled = false;
            P3_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P3_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P3_OP2.BackColor = Color.Red;
            P3_OP3.Enabled = false;
            P3_OP4.Enabled = false;
            P3_VER.Enabled = false;
            P3_OP2.Enabled = false;
            MAL.Visible = true;
        }
        private void P3_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P3_OP3.BackColor = Color.Red;
            P3_OP2.Enabled = false;
            P3_OP4.Enabled = false;
            P3_VER.Enabled = false;
            P3_OP3.Enabled = false;
            MAL.Visible = true;
        }
        private void P3_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P3_OP4.BackColor = Color.Red;
            P3_OP3.Enabled = false;
            P3_OP2.Enabled = false;
            P3_OP2.Enabled = false;
            P3_OP4.Enabled = false;
            MAL.Visible = true;
        }
        private void P4_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P4_VER.BackColor = Color.ForestGreen;
            P4_OP1.Enabled = false;
            P4_OP2.Enabled = false;
            P4_OP4.Enabled = false;
            P4_VER.Enabled = false;
            BIEN.Visible = true;

        }
        private void P4_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P4_OP1.BackColor = Color.Red;
            P4_OP1.Enabled = false;
            P4_OP4.Enabled = false;
            P4_OP2.Enabled = false;
            P4_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P4_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P4_OP2.BackColor = Color.Red;
            P4_OP4.Enabled = false;
            P4_OP1.Enabled = false;
            P4_OP2.Enabled = false;
            P4_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P4_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P4_OP4.BackColor = Color.Red;
            P4_OP1.Enabled = false;
            P4_OP2.Enabled = false;
            P4_VER.Enabled = false;
            P4_OP4.Enabled = false;
            MAL.Visible = true;
        }
        private void P5_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P5_OP1.BackColor = Color.Red;
            P5_OP1.Enabled = false;
            P5_OP2.Enabled = false;
            P5_OP3.Enabled = false;
            P5_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P5_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P5_OP2.BackColor = Color.Red;
            P5_OP1.Enabled = false;
            P5_OP2.Enabled = false;
            P5_OP3.Enabled = false;
            P5_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P5_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P5_OP3.BackColor = Color.Red;
            P5_OP1.Enabled = false;
            P5_OP2.Enabled = false;
            P5_OP3.Enabled = false;
            P5_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P5_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P5_VER.BackColor = Color.ForestGreen;
            P5_OP1.Enabled = false;
            P5_OP2.Enabled = false;
            P5_OP3.Enabled = false;
            P5_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P6_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P6_VER.BackColor = Color.ForestGreen;
            P6_OP1.Enabled = false;
            P6_OP2.Enabled = false;
            P6_OP4.Enabled = false;
            P6_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P6_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P6_OP1.BackColor = Color.Red;
            P6_OP1.Enabled = false;
            P6_OP2.Enabled = false;
            P6_OP4.Enabled = false;
            P6_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P6_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P6_OP2.BackColor = Color.Red;
            P6_OP1.Enabled = false;
            P6_OP2.Enabled = false;
            P6_OP4.Enabled = false;
            P6_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P6_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P6_OP4.BackColor = Color.Red;
            P6_OP1.Enabled = false;
            P6_OP2.Enabled = false;
            P6_OP4.Enabled = false;
            P6_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P7_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P7_VER.BackColor = Color.ForestGreen;
            P7_OP1.Enabled = false;
            P7_OP3.Enabled = false;
            P7_OP4.Enabled = false;
            P7_VER.Enabled = false;
            BIEN.Visible = true;
        }
        private void P7_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P7_OP1.BackColor = Color.Red;
            P7_OP1.Enabled = false;
            P7_OP3.Enabled = false;
            P7_OP4.Enabled = false;
            P7_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P7_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P7_OP3.BackColor = Color.Red;
            P7_OP3.Enabled = false;
            P7_OP1.Enabled = false;
            P7_OP4.Enabled = false;

            P7_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P7_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P7_OP4.Enabled = false;
            P7_OP4.BackColor = Color.Red;
            P7_OP1.Enabled = false;
            P7_OP3.Enabled = false;
            P7_VER.Enabled = false;

            P7_OP4.Enabled = false;
            MAL.Visible = true;
        }
        private void P8_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P8_VER.BackColor = Color.ForestGreen;
            P8_VER.Enabled = false;
            P8_OP1.Enabled = false;
            P8_OP2.Enabled = false;
            P8_OP4.Enabled = false;
            BIEN.Visible = true;
        }
        private void P8_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P8_OP4.BackColor = Color.Red;
            P8_OP4.Enabled = false;
            P8_OP1.Enabled = false;
            P8_OP2.Enabled = false;
            P8_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P8_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P8_OP2.BackColor = Color.Red;
            P8_OP2.Enabled = false;
            P8_OP1.Enabled = false;
            P8_OP4.Enabled = false;
            P8_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P8_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P8_OP1.BackColor = Color.Red;
            P8_OP1.Enabled = false;
            P8_OP2.Enabled = false;
            P8_OP4.Enabled = false;
            P8_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P9_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P9_VER.BackColor = Color.ForestGreen;
            P9_VER.Enabled = false;
            P9_OP3.Enabled = false;
            P9_OP2.Enabled = false;
            P9_OP4.Enabled = false;
            BIEN.Visible = true;
        }
        private void P9_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P9_OP2.BackColor = Color.Red;
            P9_OP2.Enabled = false;
            P9_OP3.Enabled = false;
            P9_OP4.Enabled = false;
            P9_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P9_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P9_OP3.BackColor = Color.Red;
            P9_OP3.Enabled = false;
            P9_OP2.Enabled = false;
            P9_OP4.Enabled = false;
            P9_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P9_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P9_OP4.BackColor = Color.Red;
            P9_OP4.Enabled = false;
            P9_OP3.Enabled = false;
            P9_OP2.Enabled = false;
            P9_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P10_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P10_VER.BackColor = Color.ForestGreen;
            P10_VER.Enabled = false;
            P10_OP3.Enabled = false;
            P10_OP1.Enabled = false;
            P10_OP4.Enabled = false;
            BIEN.Visible = true;
        }
        private void P10_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P10_OP1.BackColor = Color.Red;
            P10_OP1.Enabled = false;
            P10_OP3.Enabled = false;
            P10_OP4.Enabled = false;
            P10_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P10_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P10_OP3.BackColor = Color.Red;
            P10_OP3.Enabled = false;
            P10_OP1.Enabled = false;
            P10_OP4.Enabled = false;
            P10_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P10_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P10_OP4.BackColor = Color.Red;
            P10_OP4.Enabled = false;
            P10_OP3.Enabled = false;
            P10_OP1.Enabled = false;
            P10_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P11_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P11_VER.BackColor = Color.ForestGreen;
            P11_VER.Enabled = false;
            P11_OP3.Enabled = false;
            P11_OP1.Enabled = false;
            P11_OP2.Enabled = false;
            BIEN.Visible = true;
        }
        private void P11_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P11_OP1.BackColor = Color.Red;
            P11_OP1.Enabled = false;
            P11_OP3.Enabled = false;
            P11_OP2.Enabled = false;
            P11_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P11_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P11_OP2.BackColor = Color.Red;
            P11_OP3.Enabled = false;
            P11_OP1.Enabled = false;
            P11_OP2.Enabled = false;
            P11_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P11_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P11_OP3.BackColor = Color.Red;
            P11_OP3.Enabled = false;
            P11_OP1.Enabled = false;
            P11_OP2.Enabled = false;
            P11_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P12_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P12_VER.BackColor = Color.ForestGreen;
            P12_VER.Enabled = false;
            P12_OP3.Enabled = false;
            P12_OP4.Enabled = false;
            P12_OP2.Enabled = false;
            BIEN.Visible = true;
        }
        private void P12_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P12_OP2.BackColor = Color.Red;
            P12_OP2.Enabled = false;
            P12_OP3.Enabled = false;
            P12_OP4.Enabled = false;
            P12_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P12_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P12_OP3.BackColor = Color.Red;
            P12_OP3.Enabled = false;
            P12_OP4.Enabled = false;
            P12_OP2.Enabled = false;
            P12_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P12_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P12_OP4.BackColor = Color.Red;
            P12_OP4.Enabled = false;
            P12_OP3.Enabled = false;
            P12_OP2.Enabled = false;
            P12_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P13_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P13_VER.BackColor = Color.ForestGreen;
            P13_VER.Enabled = false;
            P13_OP3.Enabled = false;
            P13_OP4.Enabled = false;
            P13_OP1.Enabled = false;
            BIEN.Visible = true;
        }
        private void P13_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P13_OP1.BackColor = Color.Red;
            P13_OP1.Enabled = false;
            P13_OP3.Enabled = false;
            P13_OP4.Enabled = false;
            P13_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P13_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P13_OP3.BackColor = Color.Red;
            P13_OP3.Enabled = false;
            P13_OP4.Enabled = false;
            P13_OP1.Enabled = false;
            P13_VER.Enabled = false;
            MAL.Visible = true;
        }

        private void P13_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P13_OP4.BackColor = Color.Red;
            P13_OP4.Enabled = false;
            P13_OP3.Enabled = false;
            P13_OP1.Enabled = false;
            P13_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P14_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P14_VER.BackColor = Color.ForestGreen;
            P14_VER.Enabled = false;
            P14_OP2.Enabled = false;
            P14_OP4.Enabled = false;
            P14_OP1.Enabled = false;
            BIEN.Visible = true;
        }
        private void P14_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P14_OP1.BackColor = Color.Red;
            P14_OP1.Enabled = false;
            P14_OP2.Enabled = false;
            P14_OP4.Enabled = false;
            P14_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P14_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P14_OP2.BackColor = Color.Red;
            P14_OP2.Enabled = false;
            P14_OP4.Enabled = false;
            P14_OP1.Enabled = false;
            P14_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P14_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P14_OP4.BackColor = Color.Red;
            P14_OP4.Enabled = false;
            P14_OP2.Enabled = false;
            P14_OP1.Enabled = false;
            P14_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P15_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P15_VER.BackColor = Color.ForestGreen;
            P15_VER.Enabled = false;
            P15_OP2.Enabled = false;
            P15_OP3.Enabled = false;
            P15_OP1.Enabled = false;
            BIEN.Visible = true;
        }
        private void P15_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P15_OP1.BackColor = Color.Red;
            P15_OP1.Enabled = false;
            P15_OP3.Enabled = false;
            P15_OP2.Enabled = false;
            P15_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P15_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P15_OP2.BackColor = Color.Red;
            P15_OP2.Enabled = false;
            P15_OP3.Enabled = false;
            P15_OP1.Enabled = false;
            P15_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P15_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P15_OP3.BackColor = Color.Red;
            P15_OP3.Enabled = false;
            P15_OP2.Enabled = false;
            P15_OP1.Enabled = false;
            P15_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P16_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P16_VER.BackColor = Color.ForestGreen;
            P16_VER.Enabled = false;
            P16_OP2.Enabled = false;
            P16_OP3.Enabled = false;
            P16_OP4.Enabled = false;
            BIEN.Visible = true;
        }

        private void P16_OP2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P16_OP2.BackColor = Color.Red;
            P16_OP2.Enabled = false;
            P16_OP3.Enabled = false;
            P16_OP4.Enabled = false;
            P16_VER.Enabled = false;
            MAL.Visible = true;
        }

        private void P16_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P16_OP3.BackColor = Color.Red;
            P16_OP2.Enabled = false;
            P16_OP3.Enabled = false;
            P16_OP4.Enabled = false;
            P16_VER.Enabled = false;
            MAL.Visible = true;
        }

        private void P16_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P16_OP4.BackColor = Color.Red;
            P16_OP4.Enabled = false;
            P16_OP2.Enabled = false;
            P16_OP3.Enabled = false;
            P16_VER.Enabled = false;
            MAL.Visible = true;
        }

        private void P17_VER_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            NOTE.Text = Convert.ToString(Convert.ToInt32(NOTE.Text) + 10);
            CORRECT.Text = Convert.ToString(Convert.ToInt32(CORRECT.Text) + 1);
            P17_VER.BackColor = Color.ForestGreen;
            P17_VER.Enabled = false;
            P17_OP1.Enabled = false;
            P17_OP3.Enabled = false;
            P17_OP4.Enabled = false;
            BIEN.Visible = true;
        }
        private void P17_OP1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P17_OP1.BackColor = Color.Red;
            P17_OP1.Enabled = false;
            P17_OP3.Enabled = false;
            P17_OP4.Enabled = false;
            P17_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P17_OP3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P17_OP3.BackColor = Color.Red;
            P17_OP3.Enabled = false;
            P17_OP1.Enabled = false;
            P17_OP4.Enabled = false;
            P17_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void P17_OP4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            FAIL.Text = Convert.ToString(Convert.ToInt32(FAIL.Text) + 1);
            P17_OP4.BackColor = Color.Red;
            P17_OP4.Enabled = false;
            P17_OP1.Enabled = false;
            P17_OP3.Enabled = false;
            P17_VER.Enabled = false;
            MAL.Visible = true;
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(clock.Text);
            total = total + 1 ;
            clock.Text = total.ToString();
            int conta = Convert.ToInt32(CORRECT.Text);
            int conta2 = Convert.ToInt32(FAIL.Text);
            if (pregunta1.Text == "finish test")
            {
                numerador.Visible = false;
                pregunta1.Visible = false;
                stdistic.Text = "tu tiempo fue de :" + clock.Text + "s" + Environment.NewLine + "you note is: " + NOTE.Text + " points" + Environment.NewLine + "questions corrects : " + conta + Environment.NewLine + "questions incorrects : " + conta2;
                if (Convert.ToInt32(conta) >= 6)
                {

                    SoundPlayer flase = new SoundPlayer(@"C:\Windows\media\Tada.wav");
                    flase.Play();
                    label17.Text = "CONGRATULETIONS";
                    pictureBox37.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    CONGPIC.Visible = true;
                    CORRECT.Text = "0";
                }
                else
                {
                    SoundPlayer be = new SoundPlayer(@"C:\Windows\media\Windows Critical Stop.wav");
                    be.Play();
                    label17.Text = "SORRY RETRY NEW";
                    CONGPIC.Visible = false;
                    pictureBox39.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox37.Visible = false;
                    FAILPIC.Visible = true;
                    pictureBox2.Visible = false;
                    FAIL.Text = "0";
                }
                timer7.Stop();
                button1.Visible = false;
                NOTE.Text = "0";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            Form abaut = new about();
            abaut.ShowDialog();
        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IMGWELLCOME_Click(object sender, EventArgs e)
        {

        }
    }

}

