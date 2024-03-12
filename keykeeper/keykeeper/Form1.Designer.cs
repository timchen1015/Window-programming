namespace keykeeper
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.riskacc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addordelbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(181, 60);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(472, 25);
            this.searchbox.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(693, 61);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "搜尋";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // riskacc
            // 
            this.riskacc.Location = new System.Drawing.Point(98, 111);
            this.riskacc.Name = "riskacc";
            this.riskacc.Size = new System.Drawing.Size(670, 23);
            this.riskacc.TabIndex = 4;
            this.riskacc.Text = "風險帳號";
            this.riskacc.UseVisualStyleBackColor = true;
            this.riskacc.Click += new System.EventHandler(this.riskacc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "搜尋結果";
            // 
            // addordelbutton
            // 
            this.addordelbutton.Location = new System.Drawing.Point(639, 161);
            this.addordelbutton.Name = "addordelbutton";
            this.addordelbutton.Size = new System.Drawing.Size(129, 23);
            this.addordelbutton.TabIndex = 6;
            this.addordelbutton.Text = "新增或刪除";
            this.addordelbutton.UseVisualStyleBackColor = true;
            this.addordelbutton.Click += new System.EventHandler(this.addordelbutton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(718, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 82);
            this.label4.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(98, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(570, 222);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addordelbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.riskacc);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button riskacc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addordelbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

