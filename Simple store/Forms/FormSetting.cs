using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ARK.SQL;
using ARK.MyInterface;
using System.Collections;

namespace ARK.Forms
{
    public partial class FormSetting : Form
    {
        ArrayList _arr = new ArrayList();

        SQL_CountryTown _ct = new SQL_CountryTown();
        Variable v = new Variable();
        MyButtonClick _buttonClick = new MyButtonClick();

        SQLCategory _category = new SQLCategory();
        SQL_Units _units = new SQL_Units();
        SQL_Status _status = new SQL_Status();

        public FormSetting()
        {
            InitializeComponent();

            _arr = _ct.GetCountry();
            lsbx_Country.DataSource = _arr;

            _arr = _ct.GetCountry();
            lsbx_Country2.DataSource = _arr;

            _arr = _ct.GetTown();
            lsbx_Town.DataSource = _arr;

            _arr = _category.GetCategory();
            lsbx_Category.DataSource = _arr;

            _arr = _units.GetUnits();
            lsbx_units.DataSource = _arr;

            _arr = _status.GetStatus();
            lsbx_status.DataSource = _arr;

            #region ComboBox


            _arr = _ct.GetTown();
            cmbx_addTown.DataSource = _arr;

            _arr = _ct.GetTown();
            cmbx_renameTown.DataSource = _arr;

            #endregion

        }

        #region Country
        private void btt_AddCountry_Click(object sender, EventArgs e)
        {
            v.Name = txbx_addCountry.Text.Trim();

            if (_buttonClick.AddButton(sender, e, _ct.InsertCountry(v)))
            {
                lsbx_Country.DataSource = _ct.GetCountry();
                lsbx_Country2.DataSource = _ct.GetCountry();
                txbx_addCountry.Text = "";
            }
        }

