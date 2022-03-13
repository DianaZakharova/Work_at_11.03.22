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
    public partial class ThirdForm : Form
    {
        private Person person;
        public ThirdForm(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void ThirdForm_Load(object sender, EventArgs e)
        {
            IMIA.Text = person.name;
            Familia.Text = person.surname;
            picture.Image = person.image;
            DIAGNOZ.Text = person.diagnoz;
            textBoxHIS.Text = person.history;
        }
    }
}
