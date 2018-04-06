using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Units : Foundation
    {
        public ArrayList GetUnits()
        {
            string query = String.Format("SELECT * FROM units");

            return GetArray(query);
        }

        public bool InsertUnits(Variable v)
        {
            string query = String.Format("INSERT INTO units(Uname) VALUES('{0}')", v.Name);

            return SQLQuery(v, query);
        }

        public bool UpdateUnits(Variable v)
        {
            string query = String.Format("UPDATE units SET Uname='{0}' WHERE id={1}", v.Name, v.Id);

            return SQLQuery(v, query);
        }

        public bool DeleteUnits(Variable v)
        {
            string query = String.Format("DELETE FROM units WHERE id={0}", v.Id);

            return SQLQuery(v, query);
        }
    }
}
