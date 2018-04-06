using System;
using System.Collections;
using System.Windows.Forms;

namespace ARK.SQL
{
    class SQL_CountryTown : Foundation
    {
        public ComboBox GetTown(ComboBox _cmb, Variable v)
        {
            string query = String.Format("SELECT ct.townID AS ID, (SELECT t.tname FROM town t WHERE t.id = ct.townID) AS Город " +
                                         "FROM counTown ct WHERE ct.countryID={0}", v.Id);

            _cmb.DataSource = GetArray(query);
            _cmb.DisplayMember = "Город";
            _cmb.ValueMember = "ID";
            return _cmb;
        }

        public ComboBox GetCountry(ComboBox _cmb)
        {
            string query = String.Format("SELECT * FROM country");

            _cmb.DataSource = GetArray(query);
            _cmb.DisplayMember = "coname";
            _cmb.ValueMember = "id";
            return _cmb;
        }

        internal ArrayList GetCountry()
        {
            string query = "SELECT * FROM [country]";
            return GetArray(query);
        }

        internal ArrayList GetTown()
        {
            string query = "SELECT * FROM [town]";
            return GetArray(query);
        }

        internal ListBox GetArrayCT(ListBox lsbx, Variable v)
        {
            string query = String.Format("SELECT (SELECT t.tname FROM town t WHERE t.id = ct.townID) AS Город " +
                                                            "FROM counTown ct WHERE ct.countryID={0}", v.Id);

            lsbx.DataSource = GetArray(query);
            lsbx.DisplayMember = "Город";

            return lsbx;
        }

        // Town
        #region Town
        public bool InsertTown(Variable v)
        {
            string query = String.Format("INSERT INTO [town]([tname]) VALUES('{0}');", v.Name);
            return SQLQuery(v, query);
        }

        public bool UpdateTown(Variable v)
        {
            string query = String.Format("UPDATE [town] SET [tname]='{0}' WHERE [id]={1};", v.Name, v.Id);
            return SQLQuery(v, query);
        }

        public bool DeleteTown(Variable v)
        {
            string query = String.Format("DELETE FROM [town] WHERE [id]={0};", v.Id);
            return SQLQuery(v, query);
        }
        #endregion 

        //Страны
        #region Country
        internal bool InsertCountry(Variable v)
        {
            string query = String.Format("INSERT INTO [country]([coname]) VALUES('{0}');", v.Name);
            return SQLQuery(v, query);
        }

        internal bool UpdateCountry(Variable v)
        {
            string query = String.Format("UPDATE [country] SET [coname]='{0}' WHERE [id]={1};", v.Name, v.Id);
            return SQLQuery(v, query);
        }

        internal bool DeleteCountry(Variable v)
        {
            string query = String.Format("DELETE FROM [country] WHERE [id]={0};", v.Id);
            return SQLQuery(v, query);
        }
        #endregion   

        // Страна - Город
        #region Country - Town
        internal bool InsertCT(Variable v)
        {
            string query = String.Format("INSERT INTO [counTown]([countryID], [townID]) "+
                                         "VALUES('{0}', '{1}');", v.Id, v.SecondID);
            return SQLQuery(v, query);
        }

        internal bool UpdateCT(Variable v)
        {
            string query = String.Format("UPDATE country INNER JOIN (town INNER JOIN counTown ON town.id = counTown.townID) ON country.id = counTown.countryID " +

                                         "SET counTown.countryID= 2, counTown.townID= 2 " +

                                         "WHERE country.coname='{2}' AND town.tname='{3}';", v.Id, v.SecondID, v.Name, v.Number);
            return SQLQuery(v, query);
        }

        internal bool DeleteCT(Variable v)
        {
            string query = String.Format("DELETE counTown FROM counTown LEFT JOIN town ON counTown.townID=town.id " +
                                         "WHERE counTown.countryID={0} AND town.tname='{1}';", v.Id, v.Name);
            return SQLQuery(v, query);
        }
        #endregion
    }
}
