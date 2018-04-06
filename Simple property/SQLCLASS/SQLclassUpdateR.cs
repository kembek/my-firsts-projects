using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace PropertyApp
{
    static public class SQLclassUpdateR
    {
        static private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PROPERTY.accdb; Persist Security Info=False;");
        static private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        static private OleDbCommand command = new OleDbCommand();       
                            
        #region OTHER RENTALL
        static public void RefreshOR(DataGridView _datsGridView)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [idOth], [otherT.headerOth] AS Заголовок, [otherT.areaOth] AS Площадь, (SELECT [regionT.regionR] FROM [regionT] WHERE [regionT.idR]=otherT.regionOth) AS Область, (SELECT [townT.townN] FROM [townT] WHERE townT.idT = otherT.townOth) AS Город, [otherT.addressOth] AS Адрес, [otherT.whoBuyOth] AS Продавец, [otherT.numberOth] AS Телефон, [otherT.commentOth] AS Описание, [otherT.price] AS Цена, (SELECT [activeT.active] FROM [activeT] WHERE [activeT.id]= otherT.active) AS Состояние, (SELECT [choose.choose] FROM [choose] WHERE [choose.id]=[chooseID]) AS Тип FROM [otherT] WHERE otherT.chooseID=2;", connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _datsGridView.DataSource = dataTable;
                _datsGridView.Columns["idOth"].Visible = false;
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.ToString(), "Ошибка SQL Refresh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region UPDATE OTHER

        public static void UpdateOther(string _header, int _area, int _region, int _town, string _address, string _whoBuy, int _number, string _comment, int _price, int _active, int _choose, int _id)
        {
            try
            {
                string com = "UPDATE [otherT] SET [headerOth] = @headerOth, [areaOth] = @areaOth, [regionOth] = @regionOth, [townOth] = @townOth, [addressOth] = @addressOth, [whoBuyOth] = @whoBuyOth, [numberOth] = @numberOth, [commentOth] = @commentOth, [price] = @price, [active] = @active, [chooseID] = @chooseID WHERE [idOth] = @idOth";
                command = new OleDbCommand(com, connection);
                command.Parameters.AddWithValue("@headerOth", _header);
                command.Parameters.AddWithValue("@areaOth", _area);
                command.Parameters.AddWithValue("@regionOth", _region);
                command.Parameters.AddWithValue("@townOth", _town);
                command.Parameters.AddWithValue("@addressOth", _address);
                command.Parameters.AddWithValue("@whoBuyOth", _whoBuy);
                command.Parameters.AddWithValue("@numberOth", _number);
                command.Parameters.AddWithValue("@commentOth", _comment);
                command.Parameters.AddWithValue("@price", _price);
                command.Parameters.AddWithValue("@active", _active);
                command.Parameters.AddWithValue("@choose", _choose);
                command.Parameters.AddWithValue("@idOth", _id);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Update Other!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        static public void Registration(DataGridView _datsGridView)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [id], [login], [password] FROM [registration]", connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _datsGridView.DataSource = dataTable;
                _datsGridView.Columns["id"].Visible = false;
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.ToString(), "Ошибка SQL Refresh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertReg(string _login, string _password)
        {
            try
            {
                connection.Open();
                string com = "INSERT INTO [registration]([login], [password]) VALUES(@login, @password)";
                command = new OleDbCommand(com, connection);

                command.Parameters.AddWithValue("@login", _login);
                command.Parameters.AddWithValue("@password", _password);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлено", "Добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! INSERT Registration!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdaterReg(string _login, string _password, int _id)
        {
            try
            {
                string com = "UPDATE [registration] SET [login] = @login, [password] = @password WHERE [id] = @id";
                command = new OleDbCommand(com, connection);
                command.Parameters.AddWithValue("@headerOth", _login);
                command.Parameters.AddWithValue("@areaOth", _password);
                command.Parameters.AddWithValue("@id", _id);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Отредактировано", "Редактировать", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! Update Registration!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteReg(int _id)
        {
            try
            {
                string cmdText = "DELETE FROM [registration] WHERE [id] = @id";
                OleDbCommand cmdDelete = new OleDbCommand(cmdText, connection);
                cmdDelete.Parameters.AddWithValue("@id", _id);

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
    }
}
