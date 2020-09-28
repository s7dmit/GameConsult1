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
    public partial class SpellForm : Form
    {
        public SpellForm()
        {
            InitializeComponent();
        }

        public SpellForm(MenuForm f)
        {
            InitializeComponent();
            //f.BackColor = Color.Yellow;
        }
    }
}
