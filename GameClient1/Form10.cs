using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClient1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuForm sideBar = new MenuForm();
            //sideBar.Text = "SideBar";
            sideBar.TopLevel = false;
            //sideBar.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            sideBar.Dock = DockStyle.Left;
            this.Controls.Add(sideBar);

            //PersonForm f1 = new PersonForm();
            //f1.MdiParent = this;

           /* var f2 = new Form();
            f2.Text = "Mdi Child 2";
            f2.MdiParent = this;*/

            sideBar.Show();
           // f1.Show();
            
            //f2.Show();
        }
    }
}