        private void btt_RenameCountry_Click(object sender, EventArgs e)
        {
            if (lsbx_Country.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Country.SelectedValue.ToString());
                v.Name = txbx_renameCountry.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _ct.UpdateCountry(v)))
                {
                    lsbx_Country.DataSource = _ct.GetCountry();
                    lsbx_Country2.DataSource = _ct.GetTown();
                }
            }
        }

        private void btt_DeleteCountry_Click(object sender, EventArgs e)
        {
            if (lsbx_Country.DataSource != null)
            {
                if ((MessageBox.Show("Удалить запись?", "LastCast", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    v.Id = Int32.Parse(lsbx_Country.SelectedValue.ToString());

                    if (_buttonClick.DeleteButton(sender, e, _ct.DeleteCountry(v)))
                    {
                        lsbx_Country.DataSource = _ct.GetCountry();
                        lsbx_Country2.DataSource = _ct.GetCountry();
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void lsbx_Country_SelectedValueChanged(object sender, EventArgs e)
        {
            txbx_renameCountry.Text = lsbx_Country.Text;
        }
        #endregion

        #region TOWN
        private void btt_AddTown_Click(object sender, EventArgs e)
        {
            v.Name = txbx_addTown.Text.Trim();

            if (_buttonClick.AddButton(sender, e, _ct.InsertTown(v)))
            {
                lsbx_Town.DataSource = _ct.GetTown();
                cmbx_renameTown.DataSource = _ct.GetTown();
                cmbx_addTown.DataSource = _ct.GetTown();
                txbx_addTown.Text = "";
            }
        }

        private void btt_renameTown_Click(object sender, EventArgs e)
        {
            if (lsbx_Town.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Town.SelectedValue.ToString());
                v.Name = txbx_renameTown.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _ct.UpdateTown(v)))
                {
                    lsbx_Town.DataSource = _ct.GetTown();
                    cmbx_renameTown.DataSource = _ct.GetTown();
                    cmbx_addTown.DataSource = _ct.GetTown();
                }
            }
        }

        private void btt_deleteTown_Click(object sender, EventArgs e)
        {
            if (lsbx_Town.DataSource != null)
            {
                if ((MessageBox.Show("Удалить запись?", "LastCast", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    v.Id = Int32.Parse(lsbx_Town.SelectedValue.ToString());

                    if (_buttonClick.DeleteButton(sender, e, _ct.DeleteTown(v)))
                    {
                        lsbx_Town.DataSource = _ct.GetTown();
                        cmbx_renameTown.DataSource = _ct.GetTown();
                        cmbx_addTown.DataSource = _ct.GetTown();
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void lsbx_Town_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_renameTown.Text = lsbx_Town.Text;
        }
        #endregion

        #region Country-Town
        private void lsbx_Country2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbx_Country2.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Country2.SelectedValue.ToString());

                _ct.GetArrayCT(lsbx_Town2, v);
            }
        }

        private void lsbx_Town2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_renameTown.Text = lsbx_Town2.Text.Trim();
        }
      
        private void FormSetting_Load(object sender, EventArgs e)
        {
            lsbx_Country2.SelectedIndexChanged += new EventHandler(lsbx_Country2_SelectedIndexChanged);
            lsbx_Town2.SelectedIndexChanged +=new EventHandler(lsbx_Town2_SelectedIndexChanged);
        }

        private void btt_renameCT_Click(object sender, EventArgs e)
        {
            if (lsbx_Country2.DataSource != null
             && cmbx_renameTown.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Country2.SelectedValue.ToString());
                v.SecondID = Int32.Parse(cmbx_renameTown.SelectedValue.ToString());
                v.Name = lsbx_Country2.Text.Trim();
                v.Number = lsbx_Town2.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _ct.UpdateCT(v)))
                {
                    _ct.GetArrayCT(lsbx_Town2, v);
                }

            }
        }

        private void btt_addCT_Click(object sender, EventArgs e)
        {
            v.Id = Int32.Parse(lsbx_Country2.SelectedValue.ToString());
            v.SecondID = Int32.Parse(cmbx_addTown.SelectedValue.ToString());

            if (_buttonClick.AddButton(sender, e,_ct.InsertCT(v)))
            {
                _ct.GetArrayCT(lsbx_Town2, v);
            }
        }

        private void btt_deleteCT_Click(object sender, EventArgs e)
        {
            if (lsbx_Country2.SelectedValue.ToString() != null && lsbx_Town2.Text.ToString() != null)
            {
                    v.Id = Int32.Parse(lsbx_Country2.SelectedValue.ToString());
                    v.Name = lsbx_Town2.Text.Trim().ToString();

                    if (_buttonClick.AddButton(sender, e, _ct.DeleteCT(v)))
                    {
                        _ct.GetArrayCT(lsbx_Town2, v);
                    }
                
            }
        }
        #endregion


        private void btt_addCategory_Click(object sender, EventArgs e)
        {
            v.Name = txbx_addCategory.Text.Trim();

            if (_buttonClick.AddButton(sender, e, _category.InsertCategory(v)))
            {
                lsbx_Category.DataSource = _category.GetCategory();
                txbx_addCategory.Text = "";
            }
        }

        private void btt_renameCategory_Click(object sender, EventArgs e)
        {
            if (lsbx_Category.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Category.SelectedValue.ToString());
                v.Name = txbx_renameCategory.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _category.UpdateCategory(v)))
                {
                    lsbx_Category.DataSource = _category.GetCategory();
                }
            }
        }

        private void btt_deleteCategory_Click(object sender, EventArgs e)
        {
            if (lsbx_Category.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_Category.SelectedValue.ToString());

                if (_buttonClick.DeleteButton(sender, e, _category.DeleteCategory(v)))
                {
                    lsbx_Category.DataSource = _category.GetCategory();
                }
            }
        }

        private void lsbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_renameCategory.Text = lsbx_Category.Text.Trim();
        }

        private void btt_addUnits_Click(object sender, EventArgs e)
        {
            v.Name = txbx_addUnits.Text.Trim();

            if (_buttonClick.AddButton(sender, e, _units.InsertUnits(v)))
            {
                lsbx_units.DataSource = _units.GetUnits();
                txbx_addUnits.Text = "";
            }
        }

        private void lsbx_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_renameUnits.Text = lsbx_units.Text.Trim();
        }

        private void lsbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbx_renameStatus.Text = lsbx_status.Text.Trim();
        }

        private void btt_renameUnits_Click(object sender, EventArgs e)
        {
            if (lsbx_units.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_units.SelectedValue.ToString());
                v.Name = txbx_renameUnits.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _units.UpdateUnits(v)))
                {
                    lsbx_units.DataSource = _units.GetUnits();

                }
            }
        }

        private void btt_deleteUnits_Click(object sender, EventArgs e)
        {
            if (lsbx_units.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_units.SelectedValue.ToString());

                if (_buttonClick.DeleteButton(sender, e, _units.DeleteUnits(v)))
                {
                    lsbx_units.DataSource = _units.GetUnits();
                }
            }
        }

        private void btt_addStatus_Click(object sender, EventArgs e)
        {
            v.Name = txbx_addStatus.Text.Trim();

            if (_buttonClick.AddButton(sender, e, _status.InsertStatus(v)))
            {
                lsbx_status.DataSource = _status.GetStatus();
                txbx_addStatus.Text = "";
            }
        }

        private void btt_renameStatus_Click(object sender, EventArgs e)
        {
            if (lsbx_status.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_status.SelectedValue.ToString());
                v.Name = txbx_renameStatus.Text.Trim();

                if (_buttonClick.EditButton(sender, e, _status.UpdateStatus(v)))
                {
                    lsbx_status.DataSource = _status.GetStatus();
                }
            }
        }

        private void btt_deleteStatus_Click(object sender, EventArgs e)
        {
            if (lsbx_status.DataSource != null)
            {
                v.Id = Int32.Parse(lsbx_status.SelectedValue.ToString());
                if (_buttonClick.DeleteButton(sender, e, _status.DeleteStatus(v)))
                {
                    lsbx_status.DataSource = _status.GetStatus();
                }
            }
        }

        private void продажаВозвратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SRForm().Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProducerForm().Show();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyerForm().Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
