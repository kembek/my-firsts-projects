using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PropertyApp.FORMS
{
    public partial class AddOther : Form
    {
        public AddOther()
        {
            InitializeComponent();
        }

        private void AddOther_Load(object sender, EventArgs e)
        {
            activeComboBox.DataSource = SQLConnectionDelete.ComboRegion();
        }

        private void activeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxTown.DataSource = SQLConnectionDelete.ComboTown(SQLConnectionDelete.RegionID(activeComboBox.SelectedValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string header = textBox2.Text;
                int area = Convert.ToInt32(textBox1.Text);
                int region = activeComboBox.SelectedIndex + 1;
                int town = SQLConnectionDelete.townID(comboBoxTown.SelectedValue.ToString());
                string address = textBoxAddress.Text;
                string whoBuy = textBoxWho.Text;
                int number = Convert.ToInt32(textBoxNumb.Text);
                string comment = textBoxComment.Text;
                int price = Convert.ToInt32(textBoxPrice.Text);
                int active = 2;
                int choose = comboBox1.SelectedIndex + 1;

                SQLclassInsert.InsertOther(header, area, region, town, address, whoBuy, number, comment, price, active, choose);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполняйте данные правильно!\n" + ex.ToString(), "Error!AddOther!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBox2.Text = null;
                textBox1.Text = null;
                textBoxPrice.Text = null;
                textBoxAddress.Text = null;
                textBoxWho.Text = null;
                textBoxNumb.Text = null;
                textBoxComment.Text = null;

                MessageBox.Show("Добавлено!!!", "Добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtherForm _other = new OtherForm();
            SQLclassInsert.RefreshO(_other.dataGridView1);
            this.Close();
        }
    }
}
