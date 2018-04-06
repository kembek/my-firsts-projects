using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using PropertyApp.FORMS;

namespace PropertyApp
{
    public static class SQLConnectionDelete
    {
        static private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PROPERTY.accdb; Persist Security Info=False;");
        static private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        static private OleDbCommand command = new OleDbCommand();

        public static List<string> ComboTown(int _region)
        {
            List<string> _string = new List<string>();
            try
            {
                string text = "SELECT [reg], [town], [townN] FROM [townT] INNER JOIN [overallT] ON townT.idT = overallT.town WHERE [reg]=@reg";
                command = new OleDbCommand(text, connection);
                command.Parameters.AddWithValue("@reg", _region);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                string _town;

                while (reader.Read())
                {
                    _town = reader["townN"].ToString();

                    _string.Add(_town);
                }
                return _string;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        #region ComboBox

        public static List<string> ComboActive()
        {
            List<string> _string = new List<string>();
            try
            {
                string text = "SELECT * FROM [activeT];";
                command = new OleDbCommand(text, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                string _town;

                while (reader.Read())
                {
                    _town = reader["active"].ToString();

                    _string.Add(_town);
                }
                return _string;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public static List<string> ComboRegion()
        {
            List<string> _string = new List<string>();
            try
            {
                string text = "SELECT regionR FROM [regionT];";
                command = new OleDbCommand(text, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                string _town;

                while (reader.Read())
                {
                    _town = reader["regionR"].ToString();

                    _string.Add(_town);
                }
                return _string;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public static int RegionID(string _region)
        {
            int p = 0;
            try
            {
                if (connection != null)
                    connection.Close();
                connection.Open();
                string text = "SELECT [idR] FROM [regionT] WHERE [regionR]='" + _region + "';";
                command = new OleDbCommand(text, connection);

                OleDbDataReader reader = command.ExecuteReader();
                string _id;

                while (reader.Read())
                {
                    p = Convert.ToInt32(_id = reader["idR"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Region ID");
            }
            finally
            {
                connection.Close();
            }
            return p;
        }

        public static int townID(string _town)
        {
            int p = 0;
            try
            {
                connection.Open();
                string text = "SELECT [idT] FROM [townT] WHERE [townN]='" + _town + "';";
                command = new OleDbCommand(text, connection);

                OleDbDataReader reader = command.ExecuteReader();
                string _id;

                while (reader.Read())
                {
                    p = Convert.ToInt32(_id = reader["idT"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
            return p;
        }

        public static List<string> ComboTown()
        {
            List<string> _string = new List<string>();
            try
            {
                string text = "SELECT [townN] FROM [townT];";
                command = new OleDbCommand(text, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                string _town;

                while (reader.Read())
                {
                    _town = reader["townN"].ToString();

                    _string.Add(_town);
                }
                return _string;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error");
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        #endregion

        #region DELETE Other

        public static void DeleteOther(int _id)
        {
            try
            {
                string cmdText = "DELETE FROM [otherT] WHERE [idOth] = @idOth";
                OleDbCommand cmdDelete = new OleDbCommand(cmdText, connection);
                cmdDelete.Parameters.AddWithValue("@idOth", _id);

                connection.Open();
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.ToString(), "Ошибка SQL Delete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Search Other

        public static void SearchOther(DataGridView _dataGridView, int _price, int _choose)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [idOth], [otherT.headerOth] AS Заголовок, [otherT.areaOth] AS Площадь, (SELECT [regionT.regionR] FROM [regionT] WHERE [regionT.idR]=otherT.regionOth) AS Область, (SELECT [townT.townN] FROM [townT] WHERE townT.idT = otherT.townOth) AS Город, [otherT.addressOth] AS Адрес, [otherT.whoBuyOth] AS Продавец, [otherT.numberOth] AS Телефон, [otherT.commentOth] AS Описание, [otherT.price] AS Цена, (SELECT [activeT.active] FROM [activeT] WHERE [activeT.id]= otherT.active) AS Состояние, (SELECT [choose.choose] FROM [choose] WHERE [choose.id]=[chooseID]) AS Тип FROM [otherT] WHERE [price] LIKE '" + _price + "%' AND otherT.chooseID=" + _choose + "", connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
                _dataGridView.Columns["idOth"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region Town

        static public void RefreshTown(DataGridView _datsGridView)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT idT, townN AS Города FROM townT", connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _datsGridView.DataSource = dataTable;
                _datsGridView.Columns["idT"].Visible = false;
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.ToString(), "Ошибка SQL Refresh Town!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertTown(int _id, string _town)
        {
            try
            {
                string com = "INSERT INTO [townT]([idT], [townN]) VALUES('" + _id + "', @townN)";
                command = new OleDbCommand(com, connection);

                command.Parameters.AddWithValue("@townN", _town);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка SQL INSERT Town!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void UpdateTown(int _id, string _town)
        {
            try
            {
                string com = "UPDATE [townT] SET [townN]=@townN WHERE [idT] = " + _id + "";
                command = new OleDbCommand(com, connection);
                command.Parameters.AddWithValue("@townN", _town);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Update Town!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void DeleteTown(int _id)
        {
            try
            {
                string com = "DELETE FROM [townT] WHERE [idT] = " + _id + "";
                command = new OleDbCommand(com, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Delete Town!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region REGION

        static public void RefreshRegion(DataGridView _datsGridView)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT idR, regionR AS Область FROM regionT", connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _datsGridView.DataSource = dataTable;
                _datsGridView.Columns["idR"].Visible = false;
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.ToString(), "Ошибка SQL Refresh Region!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertRegion(string _region)
        {
            try
            {
                string com = "INSERT INTO [regionT]([regionR]) VALUES(@regionR)";
                command = new OleDbCommand(com, connection);

                command.Parameters.AddWithValue("@regionR", _region);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка SQL INSERT Region!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void UpdateRegion(int _id, string _region)
        {
            try
            {
                string com = "UPDATE [regionT] SET [regionR]=@regionR WHERE [idR] = " + _id + "";
                command = new OleDbCommand(com, connection);
                command.Parameters.AddWithValue("@regionR", _region);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Update Region!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void DeleteRegion(int _id)
        {
            try
            {
                string com = "DELETE FROM [regionT] WHERE [idR] = " + _id + "";
                command = new OleDbCommand(com, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Delete Region!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region TownRegion

        static public void SelectTownRegion(DataGridView _dgv)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [id],(SELECT [regionR] FROM [regionT] WHERE [idR]=reg) AS Область, (SELECT [townN] FROM [townT] WHERE [idT]=town) AS Город FROM overallT", connection);

                DataTable _dataTable = new DataTable();
                dataAdapter.Fill(_dataTable);
                _dgv.DataSource = _dataTable;
                _dgv.Columns["id"].Visible = false;
            }
            catch (Exception ex) 
            {
                 MessageBox.Show(ex.ToString(), "Ошибка SQL TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                connection.Close();
            }
        }

        static public void InsertTownRegion(string _town, string _region)
        {
            try
            {
                connection.Open();
                string com = "INSERT INTO [overallT]([town], [reg]) SELECT t.idT, r.idR FROM townT t, regionT r WHERE t.townN='" + _town + "' AND r.regionR='" + _region + "'";

                command = new OleDbCommand(com, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка SQL TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void DeleteTownRegion(int _id)
        {
            try
            {
                string com = String.Format("DELETE FROM [overallT] WHERE [id] ={0}", _id);
                connection.Open();
                command = new OleDbCommand(com, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка SQL TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        static public void UpdateTownRegion(int _id, string _town, string _region)
        {
            try
            {
                string com = "UPDATE [overallT] SET [town]='" + _town + "', [reg]='" + _region + "' WHERE [id]='" + _id + "'";

                connection.Open();
                command = new OleDbCommand(com, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка SQL TOWN REGION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion



    }

  
}