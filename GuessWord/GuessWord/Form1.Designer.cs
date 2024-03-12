namespace GuessWord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.blankword = new System.Windows.Forms.Label();
            this.guesstimelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "猜英文單字";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(196, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "六次猜錯機會";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "請輸入要猜的單字:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(200, 225);
            this.startbutton.Margin = new System.Windows.Forms.Padding(2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(118, 60);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // blankword
            // 
            this.blankword.AutoSize = true;
            this.blankword.Font = new System.Drawing.Font("新細明體", 25F);
            this.blankword.Location = new System.Drawing.Point(193, 304);
            this.blankword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blankword.Name = "blankword";
            this.blankword.Size = new System.Drawing.Size(0, 34);
            this.blankword.TabIndex = 5;
            this.blankword.Visible = false;
            // 
            // guesstimelabel
            // 
            this.guesstimelabel.AutoSize = true;
            this.guesstimelabel.Location = new System.Drawing.Point(439, 69);
            this.guesstimelabel.Name = "guesstimelabel";
            this.guesstimelabel.Size = new System.Drawing.Size(56, 12);
            this.guesstimelabel.TabIndex = 6;
            this.guesstimelabel.Text = "猜錯次數:";
            this.guesstimelabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(441, 35);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(47, 12);
            this.timelabel.TabIndex = 7;
            this.timelabel.Text = "時間 : 0 ";
            this.timelabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.guesstimelabel);
            this.Controls.Add(this.blankword);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label blankword;
        private System.Windows.Forms.Label guesstimelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelabel;
    }
}

