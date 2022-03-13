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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void labelPOL_Click(object sender, EventArgs e)
        {

        }

        private void OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки            
            photoCHEL.ImageLocation = FileName;// грузим картинку в pictureBox
        }

        private void NAZ_Click(object sender, EventArgs e)
        {
            MainForm frm5 = new MainForm();
            frm5.Show();
            this.Hide();
        }
    }
}
