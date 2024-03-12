using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telephone
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[5, 3];
        int t = 0,call=0,dpress=0;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].SetBounds(100 + 40 * j, 100 + 40 * i, 40, 40);
                    b[i, j].Visible = true;
                    if (i <= 2)
                    {
                        b[i, j].Text = ((j + 1) + 3 * i).ToString();
                    }
                    else if (i == 3 && j == 0) b[i, j].Text = "*";
                    else if (i == 3 && j == 1) b[i, j].Text = "0";
                    else if (i == 3 && j == 2) b[i, j].Text = "#";
                    else if (i == 3 && j == 3) b[i, j].Text = "#";
                    else if (i == 4 && j == 0) b[i, j].Text = "X";
                    else if (i == 4 && j == 1) b[i, j].Image = imageList1.Images[0];
                    else if (i == 4 && j == 2) b[i, j].Text = "<-";
                    tabPage1.Controls.Add(b[i, j]);
                }
            }
            b[0, 0].MouseDown += button0_click;
            b[0, 0].MouseUp += button0_up;
            b[0, 1].MouseDown += button1_click;
            b[0, 1].MouseUp += button1_up;
            b[0, 2].MouseDown += button2_click;
            b[0, 2].MouseUp += button2_up;
            b[1, 0].MouseDown += button3_click;
            b[1, 0].MouseUp += button3_up;
            b[1, 1].MouseDown += button4_click;
            b[1, 1].MouseUp += button4_up;
            b[1, 2].MouseDown += button5_click;
            b[1, 2].MouseUp += button5_up;
            b[2, 0].MouseDown += button6_click;
            b[2, 0].MouseUp += button6_up;
            b[2, 1].MouseDown += button7_click;
            b[2, 1].MouseUp += button7_up;
            b[2, 2].MouseDown += button8_click;
            b[2, 2].MouseUp += button8_up;
            b[3, 0].MouseDown += button9_click;
            b[3, 0].MouseUp += button9_up;
            b[3, 1].MouseDown += button10_click;
            b[3, 1].MouseUp += button10_up;
            b[3, 2].MouseDown += button11_click;
            b[3, 2].MouseUp += button11_up;
            b[4, 0].MouseClick += button12_click;
            b[4, 1].MouseClick += button13_click;
            b[4, 2].MouseClick += button14_click;
            axWindowsMediaPlayer1.URL = @"697.wav";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
           // axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("C:/Users/tim/Downloads/assets/assets/6-2/audio");
            axWindowsMediaPlayer2.URL = @"770.wav";
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer3.URL = @"852.wav";
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            axWindowsMediaPlayer4.URL = @"941.wav";
            axWindowsMediaPlayer4.Ctlcontrols.stop();
            axWindowsMediaPlayer5.URL = @"1209.wav";
            axWindowsMediaPlayer5.Ctlcontrols.stop();
            axWindowsMediaPlayer6.URL = @"1336.wav";
            axWindowsMediaPlayer6.Ctlcontrols.stop();
            axWindowsMediaPlayer7.URL = @"1477.wav";
            axWindowsMediaPlayer7.Ctlcontrols.stop();
            




        }

   
        private void allstop()
        {
            tabPage1.Focus();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            axWindowsMediaPlayer4.Ctlcontrols.stop();
            axWindowsMediaPlayer5.Ctlcontrols.stop();
            axWindowsMediaPlayer6.Ctlcontrols.stop();
            axWindowsMediaPlayer7.Ctlcontrols.stop();
           
        }
        private void backspace()
        {
            if (number.Text.Equals("Telephone")) return;
            char[] num;
            num = number.Text.ToCharArray();
            number.Text = "";
            int i;
            for (i = 0; i < num.Length - 1; i++)
            {
                number.Text += num[i].ToString();
            }
        }
        private void button14_click(object sender, MouseEventArgs e)
        {

            backspace();
        }
        private void enter()

        {
            if (call == 0)
            {
                if (number.Text.Equals("Telephone")) return;
                else if (number.Text.Equals("")) return;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        b[i, j].Enabled = false;
                    }
                }
                b[4, 1].Enabled = true;
                b[4, 1].Image = imageList1.Images[1];
                // phonelabel.Text += number.Text;
                call=1;
            }
            else if (call != 0)
            {

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        b[i, j].Enabled = true;
                    }
                }
                b[4, 1].Image = imageList1.Images[0];
                phonelabel.Text += number.Text+"\n";
                number.Text = "Telephone";
                t = 0;
                call = 0;
            }
        }
        private void button13_click(object sender, MouseEventArgs e)
        {
            enter();
        }
        private void button12_click(object sender, MouseEventArgs e)
        {
            number.Text = "";
        }

        private void b11down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer7.Ctlcontrols.play();
            number.Text += "#";
        }
        private void button11_click(object sender, EventArgs e)
        {
            b11down();
        }
        private void button11_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void b10down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer6.Ctlcontrols.play();
            number.Text += "0";
        }
        private void button10_click(object sender, EventArgs e)
        {
            b10down();
        }
        private void button10_up(object sender, EventArgs e)
        {
            allstop();
        }
        public void b9down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer5.Ctlcontrols.play();
            number.Text += "*";
        }
        private void button9_click(object sender, EventArgs e)
        {
            b9down();
        }
        private void button9_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void b8down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer7.Ctlcontrols.play();
            number.Text += "9";
        }
        private void button8_click(object sender, EventArgs e)
        {
            b8down();
        }
        private void button8_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void b7down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer6.Ctlcontrols.play();
            number.Text += "8";
        }
        private void button7_click(object sender, EventArgs e)
        {
            b7down();
        }
        private void button7_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void b6down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer5.Ctlcontrols.play();
            number.Text += "7";
        }
        private void button6_click(object sender, EventArgs e)
        {
            b6down();
        }
        private void button6_up(object sender, EventArgs e)
        {
            allstop();
        }

        private void b5down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer7.Ctlcontrols.play();
            number.Text += "6";
        }
        private void button5_click(object sender, EventArgs e)
        {
            b5down();

        }
        private void button5_up(object sender, EventArgs e)
        {
            allstop();

        }
        private void b4down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer6.Ctlcontrols.play();
            number.Text += "5";
        }
        private void button4_click(object sender, EventArgs e)
        {
            b4down();
        }
        private void button4_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void b3down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer5.Ctlcontrols.play();
            number.Text += "4";
        }
        private void button3_click(object sender, EventArgs e)
        {
            b3down();
        }

        private void button3_up(object sender, EventArgs e)
        {
            allstop();
        }

        private void b2down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer7.Ctlcontrols.play();
            number.Text += "3";
        }
        private void button2_click(object sender, EventArgs e)
        {
            b2down();
        }
        private void button2_up(object sender, EventArgs e)
        {
            allstop();
        }
       private void b1down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer6.Ctlcontrols.play();
            number.Text += "2";
        }
        private void button1_click(object sender, EventArgs e)
        {
            b1down();
        }
        private void button1_up(object sender, EventArgs e)
        {
            allstop();
        }
        private void button0_up(object sender,EventArgs e)
        {
            allstop();
        }
        private void b0down()
        {
            if (t == 0)
            {
                number.Text = "";
            }
            t++;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer5.Ctlcontrols.play();
            number.Text += "1";
        }
        private void button0_click(object sender, EventArgs e)
        {
            b0down();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            char[] path;
            int lashnum = 0;
            path = textsave.Text.ToCharArray();
            string dir="";
            for(int i = 0; i<path.Length; i++)
            {
                if (path[i] == '\\') lashnum++;
            }
            for(int i = 0,c=0; i<path.Length ; i++)
            {   if(path[i]=='\\')
                {
                    c++;
                }
                dir+=path[i].ToString();
                if (c >= lashnum) break;
            }


            if (textsave.Text.Length == 0)
            {
                MessageBox.Show("Empty String");
            }
            else if (Directory.Exists(dir) == false)
            {
                MessageBox.Show("Directory Not Found");
            }
            else
            {
                if (File.Exists(textsave.Text) == false)
                {
                    var myfile=File.CreateText(textsave.Text);
                    myfile.Close();
                }
                FileInfo fl = new FileInfo(@textsave.Text);
              
                StreamWriter sw = fl.CreateText();
                sw.Write(phonelabel.Text);
                sw.Flush();
                sw.Close();
               MessageBox.Show("Done\n" + fl.FullName);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 0)
            {
                allstop();
                dpress = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dpress == 1) return;
            if (call == 1&&e.KeyCode!=Keys.Enter) return;
            if (tabcontrol1.SelectedIndex == 0)
            {
                if (ModifierKeys == Keys.Shift && e.KeyCode == Keys.D8)
                {
                    b9down();
                   
                }
                else if (ModifierKeys == Keys.Shift && e.KeyCode == Keys.D3)
                {
                    b11down();
                }
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            b0down();
                            break;
                        case Keys.D2:
                            b1down();
                            break;
                        case Keys.D3:
                            b2down();
                            break;
                        case Keys.D4:
                            b3down();
                            break;
                        case Keys.D5:
                            b4down();
                            break;
                        case Keys.D6:
                            b5down();
                            break;
                        case Keys.D7:
                            b6down();
                            break;
                        case Keys.D8:
                            b7down();
                            break;
                        case Keys.D9:
                            b8down();
                            break;
                        case Keys.D0:
                            b10down();
                            break;
                        case Keys.Enter:
                            enter();
                            break;
                        case Keys.Back:
                            backspace();
                            break;

                    }
                }
            }
            dpress = 1;
                
        }
    }
}
