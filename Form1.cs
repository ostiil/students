using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.ShowDialog(this);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            if (Form3.ShowDialog(this) == DialogResult.OK)
            {
                var item = new ListViewItem();
                item.Text = Form3.SurnametextBox.Text;
                item.SubItems.Add(Form3.NametextBox.Text);
                item.SubItems.Add(Form3.LastNametextBox.Text);
                item.SubItems.Add(Form3.GendercomboBox.Text);
              
                item.SubItems.Add(Form3.BirthDayPicker.Value.ToShortDateString());

                var ages = DateTime.Now.Year - Form3.BirthDayPicker.Value.Year;
                item.SubItems.Add(ages.ToString());
                item.SubItems.Add(Form3.AvgUpDown.Value.ToString());
                if(Form3.KickcheckBox.Checked)
                {
                    item.SubItems.Add("Да");
                }
                if (Form3.DutycheckBox.Checked)
                {
                    item.SubItems.Add("Да");
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }
                listView1.Items.Add(item);

            };
        }

        private void DelStudentButton_Click(object sender, EventArgs e)
        {
            var item = listView1.SelectedItems[0];
            if (MessageBox.Show($"Вы точно хотите удалить '{item.Text} {item.SubItems[1]}"))
        }
    }
}
