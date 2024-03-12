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
  
    public partial class Form1 : Form
    {
     
        static List<Account> accounts = new List<Account>();
        BindingSource accountsBindingSource = new BindingSource();
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void addordelbutton_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
   
        }

     
        private void searchbutton_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";

            foreach (var Account in accounts)
            {
                if (Account.link.Contains(searchbox.Text)==true)
                {
                    textBox1.Text += ("連結:"+Account.link + Environment.NewLine);
                    textBox1.Text += ("使用者:"+Account.user + Environment.NewLine);
                    textBox1.Text += ("密碼:"+Account.pass + Environment.NewLine);
                    textBox1.Text += "====================" + Environment.NewLine;
                }
           
            }
        }

        internal bool receiveData(Account newaccount)
        {   
            for(int i = 0; i < accounts.Count; i++)
            {
                if (newaccount.link == accounts[i].link&& newaccount.user == accounts[i].user)
                {
                    //MessageBox.Show("Item count=" + accounts.Count);
                    return false;
                }

            }
                accounts.Add(newaccount );
            //MessageBox.Show("Item count=" + accounts.Count);
            return true;
        }
        internal bool receiveData2(Account delaccount)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (delaccount.link == accounts[i].link && delaccount.user == accounts[i].user && delaccount.pass == accounts[i].pass)
                {
                    accounts.RemoveAt(i);
                    //為啥不能remove(delaccount)
                    //MessageBox.Show("Item count=" + accounts.Count);
                    return true;
                }

            }
            //MessageBox.Show("Item count=" + accounts.Count);
            return false;
        }

            private void Form1_Activated(object sender, EventArgs e)
        {
            accountsBindingSource.ResetBindings(false);
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            accountsBindingSource.DataSource = accounts;
        }

        private void riskacc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            String []used = new string[100];

            int k = 0;
            for (int i = 0; i < accounts.Count; i++)
            {   k = 0;
                for (int j = i + 1; j < accounts.Count; j++)
                {
                    if (accounts[i].pass == accounts[j].pass&&Array.IndexOf(used, accounts[j].pass)<=0)
                    {
                
                        textBox1.Text += ("連結:" +accounts[j].link + Environment.NewLine);
                        textBox1.Text += ("使用者:" + accounts[j].user + Environment.NewLine);
                        textBox1.Text += ("密碼:" +accounts[j].pass + Environment.NewLine);
                        textBox1.Text += "====================" + Environment.NewLine;
                        k += 1;
                    }
                }
                if (k == 1)
                {   textBox1.Text += ("連結:" + accounts[i].link + Environment.NewLine);
                textBox1.Text += ("使用者:" + accounts[i].user + Environment.NewLine);
                textBox1.Text += ("密碼:" + accounts[i].pass + Environment.NewLine);
                textBox1.Text += "===================="+ Environment.NewLine;
                used[i] = accounts[i].pass;

                }
             
            }
        }
    }
}
