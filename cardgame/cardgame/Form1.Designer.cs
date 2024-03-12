namespace cardgame
{
    partial class namelabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(namelabel));
            this.label1 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.continuebutton = new System.Windows.Forms.Button();
            this.leavebutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.restart = new System.Windows.Forms.Button();
            this.pointlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hisplay = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "翻牌小遊戲";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(565, 47);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "開始遊戲";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click_1);
            // 
            // continuebutton
            // 
            this.continuebutton.Enabled = false;
            this.continuebutton.Location = new System.Drawing.Point(565, 117);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(75, 23);
            this.continuebutton.TabIndex = 2;
            this.continuebutton.Text = "繼續";
            this.continuebutton.UseVisualStyleBackColor = true;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            // 
            // leavebutton
            // 
            this.leavebutton.Location = new System.Drawing.Point(565, 263);
            this.leavebutton.Name = "leavebutton";
            this.leavebutton.Size = new System.Drawing.Size(75, 23);
            this.leavebutton.TabIndex = 3;
            this.leavebutton.Text = "離開遊戲";
            this.leavebutton.UseVisualStyleBackColor = true;
            
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.jpg");
            this.imageList1.Images.SetKeyName(1, "02.jpg");
            this.imageList1.Images.SetKeyName(2, "03.jpg");
            this.imageList1.Images.SetKeyName(3, "04.jpg");
            this.imageList1.Images.SetKeyName(4, "05.jpg");
            this.imageList1.Images.SetKeyName(5, "06.jpg");
            this.imageList1.Images.SetKeyName(6, "07.jpg");
            this.imageList1.Images.SetKeyName(7, "08.jpg");
            this.imageList1.Images.SetKeyName(8, "card.jpg");
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(565, 185);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 4;
            this.restart.Text = "重新開始";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pointlabel
            // 
            this.pointlabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.pointlabel.Location = new System.Drawing.Point(6, 16);
            this.pointlabel.Name = "pointlabel";
            this.pointlabel.Size = new System.Drawing.Size(121, 25);
            this.pointlabel.TabIndex = 5;
            this.pointlabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(75, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "名稱:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(163, 16);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(145, 22);
            this.nametextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hisplay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "歷史紀錄區";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hisplay
            // 
            this.hisplay.AutoSize = true;
            this.hisplay.Location = new System.Drawing.Point(52, 41);
            this.hisplay.Name = "hisplay";
            this.hisplay.Size = new System.Drawing.Size(0, 12);
            this.hisplay.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pointlabel);
            this.tabPage1.Controls.Add(this.restart);
            this.tabPage1.Controls.Add(this.nametextBox);
            this.tabPage1.Controls.Add(this.leavebutton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.continuebutton);
            this.tabPage1.Controls.Add(this.startbutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "遊玩區";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 505);
            this.tabControl1.TabIndex = 8;
            // 
            // namelabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "namelabel";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.Button leavebutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label pointlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label hisplay;
    }
}

