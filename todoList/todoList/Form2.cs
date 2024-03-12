using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoList
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        int passint;
        public List<string> things = new List<string>();
        public List<string> doornotthings = new List<string>();
       
        public Form2()
        {
            InitializeComponent();
            instance = this;
         }

        public void Pass(int k)
        {
            passint = k;
        }
        public void write(string s)
        {
            if (s.ElementAt(0) == '+')
            {
                Form1.instance.tb1.Text += " [√] ";
            }
            else if (s.ElementAt(0) == '-')
            {
                Form1.instance.tb1.Text += " [ ] ";
            }
            String result = s.Remove(0, 1);
            Form1.instance.tb1.Text += result+"\r\n";
        }

        public void writesearch(string s)
        {
            if (s.ElementAt(0) == '+')
            {
                Form1.instance.sh1.Text += " [√] ";
            }
            else if (s.ElementAt(0) == '-')
            {
                Form1.instance.sh1.Text += " [ ] ";
            }
            String result = s.Remove(0, 1);
            things.Add(result);
            Form1.instance.sh1.Text += result + "\r\n";
        }
    

        private void yes_Click(object sender, EventArgs e)
        {
            switch (passint)
            {
                case 1:                                                     //加入
                    Text = "新增代辦事項";
                    if (textBox2.Text.Length != 0)
                    {
                        String adddo = "-" + textBox2.Text;
                        doornotthings.Add(adddo);
                        things.Add(textBox2.Text);
                        write(adddo);
                        Form1.instance.tb11.Text +=adddo+"\r\n";
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    else if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("請輸入事項", "", MessageBoxButtons.OK);
                    }
                    break;
                case 2:                                             //完成
                    Text = "代辦事項";
                    if (textBox2.Text.Length == 0)
                    {
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    else
                    {
                        if (things.Contains(textBox2.Text) == true)
                        {
                            String result = textBox2.Text;
                            int index = things.IndexOf(textBox2.Text);
                            doornotthings.RemoveAt(index);
                            result = "+" + result;
                            doornotthings.Insert(index, result);
                            Form1.instance.tb1.Text = "";
                            Form1.instance.tb11.Text = "";
                            foreach (var word in doornotthings)
                            {
                                Form1.instance.tb11.Text += word+"\r\n";
                                write(word);
                            }
                        }
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    break;
                case 3:                                         //delete
                    Text = "代辦事項";
                    if (textBox2.Text.Length == 0)
                    {
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    else
                    {
                        if (things.Contains(textBox2.Text) == true)
                        {
                            int index = things.IndexOf(textBox2.Text);
                            things.RemoveAt(index);
                            doornotthings.RemoveAt(index);
                            Form1.instance.tb1.Text = "";
                            Form1.instance.tb11.Text = "";
                            foreach (var word in doornotthings)
                            {
                                Form1.instance.tb11.Text += word+"\r\n";
                                write(word);
                            }
                        }
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    break;
                case 4:             // 搜尋
                    Text = "代辦事項";
                    Form1.instance.sh1.Text = "";
                    Form1.instance.tb1.Visible = false;
                    Form1.instance.tb1.Enabled = false;
                    if (textBox2.Text.Length == 0)
                    {
                        this.Hide();
                        Form1.instance.Enabled = true;
                        Form1.instance.sh1.Text = "";
                    }
                    else
                    {
                        foreach (var word in doornotthings)
                        {
                            Form1.instance.sh1.Enabled = true;
                            Form1.instance.sh1.Visible = true;
                            if (word.Contains(textBox2.Text))
                            {
                                writesearch(word);
                            }
                        }
                        this.Hide();
                        Form1.instance.Enabled = true;
                    }
                    break;

            }
            textBox2.Text = "";
        

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.instance.Enabled = true;
        }

        public void showall()
        {
            Form1.instance.tb1.Text = "";
            foreach (var word in doornotthings)
            {
                write(word);
            }
        }

        public void showpartial()
        {
            Form1.instance.tb1.Text = "";
            foreach(var word in doornotthings)
            {
                if (word.ElementAt(0) == '+') continue;
                write(word);
            }
        }
        public void addthings(string s)
        {
            things.Add(s);
        }
        public void adddoornot(string s)
        {
            doornotthings.Add(s);
        }
        public void clear()
        {
            things.Clear();
            doornotthings.Clear();
        }
      }
}
