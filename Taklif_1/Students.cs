using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taklif_1
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        public bool halat { get; set; }
        private void ButInsert_Click(object sender, EventArgs e)
        {
            if (halat)
            {
                Class1 class1 = new Class1()
                {
                    CodeMeli = TxtCodeMeli.Text,
                    LastName = TxtLastName.Text,
                    Name = TxtName.Text
                };
                class1.InsertAdo();
            }
            else
            {
                Class2 class2 = new Class2()
                {
                    Name = TxtName.Text,
                    LastName = TxtLastName.Text,
                    CodeMeli = TxtCodeMeli.Text
                };
                class2.Insertef();
            }
            Students_Load(null, EventArgs.Empty);
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (halat)
            {
                Class1 class1 = new Class1()
                {
                    CodeMeli = TxtDelete.Text
                };
                class1.deleteAdo();
            }
            else
            {
                Class2 class2 = new Class2()
                {
                    CodeMeli = TxtDelete.Text
                };
                class2.Deleteef();
            }
            Students_Load(null, EventArgs.Empty);
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (halat)
            {
                Class1 class1 = new Class1()
                {
                    CodeMeli = TxtUpdateCode.Text,
                    LastName=TxtUpdateLasteName.Text,
                    Name=TxtUpdateName.Text
                };
                class1.UpdateAdo();
            }
            else
            {
                Class2 class2 = new Class2()
                {
                    CodeMeli = TxtUpdateCode.Text,
                    LastName = TxtUpdateLasteName.Text,
                    Name = TxtUpdateName.Text
                };
                class2.Updateef();
            }
            Students_Load(null, EventArgs.Empty);
        }

        private void Students_Load(object sender, EventArgs e)
        {
            if (halat)
            {
                Class1 class1 = new Class1();
                dataGridView1.DataSource = class1.SelectAdo();
            }
            else
            {
                Class2 class2 = new Class2();
                dataGridView1.DataSource = class2.Selectef();
            }
        }
    }
}
