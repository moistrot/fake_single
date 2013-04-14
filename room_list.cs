using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireBirdHelper;

namespace fake_single
{
    public partial class room_list : Form
    {
        private static int PAGE_SIZE = 25;

        private int page_num = 1;
        private int total_page = 0;

        private List<RoomBean> rooms = null;

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
            Helper helper = Helper.getInstance();
            List<SECTION> sections = helper.getSections();
            this.range.Items.Add("不限");
            for (int i = 0; i < sections.Count; i++)
            {
                this.range.Items.Add(sections[i].toString());
            }
            this.range.SelectedIndex = 0;
        }  

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void room_list_Load(object sender, EventArgs e)
        {
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
            room_list_view.Columns.Add("建筑面积(㎡)", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("套内面积(㎡)", 100, HorizontalAlignment.Center);
            room_list_view.Columns.Add("已摇", 100, HorizontalAlignment.Center);

            load_list_view_data();
        }

        private List<RoomBean> getQueryResult()
        {


            int min_range = 0;
            int max_range = 10000;
            String selected_range = range.SelectedItem.ToString();
            if (!selected_range.Equals("不限"))
            {
                String[] temp_selected = selected_range.Split('-');    
                min_range = Convert.ToInt32(temp_selected[0]);
                max_range = Convert.ToInt32(temp_selected[1]);
            }

            Helper helper = Helper.getInstance();
            return helper.find(min_range, max_range, -1, 0, 0, 0);
        }

        private void load_list_view_data()
        {
            room_list_view.Items.Clear();
            rooms = getQueryResult();

            int result_size = rooms.Count;
            total_page = (int)(result_size / PAGE_SIZE + 1);

            data_result.TextAlign = ContentAlignment.MiddleRight;
            data_result.Text = "共找到" + result_size
                                + "条记录,共" + total_page + "页,"
                                + "第" + page_num + "页";

            room_list_view.BeginUpdate();

            int begain_num = (page_num - 1) * PAGE_SIZE;
            
            for(int i = begain_num; i < begain_num + PAGE_SIZE; i++)
            {
                if (i == result_size)
                {
                    break;
                }
                RoomBean room = rooms[i];
                String token = room.getIsToken() == 0 ? "未摇" : "已摇";
                add_data("row" + i, new string[] 
                { 
                    (i + 1).ToString(), 
                    "#" + room.getBuildingNumber(), 
                    room.getName(), 
                    room.getPublicArea().ToString(),
                    room.getTotalArea().ToString(),
                    token
                }
                );
            }
            
            room_list_view.EndUpdate();

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

        private void pre_page_Click(object sender, EventArgs e)
        {
            if (page_num > 1)
            {
                page_num--;
                load_list_view_data();
            }
            else
            {
                MessageBox.Show("你好，已经是首页.");
            }
        }

        private void next_page_Click(object sender, EventArgs e)
        {
            if (page_num < total_page)
            {
                page_num++;
                load_list_view_data();
            }
            else
            {
                MessageBox.Show("你好，已经是末页.");
            }
        }

        private void first_page_Click(object sender, EventArgs e)
        {
            page_num = 1;
            load_list_view_data();
        }

        private void last_page_Click(object sender, EventArgs e)
        {
            page_num = total_page;
            load_list_view_data();
        }

        private void query_Click(object sender, EventArgs e)
        {
            load_list_view_data();
        }

    }
}
