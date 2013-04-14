using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fake_single
{
    public partial class room_list : Form
    {
        private static room_list instance;

        public static room_list getInstance()
        {
            if (instance == null)
            {
                instance = new room_list();
            }
            return instance;
        }

        public room_list()
        {
            InitializeComponent();
            
        }  

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        

        private void room_list_Load(object sender, EventArgs e)
        {
            this.range.Items.Add("不限");
            this.range.Items.Add("80-90");
            this.range.Items.Add("90-200");
            this.range.SelectedIndex = 0;

            this.is_valid.Items.Add("不限");
            this.is_valid.Items.Add("已摇");
            this.is_valid.Items.Add("未摇");
            this.is_valid.SelectedIndex = 0;

            for (int i = 1; i < 16; i++)
            {
                this.build_num.Items.Add("#" + i);
            }
            this.build_num.SelectedIndex = 0;

            load_list_view();
        }

        public void load_list_view()
        {
            room_list_view.Clear();
            room_list_view.View = View.Details;
            room_list_view.Columns.Add("序号", 50, HorizontalAlignment.Center);
            room_list_view.Columns.Add("楼号", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("房号", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("建筑面积", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("套内面积", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("已摇", 100, HorizontalAlignment.Center);

            load_list_view_data();
        }

        private void load_list_view_data()
        {
            room_list_view.BeginUpdate();
            
            for(int i = 1; i < 21; i++)
            {
                add_data("row" + i, new string[] { i.ToString(), "#" + i, (500 + i).ToString(), "80", "60", "已摇",});
            }
            
            room_list_view.EndUpdate();

            data_result.TextAlign = ContentAlignment.MiddleRight;
            data_result.Text = "共找到33条记录,共2页";

            room_list_view.GridLines = true;
            room_list_view.View = View.Details;
            room_list_view.FullRowSelect = true;
            room_list_view.MultiSelect = false;
            
            room_list_view.HeaderStyle = ColumnHeaderStyle.Clickable;
            
        }

        private void add_data(string row_name, string[] data)
        {
            room_list_view.Items.Add(row_name, data[0], 0);
            for (int i = 1; i < data.Length; i++)
            {
                room_list_view.Items[row_name].SubItems.Add(data[i]);


            }
        }

        private void room_list_view_double_click(object sender, EventArgs e)
        {
            if (room_list_view.SelectedItems.Count == 0) return;
            string room_num = room_list_view.SelectedItems[0].SubItems[2].Text;
            room_deatil detail = room_deatil.getInstance(room_num);
            detail.MdiParent = this.ParentForm;


            detail.WindowState = FormWindowState.Maximized;
            detail.Show();
            // MessageBox.Show("您单击的是" + );
        }

    }
}
