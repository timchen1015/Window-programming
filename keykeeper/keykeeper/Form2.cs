using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keykeeper
{
     
    public partial class Form2 : Form
    {
        public List<Account> accounts = new List<Account>();
        public void passList(List<Account> accounts)
        {
            this.accounts = accounts;
        }
        public Form2()
        {
            
            InitializeComponent();
        }

   


     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Account a1 = new Account(textBox1.Text, textBox2.Text, textBox3.Text);
            if (f1.receiveData(a1) == false)
            {
                label6.Text = "帳號已存在";
                return;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label6.Text = "新增完成";
            }
}

        private void backtomenu_Click(object sender, EventArgs e)
        {
            Form1 myNewForm = new Form1();
            this.Hide();
            myNewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Account d1 = new Account(textBox1.Text, textBox2.Text, textBox3.Text);
            if (f1.receiveData2(d1) == false)
            {
                label6.Text = "帳號不存在或密碼錯誤";
                return;
             }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label6.Text = "刪除完成";
            }
        }



    }
}
