using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using PropertyApp.FORMS;
using System.Drawing.Printing;
using Ex=Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace PropertyApp
{
    public partial class OtherForm : Form
    {
        string b;
        int secondId;
        string click = null;

        AddOther _openOther;

        public OtherForm()
        {
            InitializeComponent();

            _openOther = new AddOther();

            timer1.Start();
        }

        private void OtherForm_Load(object sender, EventArgs e)
        {
            cmbBx_Region.DataSource = SQLConnectionDelete.ComboRegion();
            cmbBx_Condition.DataSource = SQLConnectionDelete.ComboActive();
            cmbBx_Region.SelectedValueChanged += new EventHandler(cmbBx_Region_SelectedValueChanged);
            dataGridView1.CellEnter += new DataGridViewCellEventHandler(dataGridView1_CellEnter);
            toolStripStatusLabel1.Text = "Форма недвижимости: Готова";
         
        }

                     
        #region ПРОДАЖА
        
        private void bTT_Sale_Click(object sender, EventArgs e)
        {
            SQLclassInsert.RefreshO(this.dataGridView1);
            click = "1";
        }

        #endregion

        #region АРЕНДА

        private void bTT_Rent_Click(object sender, EventArgs e)
        {
            SQLclassUpdateR.RefreshOR(this.dataGridView1);
            click = "2";
        }

        #endregion

        #region Other
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            DateTime _time = DateTime.Now;
            this.label12.Text = _time.ToString("HH:mm:ss tt");

            DateTime _date = DateTime.Today;
            this.label15.Text = _date.Date.ToString("D");
        }

       
        private void cmbBx_Region_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbBx_Town.DataSource = SQLConnectionDelete.ComboTown(SQLConnectionDelete.RegionID(cmbBx_Region.SelectedValue.ToString()));
        }

        
        private void bTT_DeleteSaleOrRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (click != null)
                {
                    DialogResult _diResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (_diResult == DialogResult.OK)
                        SQLConnectionDelete.DeleteOther(secondId);

                   if (b == "Продажа") 
                        SQLclassInsert.RefreshO(this.dataGridView1);
                    if (b == "Аренда") 
                        SQLclassUpdateR.RefreshOR(this.dataGridView1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Delete Ohter!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            secondId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idOth"].Value);
            b = dataGridView1.Rows[e.RowIndex].Cells["Тип"].Value.ToString();

            #region textBox
            txtBx_Header.Text = dataGridView1.Rows[e.RowIndex].Cells["Заголовок"].Value.ToString();
            txtBx_Area.Text = dataGridView1.Rows[e.RowIndex].Cells["Площадь"].Value.ToString();
            txtBx_Seller.Text = dataGridView1.Rows[e.RowIndex].Cells["Продавец"].Value.ToString();

            txtBx_Price.Text = dataGridView1.Rows[e.RowIndex].Cells["Цена"].Value.ToString();
            cmbBx_Region.Text = dataGridView1.Rows[e.RowIndex].Cells["Область"].Value.ToString();
            cmbBx_Town.Text = dataGridView1.Rows[e.RowIndex].Cells["Город"].Value.ToString();

            txtBx_Address.Text = dataGridView1.Rows[e.RowIndex].Cells["Адрес"].Value.ToString();
            cmbBx_Condition.Text = dataGridView1.Rows[e.RowIndex].Cells["Состояние"].Value.ToString();
            txtBx_Number.Text = dataGridView1.Rows[e.RowIndex].Cells["Телефон"].Value.ToString();

            txtBx_Comment.Text = dataGridView1.Rows[e.RowIndex].Cells["Описание"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Тип"].Value.ToString();
            #endregion
        }
        #endregion       

        
        private void bTT_Editing_Click(object sender, EventArgs e)
        {
            try 
            {
                if (click != null)
                {
                    string head = txtBx_Header.Text;
                    int area = Convert.ToInt32(txtBx_Area.Text);
                    int region = cmbBx_Region.SelectedIndex + 1;
                    int town = SQLConnectionDelete.townID(cmbBx_Town.SelectedValue.ToString());
                    string address = txtBx_Address.Text;
                    string whoBuy = txtBx_Seller.Text;
                    int number = Convert.ToInt32(txtBx_Number.Text);
                    string comment = txtBx_Comment.Text;
                    int price = Convert.ToInt32(txtBx_Price.Text);
                    int active = cmbBx_Condition.SelectedIndex + 1;
                    int choose = comboBox1.SelectedIndex + 1;

                    SQLclassUpdateR.UpdateOther(head, area, region, town, address, whoBuy, number, comment, price, active, choose, secondId);

                    if (b == "Продажа") 
                        SQLclassInsert.RefreshO(this.dataGridView1);
                    if (b == "Аренда") 
                        SQLclassUpdateR.RefreshOR(this.dataGridView1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Заполняйте данные правильно!\n"+ ex.ToString(), "Error! Update!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void bTT_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (click != null)
                {
                    int price = Convert.ToInt32(txtBx_Search.Text);

                    if (b == "Продажа") 
                    {
                        int o = 1;
                        SQLConnectionDelete.SearchOther(this.dataGridView1, price, o);
                    }
                    if (b == "Аренда") 
                    {
                        int o = 2;
                        SQLConnectionDelete.SearchOther(this.dataGridView1, price, o);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\n" + ex.ToString(), "Error! Update!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bTT_Add_Click(object sender, EventArgs e)
        {
            _openOther.ShowDialog();
        }

        private void экспортироватьВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                ExcelApp.Cells[1, j + 1] = dataGridView1.Columns[j].HeaderText;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;  

        }
       
        private void tsmi_Settings_Click(object sender, EventArgs e)
        {
            new SettingsForms().Show();
            this.Hide();
        }

        private void выходИзАдминПанелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormF().Show();
            this.Hide();
        }

        private void OtherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SQLclassInsert.Exit();
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void tsmi_Print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            
        }
    }
}