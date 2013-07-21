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
    public partial class room_add : Form
    {

        private static room_add instance;

        public room_add()
        {
            InitializeComponent();
        }

        public static room_add getInstance()
        {
            if (instance != null)
            {
                instance.Dispose();
            }
            instance = new room_add();
            return instance;
        }

        private void room_add_Load(object sender, EventArgs e)
        {
            this.areaNu.Items.Add("欣园");
            this.areaNu.Items.Add("朗园");
            this.areaNu.SelectedIndex = 0;

            this.buildingLv.Items.Add("低层");
            this.buildingLv.Items.Add("中层");
            this.buildingLv.Items.Add("高层");
            this.buildingLv.SelectedIndex = 0;
        }

        public void do_save_Click(object sender, EventArgs e)
        {
            // save to db
            int areaNu = this.areaNu.SelectedIndex + 1;
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

            RoomBean room = new RoomBean();
            room.setAreaNo(areaNu);
            room.setBuildingLevel(buildingLv);
            room.setName(room_num);
            room.setFloor(getInt(floor));
            room.setTotalArea(getFloat(total_area));
            room.setActualArea(getFloat(actual_area));
            room.setPublicArea(getFloat(public_area));
            room.setPublicRatio(getFloat(public_ratio));
            room.setUnderActual(getFloat(under_actual_area));
            room.setUnderTotal(getFloat(under_total_area));
            room.setUnderPublic(getFloat(under_public_area));
            room.setUnderName(under_name);
            room.setBuildingNumber(getInt(build_num));
            room.setIsReserved(0);
            room.setIsToken(0);

            Helper.getInstance().add(room);
            this.Dispose();
            // room_list_view reload
            room_list.getInstance().load_list_view();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public string getString(String value) {
            return value == "" ? "" : value;
        }

        public int getInt(String value)
        {
            try
            {
                return value == "" ? 0 : Int32.Parse(value);
            }
            catch {
                return 0;
            }
        }

        public float getFloat(String value) {
            try
            {
                return value == "" ? 0.0f : float.Parse(value);
            }
            catch {
                return 0.0f;
            }
        }
        
    }
}
