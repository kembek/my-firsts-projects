using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Buyer : Foundation
    {
        public ArrayList GetBuyer()
        {
            string query = String.Format("SELECT b.id AS ID, b.Bname AS Имя, b.surname AS Фамилия, c.coname AS Страна, t.tname AS Город, b.passport AS Паспорт, b.number  AS  Телефон, b.address AS Адрес, b.email  AS ЭлПочта " +

                           "FROM (buyer b INNER JOIN country c ON b.countryID = c.id) INNER JOIN town t ON t.id=b.townID");
            return GetArray(query);
        }

        public bool InsertBuyer(Variable v)
        {
            string query = String.Format("INSERT INTO [buyer]([Bname], [surname], [countryID], [townID], [passport], [number], [address], [email]) " +

                           "VALUES ('{0}', '{1}',  {2}, {3}, '{4}', '{5}', '{6}', '{7}')", v.Name, v.Comment, v.Id, v.SecondID, v.Passport, v.Number, v.Address, v.Email);

            return SQLQuery(v, query);
        }

        public bool UpdateBuyer(Variable v)
        {
            string query = String.Format("UPDATE [buyer] " +

           "SET [Bname]='{0}', [surname]='{1}', [countryID]={2}, [townID]={3}, [passport]='{4}', [number]='{5}', [address]='{6}', [email]='{7}' " +
           "WHERE [id]={8}", v.Name, v.Comment, v.Id, v.SecondID, v.Passport, v.Number, v.Address, v.Email, v.MainID);

            return SQLQuery(v, query);
        }

        public bool DeleteBuyer(Variable v)
        {
            string query = String.Format("DELETE FROM buyer WHERE id={0}", v.MainID);

            return SQLQuery(v, query);
        }

        public ArrayList Search(Variable v)
        {
            string query = String.Format("SELECT b.id AS ID, b.Bname AS Имя, b.surname AS Фамилия, c.coname AS Страна, t.tname AS Город, b.passport AS Паспорт, b.number  AS  Телефон, b.address AS Адрес, b.email  AS ЭлПочта " +

                           "FROM (buyer b INNER JOIN country c ON b.countryID = c.id) INNER JOIN town t ON t.id=b.townID WHERE Имя LIKE '%''{0}''%' AND Фамилия LIKE '%''{1}''%' AND Паспорт LIKE '%''{2}''%'", v.Name, v.Comment, v.Passport);
            return GetArray(query);
        }
    }
}
