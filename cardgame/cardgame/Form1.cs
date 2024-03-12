using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardgame
{
    public partial class namelabel : Form
    {
        Button[] b = new Button[16];
        int[] randomArray = new int[16];
        Boolean[] useornot = new Boolean[16];
        int point = 100;

        int record, time = 0, lastuse = 0, secondlastuse = 0, count = 0;
       
       public namelabel()
        {   
            InitializeComponent();
            makestart();
            
        }
        public void makestart()
        {
            
            var buttons = tabControl1.SelectedTab.Controls.OfType<Button>();
            for (int i = 0; i < 16; i++)
            {
                tabControl1.SelectedTab.Controls.Remove(b[i]);
            }
            Array.Clear(b, 0, b.Length);
            nametextBox.Text = "";
            point = 100;
            time = 0; lastuse = 0; secondlastuse = 0; count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[4 * i + j] = new Button();
                    b[(4 * i + j)].SetBounds(100 + 80 * j, 100 + 80 * i, 60, 60);//(starting point X, starting point Y, width, heighth)
                    int num = (4 * i + j);
                    b[(4 * i + j)].Visible = false;
                    b[(4 * i + j)].Image = imageList1.Images[8];
                    tabPage1.Controls.Add(b[(4 * i + j)]);
                }
            }
            for (int i = 0; i < 16; i++)
            {
                b[i].Name = "";
                useornot[i] = false;
                if (useornot[i] == false) b[i].Enabled = true;
                b[i].Visible = false;
            }
            b[0].Click += new EventHandler((sender, e) => button0_click(sender, e, 0));
            b[1].Click += new EventHandler((sender, e) => button1_click(sender, e, 1));
            b[2].Click += new EventHandler((sender, e) => button1_click(sender, e, 2));
            b[3].Click += new EventHandler((sender, e) => button1_click(sender, e, 3));
            b[4].Click += new EventHandler((sender, e) => button1_click(sender, e, 4));
            b[5].Click += new EventHandler((sender, e) => button1_click(sender, e, 5));
            b[6].Click += new EventHandler((sender, e) => button1_click(sender, e, 6));
            b[7].Click += new EventHandler((sender, e) => button1_click(sender, e, 7));
            b[8].Click += new EventHandler((sender, e) => button1_click(sender, e, 8));
            b[9].Click += new EventHandler((sender, e) => button0_click(sender, e, 9));
            b[10].Click += new EventHandler((sender, e) => button1_click(sender, e, 10));
            b[11].Click += new EventHandler((sender, e) => button1_click(sender, e, 11));
            b[12].Click += new EventHandler((sender, e) => button1_click(sender, e, 12));
            b[13].Click += new EventHandler((sender, e) => button1_click(sender, e, 13));
            b[14].Click += new EventHandler((sender, e) => button1_click(sender, e, 14));
            b[15].Click += new EventHandler((sender, e) => button1_click(sender, e, 15));
            pointlabel.Text = "分數 : " + point.ToString();
            startbutton.Enabled = true;
        }

        private void startbutton_Click_1(object sender, EventArgs e)
        {
            if (nametextBox.Text.Length == 0) {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nametextBox.Text.Length < 3 || nametextBox.Text.Length > 10)
            {
                MessageBox.Show("名稱不符合格式(>=3&&<=10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nametextBox.Enabled = false;
            var ran = new Random();
            randomArray= Enumerable.Range(0, 16).OrderBy(x => ran.Next()).ToArray();
            for (int i = 0; i < 16; i++)
            {
                b[i].Visible = true;
            }
            startbutton.Enabled = false;
            continuebutton.Enabled = false;
            leavebutton.Enabled = true;
           
        }
        
        private void reuse(int k,int r)
        {
            ; if (time == 0)
            {  
               pointlabel.Text = "分數 : " + point.ToString();
                b[k].Enabled = true;
                b[k].Name = "open";
                record = randomArray[k] % 8;
                time++;
                b[k].Image = imageList1.Images[randomArray[k] % 8];
                lastuse = k;
               
                return;
            }
            else if (time == 1)
            {
                if (k == lastuse) return;
                time--;
                b[k].Enabled = true;
                b[k].Name = "open";
                b[k].Image = imageList1.Images[randomArray[k] % 8];
                if (record == randomArray[k] % 8)
                {
                    point += 10;
                    pointlabel.Text = "分數 : " + point.ToString();
                    b[k].Enabled = false;
                    b[r].Enabled = false;
                    useornot[k] = true;
                    useornot[r] = true;
                  
                    count++;
                    if (count == 8)
                    {
                        hisplay.Text += nametextBox.Text + " 得分為 : " + point.ToString()+"\n";
                        DialogResult result= MessageBox.Show("分數: " + point, "遊戲結束", MessageBoxButtons.RetryCancel);
                        continuebutton.Enabled = false;
                        if (result == DialogResult.Retry)
                        {
                            makestart();
                            nametextBox.Enabled = true;
                        }
                        
                    }
                    return;
                    }
                else if(record != randomArray[k] % 8){
                    point -= 5;
                    pointlabel.Text = "分數 : " + point.ToString();
                    for (int i = 0; i < 16; i++)
                    {
                        if (useornot[i] == false) 
                        b[i].Enabled = false;
                    }
                    b[r].Enabled = true;
                    b[k].Enabled = true;
                    continuebutton.Enabled = true;
                    lastuse = k;
                    secondlastuse = r;
                }

            }
        }
        private void button0_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
              reuse(ind,lastuse);
        }
        private void button1_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind,lastuse);
        }
        private void button2_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button3_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button4_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button5_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button6_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button7_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button8_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button9_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button10_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button11_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button12_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button13_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
        private void button14_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
    private void button15_click(object sender, EventArgs e, int ind)
        {
            if (b[ind].Name == b[lastuse].Name && b[ind].Name == "open") return;
            reuse(ind, lastuse);
        }
   private void continuebutton_Click(object sender, EventArgs e)
        {
     
            b[lastuse].Image = imageList1.Images[8];
            b[lastuse].Name = "";
            b[secondlastuse].Image = imageList1.Images[8];
            b[secondlastuse].Name = "";
            for(int i = 0; i < 16; i++)
            {
                if(useornot[i]==false)
                b[i].Enabled = true;
            }
            lastuse = 0;    secondlastuse = 0;
            continuebutton.Enabled = false;
          
        }

      private void restart_Click(object sender, EventArgs e)
        {
       
            makestart();
            nametextBox.Enabled = true;
        }

        
        private void leavebutton_Click(object sender, EventArgs e)
        {
          
            DialogResult result=  MessageBox.Show("確定要離開遊戲?", "離開遊戲", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
          
        }

   
    }
}
