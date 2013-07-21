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
    public partial class draw : Form
    {

        public String range = "default";

        public SECTION section = null;

        public RoomBean final = null;

        private List<RoomBean> ava = null; //显示的可摇列表
        private List<RoomBean> ava_true = null;//真正可要列表
        private List<RoomBean> already = null; //已摇列表
        

        private string[] room_nums = new string[] 
        {
        };
        private int i = 0;

        private static draw instance;

        public static draw getInstance(SECTION section)
        {
            if (instance != null) 
            {
                instance.Dispose();

            }
            instance = new draw(section);
            return instance;
        }

        public draw(SECTION section)
        {
            InitializeComponent();
            target_box.TextAlign = HorizontalAlignment.Center;
            init_room_list(section);
            this.section = section;
            this.range_show.Text = section.toString();
            this.label2.Hide();
            this.button2.Hide();
            this.do_save.Hide();
            this.cancel.Hide();
        }

        public void init_room_list(SECTION section)
        {
            Helper helper = Helper.getInstance();
            ava = helper.find(section.getMin(), section.getMax(), -1, 0, 0, 0);
            already = helper.find(section.getMin(), section.getMax(), -1, 1, 0, 0); //
            ava_true = helper.find(section.getMin(), section.getMax(), 0, 0, 0, 0);

            this.label3.Text = "此区间已经摇出" + already.Count + "套，还剩" + ava.Count + "套";
            Console.WriteLine(ava.Count + " " + ava_true.Count + " " + already.Count);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void target_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == ava.Count)
            {
                i = 0;
            }
            Random random = new Random();
            i = random.Next(ava.Count);
            this.target_box.Text = ava[i].getString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Show();
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Hide();
            button1.Hide();
            
            label2.Show();
            final = random();
            //todo: final初始化
            this.target_box.Text = final.getString();
            textBox1.Text = final.getDisplay();
            this.do_save.Show();
            this.cancel.Show();
        }

        private RoomBean random()
        {
            Random random = new Random();
            int i = random.Next(ava_true.Count);
            return ava_true[i];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void do_save_Click(object sender, EventArgs e)
        {
            this.do_save.Hide();
            this.cancel.Hide();
            // do save data to DB
            Helper helper = Helper.getInstance();
            final.setIsToken(1);
            helper.update(final);

            clean();
            this.button1.Show();
            init_room_list(this.section);
            
        }

        private void clean()
        {
            this.target_box.Text = "房号";
            this.label2.Hide();
            this.textBox1.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.do_save.Hide();
            this.cancel.Hide();
            // do not save data to DB

            clean();
            this.button1.Show();
        }

        private void choose_range_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
