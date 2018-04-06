using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQLCategory : Foundation
    {
        public ArrayList GetCategory()
        {
            string query = String.Format("SELECT [id], [cname] FROM [category]");
            return GetArray(query);
        }

        public bool UpdateCategory(Variable v) 
        {
            string query = String.Format("UPDATE [category] SET [cname] = '{0}' WHERE [id] = {1}", v.Name, v.Id);
            return SQLQuery(v, query);
        }
        
        public bool InsertCategory(Variable v)
        {            
            string query = String.Format("INSERT INTO [category]([cname]) VALUES('{0}')", v.Name);
            return SQLQuery(v, query);          
        }

        public bool DeleteCategory(Variable v)
        {            
            string query = String.Format("DELETE FROM [category] WHERE [id]={0}", v.Id);
            return SQLQuery(v, query);
        }
    }
}
