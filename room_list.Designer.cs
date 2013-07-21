namespace fake_single
{
    partial class room_list
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
            this.range_text = new System.Windows.Forms.Label();
            this.is_valid_text = new System.Windows.Forms.Label();
            this.build_num_text = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.ComboBox();
            this.is_valid = new System.Windows.Forms.ComboBox();
            this.build_num = new System.Windows.Forms.ComboBox();
            this.query = new System.Windows.Forms.Button();
            this.room_list_view = new System.Windows.Forms.ListView();
            this.first_page = new System.Windows.Forms.Button();
            this.pre_page = new System.Windows.Forms.Button();
            this.next_page = new System.Windows.Forms.Button();
            this.last_page = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.data_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areaNu = new System.Windows.Forms.ComboBox();
            this.buildingLv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // range_text
            // 
            this.range_text.AutoSize = true;
            this.range_text.Location = new System.Drawing.Point(271, 47);
            this.range_text.Name = "range_text";
            this.range_text.Size = new System.Drawing.Size(53, 12);
            this.range_text.TabIndex = 0;
            this.range_text.Text = "面积区间";
            this.range_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // is_valid_text
            // 
            this.is_valid_text.AutoSize = true;
            this.is_valid_text.Location = new System.Drawing.Point(480, 46);
            this.is_valid_text.Name = "is_valid_text";
            this.is_valid_text.Size = new System.Drawing.Size(53, 12);
            this.is_valid_text.TabIndex = 1;
            this.is_valid_text.Text = "是否摇中";
            // 
            // build_num_text
            // 
            this.build_num_text.AutoSize = true;
            this.build_num_text.Location = new System.Drawing.Point(622, 47);
            this.build_num_text.Name = "build_num_text";
            this.build_num_text.Size = new System.Drawing.Size(29, 12);
            this.build_num_text.TabIndex = 2;
            this.build_num_text.Text = "楼号";
            // 
            // range
            // 
            this.range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.range.FormattingEnabled = true;
            this.range.Location = new System.Drawing.Point(331, 44);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(121, 20);
            this.range.TabIndex = 3;
            // 
            // is_valid
            // 
            this.is_valid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.is_valid.FormattingEnabled = true;
            this.is_valid.Location = new System.Drawing.Point(539, 44);
            this.is_valid.Name = "is_valid";
            this.is_valid.Size = new System.Drawing.Size(56, 20);
            this.is_valid.TabIndex = 4;
            // 
            // build_num
            // 
            this.build_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.build_num.FormattingEnabled = true;
            this.build_num.Location = new System.Drawing.Point(657, 44);
            this.build_num.Name = "build_num";
            this.build_num.Size = new System.Drawing.Size(56, 20);
            this.build_num.TabIndex = 5;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(728, 42);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 6;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // room_list_view
            // 
            this.room_list_view.Location = new System.Drawing.Point(67, 80);
            this.room_list_view.Name = "room_list_view";
            this.room_list_view.Size = new System.Drawing.Size(736, 314);
            this.room_list_view.TabIndex = 7;
            this.room_list_view.UseCompatibleStateImageBehavior = false;
            this.room_list_view.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.room_list_view_double_click);
            // 
            // first_page
            // 
            this.first_page.Location = new System.Drawing.Point(484, 410);
            this.first_page.Name = "first_page";
            this.first_page.Size = new System.Drawing.Size(75, 23);
            this.first_page.TabIndex = 8;
            this.first_page.Text = "首页";
            this.first_page.UseVisualStyleBackColor = true;
            this.first_page.Click += new System.EventHandler(this.first_page_Click);
            // 
            // pre_page
            // 
            this.pre_page.Location = new System.Drawing.Point(567, 410);
            this.pre_page.Name = "pre_page";
            this.pre_page.Size = new System.Drawing.Size(75, 23);
            this.pre_page.TabIndex = 9;
            this.pre_page.Text = "上一页";
            this.pre_page.UseVisualStyleBackColor = true;
            this.pre_page.Click += new System.EventHandler(this.pre_page_Click);
            // 
            // next_page
            // 
            this.next_page.Location = new System.Drawing.Point(648, 410);
            this.next_page.Name = "next_page";
            this.next_page.Size = new System.Drawing.Size(75, 23);
            this.next_page.TabIndex = 10;
            this.next_page.Text = "下一页";
            this.next_page.UseVisualStyleBackColor = true;
            this.next_page.Click += new System.EventHandler(this.next_page_Click);
            // 
            // last_page
            // 
            this.last_page.Location = new System.Drawing.Point(729, 409);
            this.last_page.Name = "last_page";
            this.last_page.Size = new System.Drawing.Size(75, 23);
            this.last_page.TabIndex = 11;
            this.last_page.Text = "末页";
            this.last_page.UseVisualStyleBackColor = true;
            this.last_page.Click += new System.EventHandler(this.last_page_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 12;
            // 
            // data_result
            // 
            this.data_result.AutoSize = true;
            this.data_result.Location = new System.Drawing.Point(65, 414);
            this.data_result.Name = "data_result";
            this.data_result.Size = new System.Drawing.Size(41, 12);
            this.data_result.TabIndex = 13;
            this.data_result.Text = "label2";
            this.data_result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "小区";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "楼层";
            // 
            // areaNu
            // 
            this.areaNu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaNu.FormattingEnabled = true;
            this.areaNu.Location = new System.Drawing.Point(100, 45);
            this.areaNu.Name = "areaNu";
            this.areaNu.Size = new System.Drawing.Size(56, 20);
            this.areaNu.TabIndex = 16;
            // 
            // buildingLv
            // 
            this.buildingLv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingLv.FormattingEnabled = true;
            this.buildingLv.Location = new System.Drawing.Point(209, 45);
            this.buildingLv.Name = "buildingLv";
            this.buildingLv.Size = new System.Drawing.Size(56, 20);
            this.buildingLv.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // room_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buildingLv);
            this.Controls.Add(this.areaNu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_page);
            this.Controls.Add(this.next_page);
            this.Controls.Add(this.pre_page);
            this.Controls.Add(this.first_page);
            this.Controls.Add(this.room_list_view);
            this.Controls.Add(this.query);
            this.Controls.Add(this.build_num);
            this.Controls.Add(this.is_valid);
            this.Controls.Add(this.range);
            this.Controls.Add(this.build_num_text);
            this.Controls.Add(this.is_valid_text);
            this.Controls.Add(this.range_text);
            this.Name = "room_list";
            this.Text = "房屋列表";
            this.Load += new System.EventHandler(this.room_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label range_text;
        private System.Windows.Forms.Label is_valid_text;
        private System.Windows.Forms.Label build_num_text;
        private System.Windows.Forms.ComboBox range;
        private System.Windows.Forms.ComboBox is_valid;
        private System.Windows.Forms.ComboBox build_num;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.ListView room_list_view;
        private System.Windows.Forms.Button first_page;
        private System.Windows.Forms.Button pre_page;
        private System.Windows.Forms.Button next_page;
        private System.Windows.Forms.Button last_page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label data_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox areaNu;
        private System.Windows.Forms.ComboBox buildingLv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}