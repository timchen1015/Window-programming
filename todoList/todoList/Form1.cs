using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoList
{
    public partial class Form1 : Form

    {
        int t = 0,firsttime=0;
        public static Form1 instance;
        public TextBox tb1;
        public TextBox tb11;
        public TextBox sh1;
        String tt;
        Form2 f2 = new Form2();
        int s = 0;        //搜尋
        
     
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb11 = textBox11;
            sh1 = searchbox;
            
        }
  


        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";             //清0
            t = 1;
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            f2.clear();
            openFileDialog1.InitialDirectory = "C:\todolisttest";
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo;|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 tt = openFileDialog1.FileName;
                FileInfo finfo = new FileInfo(tt);
                StreamReader sr = new StreamReader(tt);
                do
                {
                    String data = sr.ReadLine();
                    String input;
                    String finalinput=null;
                    if (data == null) break;
                    f2.adddoornot(data);
                    char []a = data.ToCharArray();
                    if (a[0] == '+')
                    {
                       input= data.TrimStart('+');
                        f2.addthings(input);
                        finalinput = " [√] " + input;
                    }
                    else if (a[0] == '-')
                    {
                        input = data.TrimStart('-');
                        f2.addthings(input);
                        finalinput = " [ ] " + input;
                    }
                    textBox1.Text += finalinput + "\r\n";
                } while (true);
                sr.Close();
                String ttonly = Path.GetFileName(tt);
                Text = ttonly + " -代辦事項";
                t = 2;
            }

        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(t==1)                //僅新增 需做另存新檔
            {
                saveFileDialog1.InitialDirectory= "C:";
                saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo;|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

              if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tt = saveFileDialog1.FileName;
                    FileInfo finfo = new FileInfo(tt);
                    StreamWriter sw = finfo.CreateText();
                    sw.Write(textBox11.Text);
                    sw.Flush();
                    sw.Close();
                    String ttonly = Path.GetFileName(tt);
                    Text = ttonly + " -代辦事項";
                    t = 2;
                    }
            }
            else if (t == 2)            //已開啟
            {
                //File.WriteAllText(tt, String.Empty);
                File.Delete(tt);
                FileInfo finfo = new FileInfo(tt);
                
                StreamWriter sw = finfo.CreateText();
                sw.Write(textBox11.Text);
                sw.Flush();
                sw.Close();
                tt = Path.GetFileName(tt);
                Text = tt + " -代辦事項";

            }

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
           this.Enabled = false;
            if (s == 0)
            {
                f2.Pass(1);
                f2.Show();
            }
            else if (s == 1)
            {
                s = 0;
                menuStrip1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            searchbox.Enabled = false;
            searchbox.Visible = false;
                this.Enabled = true;
                button1.Enabled = true;
                button1.Visible = true;
            }
            
            
           }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo;|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tt = saveFileDialog1.FileName;
                FileInfo finfo = new FileInfo(tt);
                StreamWriter sw = finfo.CreateText();
                sw.Write(textBox11.Text);
                sw.Flush();
                sw.Close();
                String ttonly = Path.GetFileName(tt);
                Text = ttonly + " -代辦事項";
                t = 2;
            }
        }

        private void 字形大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                fontDialog1.MaxSize = 25;
                fontDialog1.MinSize = 10;
            }
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 新增事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            f2.Pass(1);             //1新增
            f2.Show();
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            f2.Pass(3);             //3刪除
            f2.Show();
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button1.Visible = false;
            this.Enabled = false;
            f2.Pass(4);             //4搜尋
            f2.Show();
            addbutton.Text = " 關閉搜尋";
             s = 1;
            menuStrip1.Enabled = false;
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.showall();

        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.showpartial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            f2.Pass(2);     //  2完成
            f2.Show();
        }

        private void 完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            f2.Pass(2);     //  2完成
            f2.Show();
        }
    }
    }

