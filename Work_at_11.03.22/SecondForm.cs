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
        private Person person;
        public SecondForm()
        {
            InitializeComponent();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = person.name;
            SurnameBox.Text = person.surname;
            if (Female.Checked)
            {
                Female.Checked = person.pol;
            }
            else
            {
                Male.Checked = person.pol;
            }
            dateTime.Value = person.dateBirth;
        }
    }
}
