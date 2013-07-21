using FireBirdHelper;

namespace fake_single
{
    partial class parent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Helper helper = Helper.getInstance();
            helper.destroy();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.摇号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房屋管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.摇号ToolStripMenuItem,
            this.房屋管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 摇号ToolStripMenuItem
            // 
            this.摇号ToolStripMenuItem.Name = "摇号ToolStripMenuItem";
            this.摇号ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.摇号ToolStripMenuItem.Text = "摇号";
            this.摇号ToolStripMenuItem.Click += new System.EventHandler(this.摇号ToolStripMenuItem_Click);
            // 
            // 房屋管理ToolStripMenuItem
            // 
            this.房屋管理ToolStripMenuItem.Name = "房屋管理ToolStripMenuItem";
            this.房屋管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.房屋管理ToolStripMenuItem.Text = "房屋管理";
            this.房屋管理ToolStripMenuItem.Click += new System.EventHandler(this.房屋管理ToolStripMenuItem_Click);
            // 
            // parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(785, 499);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房屋选购摇号系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 摇号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房屋管理ToolStripMenuItem;

    }
}