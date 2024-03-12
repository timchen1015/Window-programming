using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWord
{
    public partial class Form1 : Form
    {
        String guessstr;
        Button []b = new Button[26];
  
        Char[] wordarr = new Char[20];
        Char[] wordarr2 = new Char[20];
        int time = 0, alltime = 0,sum=0,count=0;

        public Form1()
        {
            InitializeComponent();
            if (textBox1.Text.Length == 0) startbutton.Enabled = false;
            else if (textBox1.Text.Length != 0) startbutton.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                e.Handled = false;
            else if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
            if (textBox1.Text.Length == 0) startbutton.Enabled = false;
            else if (textBox1.Text.Length != 0) startbutton.Enabled = true;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            time = 0; alltime = 0; sum = 0; count = 0;
            timelabel.Visible = true;
            timer1.Enabled = true;
            startbutton.Enabled = false;
            startbutton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            guesstimelabel.Visible = true;
            guesstimelabel.Text = "猜錯次數: 0次";
            textBox1.Enabled = false;
            textBox1.Visible = false;
            guessstr = textBox1.Text;
            guessstr= guessstr.ToUpper();
            wordarr = guessstr.ToCharArray();
            char countt= 'A';
         for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if ((10 * i + j) >= 26) goto down;
                    b[10 * i + j] = new Button();
                    b[10 * i + j].SetBounds(10 + 40 * j, 10 + 40 * i, 30, 30);
                    b[10 * i + j].Text = countt.ToString();
                    Controls.Add(b[10 * i + j]);
                    countt++;
                }
            }
            down: blankword.Visible = true;
            for (int i = 0;i<textBox1.Text.Length; i++)
            {
                
                wordarr2[i] = '_';
                blankword.Text += wordarr2[i].ToString()+" ";
            }
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            timelabel.Text = "時間 : " + count.ToString();
         }



        private void reuse(Char a,int t,int allt)
        {
            allt++;
            blankword.Text = "";int useall = 0,re=0;
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if (wordarr[i] == a)
                {
                    re++;
                    wordarr2[i] = a;
                    for(int j = 0; j < 26; j++)
                    {
                        if (b[j].Text == a.ToString())
                        {
                            b[j].BackColor = Color.LightGreen;
                            useall = 1;
                            break;
                        }
                    }
                }
            blankword.Text += wordarr2[i].ToString() + " ";
            }
            sum += re;
            if (sum>= textBox1.Text.Length)
            {
                string s ="花費時間:"+count.ToString()+"\n"+ "猜錯 " + t + " 次";
                DialogResult result= MessageBox.Show(s, "You win !", MessageBoxButtons.OK);
                reset(result);
            }
            else if (useall == 0)
            {
                t++;
                for (int j = 0; j< 26; j++)
                {
                    if (b[j].Text == a.ToString())
                    {
                        b[j].Enabled = false;
                        b[j].Visible = false;
                    }
                }
                if (t == 6)
                {   guesstimelabel.Text = "猜錯次數: " + t+"次";
                    DialogResult result=MessageBox.Show("You Lose !", "", MessageBoxButtons.OK);
                    reset(result);
                }
                useall = 0;
            }
            time = t;   alltime = allt;
            guesstimelabel.Text = "猜錯次數: " + time + "次";
        }

        private void reset(DialogResult result)
        {   
            if (result == DialogResult.OK)
            {
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
                    
               }
        }



         private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
                 switch (e.KeyCode)
                 {
                     case Keys.A:
                         reuse('A',time,alltime);
                       break;
                     case Keys.B:
                         reuse('B',time,alltime);
                         break;
                     case Keys.C:
                         reuse('C',time,alltime);
                         break;
                     case Keys.D:
                         reuse('D', time, alltime);
                         break;
                     case Keys.E:
                         reuse('E', time, alltime);
                         break;
                     case Keys.F:
                         reuse('F', time, alltime);
                         break;
                     case Keys.G:
                         reuse('G', time, alltime);
                         break;
                     case Keys.H:
                         reuse('H', time, alltime);
                         break;
                     case Keys.I:
                         reuse('I', time, alltime);
                         break;
                     case Keys.J:
                         reuse('J', time, alltime);
                         break;
                     case Keys.K:
                         reuse('K', time, alltime);
                         break;
                     case Keys.L:
                         reuse('L', time, alltime);
                         break;
                     case Keys.M:
                         reuse('M', time, alltime);
                         break;
                     case Keys.N:
                         reuse('N', time, alltime);
                         break;
                     case Keys.O:
                         reuse('O', time, alltime);
                         break;
                     case Keys.P:
                         reuse('P', time, alltime);
                         break;
                     case Keys.Q:
                         reuse('Q', time, alltime);
                         break;
                     case Keys.R:
                         reuse('R', time, alltime);
                         break;
                     case Keys.S:
                         reuse('S', time, alltime);
                         break;
                     case Keys.T:
                         reuse('T', time, alltime);
                         break;
                     case Keys.U:
                         reuse('U', time, alltime);
                         break;
                     case Keys.V:
                         reuse('V', time, alltime);
                         break;
                     case Keys.W:
                         reuse('W', time, alltime);
                         break;
                     case Keys.X:
                         reuse('X', time, alltime);
                         break;
                     case Keys.Y:
                         reuse('Y', time, alltime);
                         break;
                     case Keys.Z:
                         reuse('Z', time, alltime);
                         break;
                         }
           
         }


    }
}
