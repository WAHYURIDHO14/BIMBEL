using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMBEL1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 from = new Form5();
            from.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 from = new Form6();
            from.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();
            from.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 from = new Form10();
            from.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 from = new Form11();
            from.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 from = new Form12();
            from.ShowDialog();
        }
    }
}
