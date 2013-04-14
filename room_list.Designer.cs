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
            this.SuspendLayout();
            // 
            // range_text
            // 
            this.range_text.AutoSize = true;
            this.range_text.Location = new System.Drawing.Point(65, 30);
            this.range_text.Name = "range_text";
            this.range_text.Size = new System.Drawing.Size(53, 12);
            this.range_text.TabIndex = 0;
            this.range_text.Text = "面积区间";
            this.range_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // is_valid_text
            // 
            this.is_valid_text.AutoSize = true;
            this.is_valid_text.Location = new System.Drawing.Point(310, 30);
            this.is_valid_text.Name = "is_valid_text";
            this.is_valid_text.Size = new System.Drawing.Size(53, 12);
            this.is_valid_text.TabIndex = 1;
            this.is_valid_text.Text = "是否摇中";
            // 
            // build_num_text
            // 
            this.build_num_text.AutoSize = true;
            this.build_num_text.Location = new System.Drawing.Point(485, 31);
            this.build_num_text.Name = "build_num_text";
            this.build_num_text.Size = new System.Drawing.Size(29, 12);
            this.build_num_text.TabIndex = 2;
            this.build_num_text.Text = "楼号";
            // 
            // range
            // 
            this.range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.range.FormattingEnabled = true;
            this.range.Location = new System.Drawing.Point(125, 28);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(121, 20);
            this.range.TabIndex = 3;
            // 
            // is_valid
            // 
            this.is_valid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.is_valid.FormattingEnabled = true;
            this.is_valid.Location = new System.Drawing.Point(369, 28);
            this.is_valid.Name = "is_valid";
            this.is_valid.Size = new System.Drawing.Size(56, 20);
            this.is_valid.TabIndex = 4;
            // 
            // build_num
            // 
            this.build_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.build_num.FormattingEnabled = true;
            this.build_num.Location = new System.Drawing.Point(520, 28);
            this.build_num.Name = "build_num";
            this.build_num.Size = new System.Drawing.Size(56, 20);
            this.build_num.TabIndex = 5;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(612, 27);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 6;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            // 
            // room_list_view
            // 
            this.room_list_view.Location = new System.Drawing.Point(67, 80);
            this.room_list_view.Name = "room_list_view";
            this.room_list_view.Size = new System.Drawing.Size(620, 314);
            this.room_list_view.TabIndex = 7;
            this.room_list_view.UseCompatibleStateImageBehavior = false;
            this.room_list_view.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.room_list_view_double_click);
            // 
            // first_page
            // 
            this.first_page.Location = new System.Drawing.Point(385, 410);
            this.first_page.Name = "first_page";
            this.first_page.Size = new System.Drawing.Size(75, 23);
            this.first_page.TabIndex = 8;
            this.first_page.Text = "首页";
            this.first_page.UseVisualStyleBackColor = true;
            // 
            // pre_page
            // 
            this.pre_page.Location = new System.Drawing.Point(468, 410);
            this.pre_page.Name = "pre_page";
            this.pre_page.Size = new System.Drawing.Size(75, 23);
            this.pre_page.TabIndex = 9;
            this.pre_page.Text = "上一页";
            this.pre_page.UseVisualStyleBackColor = true;
            // 
            // next_page
            // 
            this.next_page.Location = new System.Drawing.Point(549, 410);
            this.next_page.Name = "next_page";
            this.next_page.Size = new System.Drawing.Size(75, 23);
            this.next_page.TabIndex = 10;
            this.next_page.Text = "下一页";
            this.next_page.UseVisualStyleBackColor = true;
            // 
            // last_page
            // 
            this.last_page.Location = new System.Drawing.Point(630, 409);
            this.last_page.Name = "last_page";
            this.last_page.Size = new System.Drawing.Size(75, 23);
            this.last_page.TabIndex = 11;
            this.last_page.Text = "末页";
            this.last_page.UseVisualStyleBackColor = true;
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
            // room_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 439);
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
    }
}