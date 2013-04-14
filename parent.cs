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
    public partial class parent : Form
    {
        public parent()
        {
            InitializeComponent();
            show_main();
        }

        private void 摇号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_main();
        }

        private void show_main()
        {
            MainForm main_form = MainForm.getInstance();
            load_form(main_form);
        }

        public void load_form(Form form)
        {
            form.MdiParent = this;


            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void 房屋管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            room_list room_list = room_list.getInstance();
            load_form(room_list);
        }

        
    }
}
