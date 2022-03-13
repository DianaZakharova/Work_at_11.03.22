using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_at_11._03._22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            SecondForm frm2 = new SecondForm();
            frm2.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            ThirdForm frm3 = new ThirdForm();
            frm3.Show();
            this.Hide();
        }
    }
}
