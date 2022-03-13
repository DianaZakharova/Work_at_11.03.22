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
        public Person person;
        public SecondForm()
        {
            InitializeComponent();
        }

        private void OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFile.FileName;// берем полный адрес картинки            
                photoCHEL.ImageLocation = FileName;// грузим картинку в pictureBox
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            person = new Person(NameBox.Text, SurnameBox.Text, Female.Checked, dateTime.Value, photoCHEL.Image, DiagnoxBox.Text, HistoryBox.Text);
            Close();
        }

    }
}
