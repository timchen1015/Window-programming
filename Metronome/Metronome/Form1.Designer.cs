namespace Metronome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showspeed = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startorpausebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.axWindowsMediading = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediadong = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediadoo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediadong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediadoo)).BeginInit();
            this.SuspendLayout();
            // 
            // showspeed
            // 
            this.showspeed.AutoSize = true;
            this.showspeed.Font = new System.Drawing.Font("新細明體", 15F);
            this.showspeed.Location = new System.Drawing.Point(468, 32);
            this.showspeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showspeed.Name = "showspeed";
            this.showspeed.Size = new System.Drawing.Size(104, 25);
            this.showspeed.TabIndex = 0;
            this.showspeed.Text = "120 BPM";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(233, 83);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(552, 56);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(135, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(829, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "180";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(160, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 59);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(376, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 59);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(570, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 59);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(758, 156);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 59);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "quarternote.png");
            this.imageList1.Images.SetKeyName(1, "quavers.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metronome.Properties.Resources.quavers;
            this.pictureBox2.Location = new System.Drawing.Point(566, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metronome.Properties.Resources.quarternote;
            this.pictureBox1.Location = new System.Drawing.Point(286, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(286, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(378, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(184, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Beat Emphasis";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(427, 465);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "4";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // startorpausebutton
            // 
            this.startorpausebutton.Font = new System.Drawing.Font("新細明體", 12F);
            this.startorpausebutton.Location = new System.Drawing.Point(427, 507);
            this.startorpausebutton.Name = "startorpausebutton";
            this.startorpausebutton.Size = new System.Drawing.Size(121, 43);
            this.startorpausebutton.TabIndex = 13;
            this.startorpausebutton.Text = "start";
            this.startorpausebutton.UseVisualStyleBackColor = true;
            this.startorpausebutton.Click += new System.EventHandler(this.startorpausebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(263, 156);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 59);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(473, 156);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 59);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(664, 156);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 59);
            this.button7.TabIndex = 17;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(859, 156);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 59);
            this.button8.TabIndex = 18;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // axWindowsMediading
            // 
            this.axWindowsMediading.Enabled = true;
            this.axWindowsMediading.Location = new System.Drawing.Point(851, 464);
            this.axWindowsMediading.Name = "axWindowsMediading";
            this.axWindowsMediading.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediading.OcxState")));
            this.axWindowsMediading.Size = new System.Drawing.Size(181, 47);
            this.axWindowsMediading.TabIndex = 19;
            this.axWindowsMediading.Visible = false;
            // 
            // axWindowsMediadong
            // 
            this.axWindowsMediadong.Enabled = true;
            this.axWindowsMediadong.Location = new System.Drawing.Point(922, 366);
            this.axWindowsMediadong.Name = "axWindowsMediadong";
            this.axWindowsMediadong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediadong.OcxState")));
            this.axWindowsMediadong.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediadong.TabIndex = 20;
            this.axWindowsMediadong.Visible = false;
            // 
            // axWindowsMediadoo
            // 
            this.axWindowsMediadoo.Enabled = true;
            this.axWindowsMediadoo.Location = new System.Drawing.Point(940, 296);
            this.axWindowsMediadoo.Name = "axWindowsMediadoo";
            this.axWindowsMediadoo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediadoo.OcxState")));
            this.axWindowsMediadoo.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediadoo.TabIndex = 21;
            this.axWindowsMediadoo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.axWindowsMediadoo);
            this.Controls.Add(this.axWindowsMediadong);
            this.Controls.Add(this.axWindowsMediading);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.startorpausebutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.showspeed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediadong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediadoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showspeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button startorpausebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediading;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediadong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediadoo;
    }
}

