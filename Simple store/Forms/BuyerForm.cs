using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ARK.MyInterface;
using ARK.SQL;
using PrintDataGrid;

namespace ARK.Forms
{
    public partial class BuyerForm : Form
    {
        ArrayList _arr = new ArrayList();

        MyButtonClick _button = new MyButtonClick();
        SQL_Buyer _buyer = new SQL_Buyer();
        addBuyer _addBuyer = new addBuyer();
        SQL_CountryTown _ct = new SQL_CountryTown();
        Variable v = new Variable();
        object _id;

        public BuyerForm()
        {
            InitializeComponent();

            _arr = _buyer.GetBuyer();
            dgv.DataSource = _arr;

            cmbx_country = _ct.GetCountry(cmbx_country);
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (_button.AddButton(sender, e, _addBuyer.ShowDialog() == DialogResult.OK))
            {
                dgv.DataSource = _buyer.GetBuyer();
            }
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                v.MainID = Int32.Parse(_id.ToString());

                if (_button.DeleteButton(sender, e, _buyer.DeleteBuyer(v)))
                {
                    dgv.DataSource = _buyer.GetBuyer();
                }
            }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.DataSource != null)
            {
                _id = (dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                txbx_name.Text = dgv.Rows[e.RowIndex].Cells["Имя"].Value.ToString();
                txbx_surname.Text = dgv.Rows[e.RowIndex].Cells["Фамилия"].Value.ToString();
                cmbx_country.Text = dgv.Rows[e.RowIndex].Cells["Страна"].Value.ToString();
                cmbx_town.Text = dgv.Rows[e.RowIndex].Cells["Город"].Value.ToString();
                txbx_number.Text = dgv.Rows[e.RowIndex].Cells["Телефон"].Value.ToString();
                txbx_address.Text = dgv.Rows[e.RowIndex].Cells["Адрес"].Value.ToString();
                txbx_email.Text = dgv.Rows[e.RowIndex].Cells["ЭлПочта"].Value.ToString();
                txbx_passport.Text = dgv.Rows[e.RowIndex].Cells["Паспорт"].Value.ToString();
            }
        }

        private void btt_rename_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                v.MainID = Int32.Parse(_id.ToString());

                v.Name = txbx_name.Text.Trim();
                v.Comment = txbx_surname.Text.Trim();
                v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
                v.SecondID = Int32.Parse(cmbx_town.SelectedValue.ToString());
                v.Number = txbx_number.Text.Trim();
                v.Passport = txbx_passport.Text.Trim();
                v.Address = txbx_address.Text.Trim();
                v.Email = txbx_email.Text.Trim();


                if (_button.EditButton(sender, e, _buyer.UpdateBuyer(v)))
                {
                    dgv.DataSource = _buyer.GetBuyer();
                }
            }
        }
        
        private void cmbx_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
            cmbx_town = _ct.GetTown(cmbx_town, v);
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyClipboard();
		}

		public void CopyClipboard()
		{
			DataObject d = dgv.GetClipboardContent();
			Clipboard.SetDataObject(d);
		}

        private void tsmi_print_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv);
        }

        List<DataGridViewRow> searchedRows;
        int curRow;
        private void btt_search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            v.Name = txbx_searchName.Text.Trim();
            v.Comment = txbx_searchSurname.Text.Trim();
            v.Passport = txbx_searchPassport.Text.Trim();

            

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (
                    row.Cells["Имя"].FormattedValue.ToString().Contains(v.Name) &&
                    row.Cells["Фамилия"].FormattedValue.ToString().Contains(v.Comment) &&
                    row.Cells["Паспорт"].FormattedValue.ToString().Contains(v.Passport)
                    )
                {
                    searchedRows.Add(row);
                }
            }
            if (searchedRows.Count == 0)
            {
                MessageBox.Show("Поданному запросу не найдено записей", "Склад");
                btt_Next.Enabled = false;
                return;
            }
            MessageBox.Show("Поданному запросу найдено "+ searchedRows.Count +" записей", "Склад");
            btt_Next.Enabled = true;
            curRow =- 1;
            btt_Next_Click(null, null);
        }

        private void btt_Next_Click(object sender, EventArgs e)
        {
            if (curRow == searchedRows.Count - 1)
                curRow = 0;
            else
                curRow++;

            dgv.CurrentCell = searchedRows[curRow].Cells[1];
            
        }

        private void tsmi_export_Click(object sender, EventArgs e)
        {
            Ex(dgv);
        }


        public void Ex(DataGridView _dgv)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int j = 0; j < _dgv.ColumnCount; j++)
                ExcelApp.Cells[1, j + 1] = _dgv.Columns[j].HeaderText;

            for (int i = 0; i < _dgv.Rows.Count; i++)
            {
                for (int j = 0; j < _dgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = _dgv.Rows[i].Cells[j].Value;
                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true; 
        }
    }
}
