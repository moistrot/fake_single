namespace fake_single
{
    partial class draw
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
            this.pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(299, 149);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(100, 21);
            this.pwd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入管理密码：";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(414, 149);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 23);
            this.password.TabIndex = 3;
            this.password.Text = "进入";
            this.password.UseVisualStyleBackColor = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // draw
            // 
            this.ClientSize = new System.Drawing.Size(643, 353);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwd);
            this.Name = "draw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button password;

    }
}