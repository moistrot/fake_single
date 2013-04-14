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
    public partial class room_deatil : Form
    {

        private static room_deatil instance;

        public static room_deatil getInstance(string room_num)
        {
            if (instance != null)
            {
                instance.Dispose();
            }
            instance = new room_deatil(room_num);
            return instance;
        }

        public room_deatil(string room_num)
        {
            InitializeComponent();
            this.room_num.Text = room_num;
            this.is_valid.Items.Add("是");
            this.is_valid.Items.Add("否");
            // 这里绑定数据
            this.is_valid.SelectedIndex = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void do_save_Click(object sender, EventArgs e)
        {
            // save to db
            this.Dispose();
            // room_list_view reload
            room_list.getInstance().load_list_view();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
