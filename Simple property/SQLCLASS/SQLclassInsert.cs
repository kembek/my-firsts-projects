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
    static public class SQLclassInsert
    {
        static private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PROPERTY.accdb; Persist Security Info=False;");
        static private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        static private OleDbCommand command = new OleDbCommand();

        public static void Exit()
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите выйти из программы?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.ExitThread();
                else
                    Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Problems",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region REFRESH OTHER
        static public void RefreshO(DataGridView _datsGridView)
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT [idOth], [otherT.headerOth] AS Заголовок, [otherT.areaOth] AS Площадь, (SELECT [regionT.regionR] FROM [regionT] WHERE [regionT.idR]=otherT.regionOth) AS Область, (SELECT [townT.townN] FROM [townT] WHERE townT.idT = otherT.townOth) AS Город, [otherT.addressOth] AS Адрес, [otherT.whoBuyOth] AS Продавец, [otherT.numberOth] AS Телефон, [otherT.commentOth] AS Описание, [otherT.price] AS Цена, (SELECT [activeT.active] FROM [activeT] WHERE [activeT.id]= otherT.active) AS Состояние, (SELECT [choose.choose] FROM [choose] WHERE [choose.id]=[chooseID]) AS Тип FROM [otherT] WHERE otherT.chooseID=1;", connection);

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

        #region INSERT Other

        public static void InsertOther(string _header, int _area, int _region, int _town, string _address, string _whoBuy, int _number, string _comment, int _price, int _active, int _choose)
        {
            try
            {
                connection.Open();
                string com = "INSERT INTO [otherT] ([headerOth], [areaOth], [regionOth], [townOth], [addressOth], [whoBuyOth], [numberOth], [commentOth], [price], [active], [chooseID]) VALUES(@headerOth, @areaOth, @regionOth, @townOth, @addressOth, @whoBuyOth, @numberOth, @commentOth, @price, @active, @chooseID)";
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
                command.Parameters.AddWithValue("@chooseID", _choose);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error! INSERT Other!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                connection.Close();
            }
        }

        #endregion
    }

    
}
