using System;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using System.Data.OleDb;

namespace ARK.SQL
{
    public class Foundation
    {
        public string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LSTDB.accdb;
Persist Security Info=False;";

        public bool SQLQuery(Variable v, string query)
        {
            bool check = true;

            using (OleDbConnection _con = new OleDbConnection(connection))
            {
                try
                {
                    _con.Open();
                    OleDbCommand com = new OleDbCommand(query, _con);
                    com.ExecuteNonQuery();
                    _con.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex, "Склад",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
                return check;
            }
        }

        public ArrayList GetArray(string query)
        {
            ArrayList _arr = new ArrayList();

            try
            {
                using (OleDbConnection _con = new OleDbConnection(connection))
                {
                    _con.Open();

                    OleDbCommand com = new OleDbCommand(query, _con);
                    OleDbDataReader read = com.ExecuteReader();

                    if (read.HasRows)
                        foreach (DbDataRecord result in read)
                        {
                            _arr.Add(result);
                        }
                    else
                    {
                        return null;
                    }
                    _con.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Склад");
            }
            return _arr;
        }

        public bool SQLTransaktion(Variable v, string query, string query2)
        {
            bool check = true;
            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();
                    OleDbTransaction transact = con.BeginTransaction();
                    OleDbCommand com = con.CreateCommand();
                    com.Transaction = transact;

                    try
                    {
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                        com.CommandText = query2;
                        com.ExecuteNonQuery();
                        transact.Commit();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        transact.Rollback();
                        MessageBox.Show("Error\n" + ex, "Склад",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        check = false;
                    }
                    finally
                    {
                        if (con.State == System.Data.ConnectionState.Open)
                            con.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex, "Склад",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            return check;
        }

        public string Count(string query)
        {
            string _result = null;

            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();
                    OleDbCommand _com = new OleDbCommand(query, con);
                    OleDbDataReader _read = _com.ExecuteReader();

                    if (_read.HasRows)
                        foreach (DbDataRecord read in _read)
                            _result = read[0].ToString();

                    con.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error\n", "Склад");
            }
            return _result;
        }
    }
}