namespace SimpleChatBySignalR.NETClient
{
    partial class Form1
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lst_show = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mess = new System.Windows.Forms.TextBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_gsend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(126, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 22);
            this.txt_name.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(262, 150);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lst_show
            // 
            this.lst_show.FormattingEnabled = true;
            this.lst_show.ItemHeight = 16;
            this.lst_show.Location = new System.Drawing.Point(65, 197);
            this.lst_show.Name = "lst_show";
            this.lst_show.Size = new System.Drawing.Size(311, 228);
            this.lst_show.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // txt_mess
            // 
            this.txt_mess.Location = new System.Drawing.Point(126, 72);
            this.txt_mess.Name = "txt_mess";
            this.txt_mess.Size = new System.Drawing.Size(250, 22);
            this.txt_mess.TabIndex = 6;
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(58, 150);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 23);
            this.btn_join.TabIndex = 8;
            this.btn_join.Text = "Join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_gsend
            // 
            this.btn_gsend.Location = new System.Drawing.Point(139, 140);
            this.btn_gsend.Name = "btn_gsend";
            this.btn_gsend.Size = new System.Drawing.Size(109, 48);
            this.btn_gsend.TabIndex = 9;
            this.btn_gsend.Text = "Send to Group";
            this.btn_gsend.UseVisualStyleBackColor = true;
            this.btn_gsend.Click += new System.EventHandler(this.btn_gsend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_gname
            // 
            this.txt_gname.Location = new System.Drawing.Point(126, 112);
            this.txt_gname.Name = "txt_gname";
            this.txt_gname.Size = new System.Drawing.Size(250, 22);
            this.txt_gname.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gname);
            this.Controls.Add(this.btn_gsend);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_show);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox lst_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mess;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_gsend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gname;
    }
}

