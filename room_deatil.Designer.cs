namespace fake_single
{
    partial class room_deatil
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
            this.label1 = new System.Windows.Forms.Label();
            this.room_num = new System.Windows.Forms.TextBox();
            this.build_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.is_valid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.do_save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // room_num
            // 
            this.room_num.Location = new System.Drawing.Point(78, 28);
            this.room_num.Name = "room_num";
            this.room_num.ReadOnly = true;
            this.room_num.Size = new System.Drawing.Size(100, 21);
            this.room_num.TabIndex = 1;
            // 
            // build_num
            // 
            this.build_num.Location = new System.Drawing.Point(284, 32);
            this.build_num.Name = "build_num";
            this.build_num.ReadOnly = true;
            this.build_num.Size = new System.Drawing.Size(100, 21);
            this.build_num.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "楼号";
            // 
            // is_valid
            // 
            this.is_valid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.is_valid.FormattingEnabled = true;
            this.is_valid.Location = new System.Drawing.Point(98, 317);
            this.is_valid.Name = "is_valid";
            this.is_valid.Size = new System.Drawing.Size(80, 20);
            this.is_valid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "是否摇中";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // do_save
            // 
            this.do_save.Location = new System.Drawing.Point(284, 373);
            this.do_save.Name = "do_save";
            this.do_save.Size = new System.Drawing.Size(75, 23);
            this.do_save.TabIndex = 6;
            this.do_save.Text = "保存";
            this.do_save.UseVisualStyleBackColor = true;
            this.do_save.Click += new System.EventHandler(this.do_save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(379, 372);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // room_deatil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 410);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.do_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.is_valid);
            this.Controls.Add(this.build_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.room_num);
            this.Controls.Add(this.label1);
            this.Name = "room_deatil";
            this.Text = "room_deatil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox room_num;
        private System.Windows.Forms.TextBox build_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox is_valid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button do_save;
        private System.Windows.Forms.Button cancel;
    }
}