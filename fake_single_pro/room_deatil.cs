using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using FireBirdHelper;

namespace fake_single
{
    public partial class room_deatil : Form
    {

        private static room_deatil instance;

        private RoomBean roombean;

        public static room_deatil getInstance(string room_num, string building)
        {
            if (instance != null)
            {
                instance.Dispose();
            }
            instance = new room_deatil(room_num, building);
            return instance;
        }

        public room_deatil(string room_num, string building)
        {
            InitializeComponent();
            Helper helper = Helper.getInstance();
            roombean = helper.getRoomBean(room_num, Convert.ToInt32(building));

            this.room_num.Text = room_num;
            this.build_num.Text = "#" + roombean.getBuildingNumber();
            this.unit_num.Text = roombean.getName().Split('-')[0];
            this.floor.Text = roombean.getFloor().ToString();
            this.total_area.Text = roombean.getTotalArea().ToString();
            this.actual_area.Text = roombean.getActualArea().ToString();
            this.public_area.Text = roombean.getPublicArea().ToString();
            this.public_ratio.Text = roombean.getPublicRatio().ToString();
            this.under_name.Text = roombean.getUnderName();
            this.under_public_area.Text = roombean.getUnderPublic().ToString();
            this.under_total_area.Text = roombean.getUnderTotal().ToString();
            this.under_actual_area.Text = roombean.getUnderActual().ToString();

            
            
            this.is_valid.Items.Add("否");
            this.is_valid.Items.Add("是");

            this.is_reserved.Items.Add("否");
            this.is_reserved.Items.Add("是");
            // 这里绑定数据
            if (roombean.getIsToken() == 0)
            {
                this.is_valid.SelectedIndex = 0;
            }
            else
            {
                this.is_valid.SelectedIndex = 1;
            }

            if (roombean.getIsReserved() == 0)
            {
                this.is_reserved.SelectedIndex = 0;
            }
            else
            {
                this.is_reserved.SelectedIndex = 1;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void do_save_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                    MessageBox.Show("确定保存吗？", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                // save to db
                if (this.is_valid.SelectedItem.ToString() == "是")
                {
                    roombean.setIsToken(1);
                }
                else
                {
                    roombean.setIsToken(0);
                }

                if (this.is_reserved.SelectedItem.ToString() == "是")
                {
                    roombean.setIsReserved(1);
                }
                else
                {
                    roombean.setIsReserved(0);
                }

                Helper.getInstance().update(roombean);
                this.Dispose();
                // room_list_view reload
                room_list.getInstance().load_list_view();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void room_deatil_Load(object sender, EventArgs e)
        {

        }
    }
}
