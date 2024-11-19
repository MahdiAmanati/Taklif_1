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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool a;
            Students students = new Students();
            if (comboBox1.Text == "ef")
                a = false;
            else 
                a = true;
            students.halat = a;
            students.ShowDialog();
        }
    }
}
