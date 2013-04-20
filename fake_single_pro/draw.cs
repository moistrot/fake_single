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
    public partial class draw : Form
    {

        private static draw instance;

        public static draw getInstance()
        {
            if (instance == null) 
            {
                instance = new draw();

            }
            return instance;
        }

        public draw()
        {
            InitializeComponent();
        }

        private void password_Click(object sender, EventArgs e)
        {
            if (pwd.Text == "12376")
            {
                room_list form = room_list.getInstance();
                form.MdiParent = this.ParentForm;


                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                MessageBox.Show("密码错误.");
            }
        }
      
    }
}
