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

        public static room_deatil getInstance(string room_num, string building, string areastr)
        {
            if (instance != null)
            {
                instance.Dispose();
            }
            instance = new room_deatil(room_num, building, areastr);
            return instance;
        }

        public room_deatil(string room_num, string building, string areaStr)
        {
            InitializeComponent();

            int areaIdx = 0;
            if (areaStr.Equals("欣园"))
            {
                areaIdx = 1;
            }
            if (areaStr.Equals("朗园"))
            {
                areaIdx = 2;
            }

            this.buildingLv.Items.Add("低层");
            this.buildingLv.Items.Add("中层");
            this.buildingLv.Items.Add("高层");

            Helper helper = Helper.getInstance();
            roombean = helper.getRoomBean(room_num, Convert.ToInt32(building), 0, areaIdx);

            this.room_num.Text = room_num;
            this.build_num.Text = roombean.getBuildingNumber().ToString();

            this.floor.Text = roombean.getFloor().ToString();
            this.total_area.Text = roombean.getTotalArea().ToString();
            this.actual_area.Text = roombean.getActualArea().ToString();
            this.public_area.Text = roombean.getPublicArea().ToString();
            this.public_ratio.Text = roombean.getPublicRatio().ToString();
            this.under_name.Text = roombean.getUnderName();
            this.under_public_area.Text = roombean.getUnderPublic().ToString();
            this.under_total_area.Text = roombean.getUnderTotal().ToString();
            this.under_actual_area.Text = roombean.getUnderActual().ToString();
            this.areaNu.Text = areaStr;
            if (roombean.getBuildingLevel() != 0)
            {
                this.buildingLv.SelectedIndex = roombean.getBuildingLevel() - 1;
            }

            


            this.is_valid.Items.Add("否");
            this.is_valid.Items.Add("是");
            // 这里绑定数据
            if (roombean.getIsToken() == 0)
            {
                this.is_valid.SelectedIndex = 0;
            }
            else
            {
                this.is_valid.SelectedIndex = 1;
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
                int buildingLv = this.buildingLv.SelectedIndex + 1;
                string room_num = this.room_num.Text;
                string floor = this.floor.Text;
                string total_area = this.total_area.Text;
                string actual_area = this.actual_area.Text;
                string public_area = this.public_area.Text;
                string public_ratio = this.public_ratio.Text;
                string under_actual_area = this.under_actual_area.Text;
                string under_total_area = this.under_total_area.Text;
                string under_public_area = this.under_public_area.Text;
                string under_name = this.under_name.Text;
                string build_num = this.build_num.Text;

                roombean.setBuildingLevel(buildingLv);
                roombean.setName(room_num);
                roombean.setFloor(getInt(floor));
                roombean.setTotalArea(getFloat(total_area));
                roombean.setActualArea(getFloat(actual_area));
                roombean.setPublicArea(getFloat(public_area));
                roombean.setPublicRatio(getFloat(public_ratio));
                roombean.setUnderActual(getFloat(under_actual_area));
                roombean.setUnderTotal(getFloat(under_total_area));
                roombean.setUnderPublic(getFloat(under_public_area));
                roombean.setUnderName(under_name);
                roombean.setBuildingNumber(getInt(build_num));

                // save to db
                if (this.is_valid.SelectedItem.ToString() == "是")
                {
                    roombean.setIsToken(1);
                }
                else
                {
                    roombean.setIsToken(0);
                }
               
                Helper.getInstance().updateAll(roombean);
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

        public string getString(String value)
        {
            return value == "" ? "" : value;
        }

        public int getInt(String value)
        {
            try
            {
                return value == "" ? 0 : Int32.Parse(value);
            }
            catch
            {
                return 0;
            }
        }

        public float getFloat(String value)
        {
            try
            {
                return value == "" ? 0.0f : float.Parse(value);
            }
            catch
            {
                return 0.0f;
            }
        }
    }
}
