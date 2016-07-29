namespace sms
{
    partial class Send
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.msgLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumLab = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "用户信息";
            this.openFileDialog1.Filter = "文本文件|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button1.Location = new System.Drawing.Point(46, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开用户信息文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.CausesValidation = false;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(67, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 320);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.TabStop = false;
            // 
            // contentTxt
            // 
            this.contentTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contentTxt.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentTxt.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.contentTxt.Location = new System.Drawing.Point(279, 24);
            this.contentTxt.MaxLength = 500;
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(319, 248);
            this.contentTxt.TabIndex = 1;
            this.contentTxt.TextChanged += new System.EventHandler(this.contentTxt_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button2.Location = new System.Drawing.Point(289, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "清除所选用户";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button3.Location = new System.Drawing.Point(470, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "发送短信";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // msgLab
            // 
            this.msgLab.AutoSize = true;
            this.msgLab.CausesValidation = false;
            this.msgLab.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.msgLab.Location = new System.Drawing.Point(285, 295);
            this.msgLab.Name = "msgLab";
            this.msgLab.Size = new System.Drawing.Size(293, 20);
            this.msgLab.TabIndex = 5;
            this.msgLab.Text = "你将给 0 个人群发信息，短信字数共计为 0 个";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户列表：";
            // 
            // sumLab
            // 
            this.sumLab.AutoSize = true;
            this.sumLab.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.sumLab.Location = new System.Drawing.Point(285, 412);
            this.sumLab.Name = "sumLab";
            this.sumLab.Size = new System.Drawing.Size(307, 20);
            this.sumLab.TabIndex = 7;
            this.sumLab.Text = "登录成功后，你已发送了 0 条信息，成功了 0 条";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(437, 452);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(149, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "进入创蓝后台查看发送情况";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(665, 473);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.sumLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgLab);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contentTxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Send";
            this.Text = "魔方金服短信群发客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label msgLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sumLab;
        private System.Windows.Forms.LinkLabel linkLabel2;


    }
}