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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 from = new Form16();
            from.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 from = new Form17();
            from.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();
            from.ShowDialog();
        }
    }
}
