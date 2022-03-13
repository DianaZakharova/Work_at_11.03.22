using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_at_11._03._22
{
    public partial class MainForm : Form
    {
        private Person selected;

        public MainForm()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            SecondForm frm2 = new SecondForm();
            frm2.FormClosed += Return;
            Hide();
            frm2.ShowDialog();
            Person person = frm2.person;
            DataGridViewRow personRow = new DataGridViewRow();
            personRow.CreateCells(tableINFO);
            string polConvert = person.pol ? "Ж" : "М";
            personRow.SetValues(new object[5] { person.Id, person.surname, person.name, person.dateBirth.ToString("dd.MM.yyyy"), polConvert });
            ToolStripButton contextButton = new ToolStripButton();
            contextButton.Tag = person;
            contextButton.Click += ClickContext;
            contextButton.Text = "Инфо";
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(contextButton);
            personRow.ContextMenuStrip = contextMenu;
            tableINFO.Rows.Add(personRow);
        }

        private void ClickContext(object sender, EventArgs e)
        {
            ToolStripButton buttonSender = (ToolStripButton)sender;
            Person person = (Person)buttonSender.Tag;
            labelNAME.Text = $"Имя и Фамилия:{person.name} {person.surname}";
            if (person.pol)
            {
                POL.Text = "Ж";
            }
            else
            {
                POL.Text = "М";
            }
            Data.Text = person.dateBirth.ToString("dd.MM.yyyy");
            pictureBox.Image = person.image;
            selected = person;

        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                ThirdForm frm3 = new ThirdForm(selected);
                frm3.FormClosed += Return;
                Hide();
                frm3.ShowDialog();

            }
        }

        private void Return(object sender, EventArgs e)
        {
            Show();
        }

    }
}
