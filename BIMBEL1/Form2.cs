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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 from = new Form3();
            from.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 from = new Form14();
            from.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 from = new Form3();
            from.ShowDialog();
        }
    }
}
