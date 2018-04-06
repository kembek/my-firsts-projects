using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Producer : Foundation
    {
        public ArrayList GetProducer()
        {
            string query = String.Format("SELECT p.id AS ID, p.Pname AS Название, p.surname  AS ПолНаз, c.coname AS Страна, t.tname AS Город, p.number AS Телефон, p.address AS Адрес, p.email  AS ЭлПочта " +

                                         "FROM  town t INNER JOIN (producer p INNER JOIN country c ON c.id=p.countryID) ON t.id=p.townID");
            return GetArray(query);
        }



        public bool InsertProducer(Variable v)
        {
            string query = String.Format("INSERT INTO [producer]([Pname], [surname], [countryID], [townID], [number], [address], [email]) "+
                                         "VALUES('{0}', '{1}',{2}, {3},'{4}','{5}', '{6}')", v.Name, v.Comment, v.Id, v.SecondID, v.Number, v.Address, v.Email);
            return SQLQuery(v, query);
        }

        public bool UpdateProducer(Variable v)
        {
            string query = String.Format("UPDATE [producer] "+
                                         "SET [Pname] ='{0}', [surname]='{1}', [countryID]={2}, [townID]={3}, [number]='{4}', [address]='{5}', [email]='{6}' "+
                                         "WHERE [id]={7}", v.Name, v.Comment, v.Id, v.SecondID, v.Number, v.Address, v.Email, v.MainID);

            return SQLQuery(v, query);
        }

        public bool DeleteProducer(Variable v)
        {
            string query = String.Format("DELETE FROM [producer] WHERE [id]={0}", v.Id);

            return SQLQuery(v, query);
        }
    }
}
