namespace MyChat
{
    partial class Chat
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
            this.Register = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.personList = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(550, 70);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 23);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(115, 70);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 20);
            this.textUsername.TabIndex = 1;
            this.textUsername.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textUsername_PreviewKeyDown);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(410, 70);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 23);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(284, 70);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 23);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(49, 70);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(60, 15);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "  Currently online";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chat";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(115, 216);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(232, 20);
            this.message.TabIndex = 11;
            this.message.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.message_PreviewKeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(115, 255);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(550, 145);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(100, 264);
            this.personList.TabIndex = 14;
            this.personList.DoubleClick += new System.EventHandler(this.personList_DoubleClick);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(115, 340);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(395, 128);
            this.txtLog.TabIndex = 15;
            this.txtLog.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sender";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 503);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.Register);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}