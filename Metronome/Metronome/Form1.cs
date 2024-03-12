using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metronome
{
    public partial class Form1 : Form
    {
        String filenameding,filenamedong,filenamedoo;
        SoundPlayer playerding,playerdong,playerdoo;
        int count=0,mode,start=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_initial()
        {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
        }

        private void button_nosee()
        {
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }
        private void button_see()
        {
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            button_initial();
            count++;
            if (mode == 1)
            {
                button_nosee();
                if (count % 4 == 1)
                {
                    button_initial();
                    button1.BackColor = Color.GreenYellow;
                    playerding.Play();
                }
                else playerdong.Play();
                if (count % 4 == 2)
                {
                    button_initial();
                    button2.BackColor = Color.GreenYellow;
                }
                else if (count % 4 == 3)
                {
                    button_initial();
                    button3.BackColor = Color.GreenYellow;
                }
                else if (count % 4 == 0)
                {
                    button_initial();
                    button4.BackColor = Color.GreenYellow;
                }
            }
            else if (mode == 2)
            {
                button_see();
                if (count % 8 == 1)
                {
                    button_initial();
                    button1.BackColor = Color.GreenYellow;
                    playerding.Play();
                }
                else playerdong.Play();
                if(count%8==2)
                {
                    button_initial();
                    button5.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 3)
                {
                    button_initial();
                    button2.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 4)
                {
                    button_initial();
                    button6.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 5)
                {
                    button_initial();
                    button3.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 6)
                {
                    button_initial();
                    button7.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 7)
                {
                    button_initial();
                    button4.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 0)
                {
                    button_initial();
                    button8.BackColor = Color.GreenYellow;
                }

            }
            else if (mode == 3)
            {
                button_initial();
                button_nosee();
                if (count % 4 == 1)
                {
                    button_initial();
                    button1.BackColor = Color.GreenYellow;
                    //playerding.Play();
                    axWindowsMediading.Ctlcontrols.play();
                    do
                    {

                    } while (axWindowsMediading.playState == WMPLib.WMPPlayState.wmppsStopped);
                    //playerdoo.Play();
                    axWindowsMediadoo.Ctlcontrols.play();
                }
                else 
                {
                    //playerdong.Play();
                    axWindowsMediadong.Ctlcontrols.play();
                    //playerdoo.Play();
                    do
                    {

                    }while(axWindowsMediadong.playState == WMPLib.WMPPlayState.wmppsStopped);
                    axWindowsMediadoo.Ctlcontrols.play();
                }
                if (count % 4 == 2)
                {
                    button_initial();
                    button2.BackColor = Color.GreenYellow;
                }
                if (count % 4 == 3)
                {
                    button_initial();
                    button3.BackColor = Color.GreenYellow;
                }
                if (count % 4 == 0)
                {
                    button_initial();
                    button4.BackColor = Color.GreenYellow;
                }

            }
            else if (mode == 4)
            {
                button_see();
                if (count % 8 == 1)
                {
                    button_initial();
                    button1.BackColor = Color.GreenYellow;
                    axWindowsMediading.Ctlcontrols.play();
                    //playerding.Play();
                    do
                    {

                    } while (axWindowsMediading.playState == WMPLib.WMPPlayState.wmppsStopped);
                    axWindowsMediadoo.Ctlcontrols.play();
                    //playerdoo.Play();
                }
                else
                {
                    //playerdong.Play();
                    axWindowsMediadong.Ctlcontrols.play();
                    do { } while (axWindowsMediadong.playState == WMPLib.WMPPlayState.wmppsStopped);
                    //playerdoo.Play();
                    axWindowsMediadoo.Ctlcontrols.play();
                }
                if (count % 8 == 2)
                {
                    button_initial();
                    button5.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 3)
                {
                    button_initial();
                    button2.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 4)
                {
                    button_initial();
                    button6.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 5)
                {
                    button_initial();
                    button3.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 6)
                {
                    button_initial();
                    button7.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 7)
                {
                    button_initial();
                    button4.BackColor = Color.GreenYellow;
                }
                if (count % 8 == 0)
                {
                    button_initial();
                    button8.BackColor = Color.GreenYellow;
                }

            }
            
          }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((start %2)!= 0)
            {
                set();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((start %2)!= 0)
            {
                set();
            }
         }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         showspeed.Text = trackBar1.Value.ToString()+" BPM";
            if ((start %2)!= 0)
            {
                set();
            }
          }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 60;
            trackBar1.Maximum = 180;
            trackBar1.Value = 120;
            axWindowsMediading.URL = @"C:\Users\tim\source\repos\Metronome\Metronome\Resources\ding.wav";
           axWindowsMediadong.URL= @"C:\Users\tim\source\repos\Metronome\Metronome\Resources\dong.wav";
            axWindowsMediadoo.URL= @"C:\Users\tim\source\repos\Metronome\Metronome\Resources\doo.wav";
            filenameding = @"C: \Users\tim\source\repos\Metronome\Metronome\Resources\ding.wav";
            playerding = new SoundPlayer(filenameding);
            filenamedong = @"C:\Users\tim\source\repos\Metronome\Metronome\Resources\dong.wav";
            playerdong = new SoundPlayer(filenamedong);
             filenamedoo = @"C:\Users\tim\source\repos\Metronome\Metronome\Resources\doo.wav";
            playerdoo = new SoundPlayer(filenamedoo);
                }
        public void set()
        {
            int t = 60000 / trackBar1.Value;
             if (string.Equals(comboBox1.Text, "4") && radioButton1.Checked)
            {
                mode = 1;
                timer1.Interval = t;
                timer1.Enabled = true;
            }
            else if (!string.Equals(comboBox1.Text, "4") && radioButton1.Checked)
            {
                mode = 2;
                timer1.Interval = t;
                timer1.Enabled = true;
                }
            else if (string.Equals(comboBox1.Text, "4") && !radioButton1.Checked)
            {
                mode = 3;
                timer1.Interval = t;
                timer1.Enabled = true;
                }
            else if (!string.Equals(comboBox1.Text, "4") && !radioButton1.Checked)
            {
                mode = 4;
                timer1.Interval = t;
                timer1.Enabled = true;
            }
        }
        private void startorpausebutton_Click(object sender, EventArgs e)
        {
            start++;
            if (start % 2 == 1)
            {
                startorpausebutton.Text = "Stop";
                set();
            }
            else if (start % 2 == 0)
            {
                startorpausebutton.Text = "Start";
                timer1.Enabled = false;
            }
            
        }
    }
}
