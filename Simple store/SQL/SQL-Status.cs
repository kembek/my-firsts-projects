using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Status : Foundation
    {
        public ArrayList GetStatus()
        {
            string query = String.Format("SELECT * FROM status");

            return GetArray(query);
        }

        public bool InsertStatus(Variable v)
        {
            string query = String.Format("INSERT INTO status(Sname) VALUES('{0}')", v.Name);

            return SQLQuery(v, query);
        }

        public bool UpdateStatus(Variable v)
        {
            string query = String.Format("UPDATE status SET Sname='{0}' WHERE id={1}", v.Name, v.Id);

            return SQLQuery(v, query);
        }

        public bool DeleteStatus(Variable v)
        {
            string query = String.Format("DELETE FROM status WHERE id={0}", v.Id);

            return SQLQuery(v, query);
        }
    }
}
