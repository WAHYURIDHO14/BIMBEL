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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 from = new Form13();
            from.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 from = new Form15();
            from.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2();
            from.ShowDialog();
        }
    }
}
