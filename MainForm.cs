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
    public partial class MainForm : Form
    {
        static MainForm instance;

        public static MainForm getInstance()
        {
            if (instance == null)
            {
                instance = new MainForm();
            }
            return instance;
        }



        public MainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Helper helper = Helper.getInstance();
            List<SECTION> sections = helper.getSections();
            for (int i= 0 ;i < sections.Count; i++){
                this.range_select.Items.Add(sections[i].toString());
            }


            this.building_level.Items.Add("低层");
            this.building_level.Items.Add("中层");
            this.building_level.Items.Add("高层");

            this.building_level.SelectedIndex = 0;
            this.range_select.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 得到面积区间
            String range = range_select.SelectedItem.ToString();

            Helper helper = Helper.getInstance();
            List<SECTION> sections = helper.getSections();

            SECTION section = null;

            for (int i = 0; i < sections.Count; i++)
            {
                if (sections[i].toString().Equals(range))
                {
                    section = sections[i];
                    break;
                }
            }

            Console.WriteLine(section.toString());

            // 得到层级
            int buildingLevelIdx = this.building_level.SelectedIndex + 1;
           


            draw draw = draw.getInstance(section, buildingLevelIdx);

            draw.MdiParent = this.ParentForm;


            draw.WindowState = FormWindowState.Maximized;
            draw.Show();
            
        }

        private void building_level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
