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
    public partial class SettingsForms : Form
    {
        int _id;
        int _idRegistration;
        int _idRegion;
        int _idTownRegion;

        public SettingsForms()
        {
            InitializeComponent();
        }

        private void SettingsForms_Load(object sender, EventArgs e)
        {
            SQLConnectionDelete.RefreshTown(this.dataGridView2);
            SQLConnectionDelete.RefreshRegion(this.dataGridView1);

            comboBox1.DataSource = SQLConnectionDelete.ComboRegion();
            comboBox2.DataSource = SQLConnectionDelete.ComboTown();


            comboBox3.DataSource = SQLConnectionDelete.ComboRegion();
            comboBox4.DataSource = SQLConnectionDelete.ComboTown();

            SQLConnectionDelete.SelectTownRegion(this.dataGridView3);

            SQLclassUpdateR.Registration(this.dataGridView4);
        }

        #region Town
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView2.RowCount + 100;
                string _town = textBox6.Text;

                SQLConnectionDelete.InsertTown(i, _town);
                SQLConnectionDelete.RefreshTown(this.dataGridView2);

                comboBox2.DataSource = SQLConnectionDelete.ComboTown();

                comboBox4.DataSource = SQLConnectionDelete.ComboTown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Заполняйте данные правильно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Добавлено!", "Добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox6.Text = null;
            }

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["idT"].Value);
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells["Города"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string _text = textBox5.Text;

                SQLConnectionDelete.UpdateTown(_id, _text);
                SQLConnectionDelete.RefreshTown(this.dataGridView2);
                comboBox2.DataSource = SQLConnectionDelete.ComboTown();

                comboBox4.DataSource = SQLConnectionDelete.ComboTown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Заполняйте данные правильно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Отредактировано!", "Отредактировать", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLConnectionDelete.DeleteTown(_id);
            SQLConnectionDelete.RefreshTown(this.dataGridView2);

            comboBox2.DataSource = SQLConnectionDelete.ComboTown();
            comboBox4.DataSource = SQLConnectionDelete.ComboTown();
        }
        #endregion

        #region Region

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectionDelete.InsertRegion(textBox1.Text);
                SQLConnectionDelete.RefreshRegion(this.dataGridView1);

                comboBox1.DataSource = SQLConnectionDelete.ComboRegion();
                comboBox3.DataSource = SQLConnectionDelete.ComboRegion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Заполняйте данные правильно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Добавлено!", "Добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = null;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _idRegion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idR"].Value);
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Область"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectionDelete.UpdateRegion(_idRegion, textBox2.Text);
                SQLConnectionDelete.RefreshRegion(this.dataGridView1);

                comboBox1.DataSource = SQLConnectionDelete.ComboRegion();
                comboBox3.DataSource = SQLConnectionDelete.ComboRegion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Заполняйте данные правильно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Отредактированно!", "Редактировать", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLConnectionDelete.DeleteRegion(_idRegion);
            SQLConnectionDelete.RefreshRegion(this.dataGridView1);
            comboBox1.DataSource = SQLConnectionDelete.ComboRegion();
            comboBox3.DataSource = SQLConnectionDelete.ComboRegion();
        }

        #endregion

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectionDelete.InsertTownRegion(comboBox2.Text, comboBox1.Text);

                SQLConnectionDelete.SelectTownRegion(this.dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Добавлено!", "Добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectionDelete.DeleteTownRegion(_idTownRegion); 
                SQLConnectionDelete.SelectTownRegion(this.dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Удалено!", "Удалить", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _idTownRegion = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["id"].Value);
            comboBox4.Text = dataGridView3.Rows[e.RowIndex].Cells["Город"].Value.ToString();
            comboBox3.Text = dataGridView3.Rows[e.RowIndex].Cells["Область"].Value.ToString();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnectionDelete.UpdateTownRegion(_idTownRegion, comboBox4.Text, comboBox3.Text);
                SQLConnectionDelete.RefreshRegion(this.dataGridView3);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Заполняйте данные правильно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Отредактированно!", "Редактировать", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void выходИзАдминПанелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormF().Show();
            this.Hide();
        }

        private void SettingsForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLclassInsert.Exit();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OtherForm().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text == textBox4.Text)
                {
                    SQLclassUpdateR.InsertReg(textBox3.Text, textBox9.Text);
                    SQLclassUpdateR.Registration(this.dataGridView4);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error");
            }
            finally
            {
                textBox9.Text=null;
                textBox4.Text=null;
                textBox3.Text = null;                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text == textBox10.Text)
                {
                    SQLclassUpdateR.UpdaterReg(textBox8.Text, textBox7.Text, _idRegistration);
                    SQLclassUpdateR.Registration(this.dataGridView4);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error");
            }
            
        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _idRegistration = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["id"].Value);

            textBox8.Text = dataGridView4.Rows[e.RowIndex].Cells["login"].Value.ToString();
            textBox7.Text = dataGridView4.Rows[e.RowIndex].Cells["password"].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удалить", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SQLclassUpdateR.DeleteReg(_idRegistration);
                    SQLclassUpdateR.Registration(this.dataGridView4);
                }
            }
            catch 
            {
                MessageBox.Show("Упс", "Удалить", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
