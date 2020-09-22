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
    public partial class MenuForm : Form
    {
        private static PlayerForm form1;
        private static GameSessionForm form2;
        private static PersonForm form3;
        private static RaceForm form4;
        private static ClassForm form5;
        private static ItemForm form6;
        private static SpellForm form7;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            /*PlayerForm form = new PlayerForm();
            form.MdiParent = MainForm.ActiveForm;
            form.Show();*/

            if (form1 == null || form1.IsDisposed)
            {
                form1 = new PlayerForm();
                form1.MdiParent = MainForm.ActiveForm;
                form1.Show();
            }
            else form1.Activate();
        }

        private void btn2GameSession_Click(object sender, EventArgs e)
        {

            if (form2 == null || form2.IsDisposed)
            {
                form2 = new GameSessionForm();
                form2.MdiParent = MainForm.ActiveForm;
                form2.Show();
            }
            else form2.Activate();
        }

        private void btn3Person_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new PersonForm();
                form3.MdiParent = MainForm.ActiveForm;
                form3.Show();
            }
            else form3.Activate();
        }

        private void btn4Race_Click(object sender, EventArgs e)
        {
            if (form4 == null || form4.IsDisposed)
            {
                form4 = new RaceForm();
                form4.MdiParent = MainForm.ActiveForm;
                form4.Show();
            }
            else form4.Activate();
        }

        private void btn5Class_Click(object sender, EventArgs e)
        {
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new ClassForm();
                form5.MdiParent = MainForm.ActiveForm;
                form5.Show();
            }
            else form5.Activate();
        }

        private void btn6Item_Click(object sender, EventArgs e)
        {
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new ItemForm();
                form6.MdiParent = MainForm.ActiveForm;
                form6.Show();
            }
            else form6.Activate();
        }

        private void btn7Spell_Click(object sender, EventArgs e)
        {
            if (form7 == null || form7.IsDisposed)
            {
                form7 = new SpellForm();
                form7.MdiParent = MainForm.ActiveForm;
                form7.Show();
            }
            else form7.Activate();
        }
    }
}
