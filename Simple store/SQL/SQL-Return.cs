using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Return : Foundation
    {
        public ArrayList GetReturn()
        {
            string query = String.Format("SELECT return.id AS ID, " +
                                                " (SELECT product.nameProd FROM product WHERE product.artikul = return.arktikulID) AS  Товар," +
                                                " return.price AS Цена, " +
                                                " return.quantity AS Количество, " +
                                                " return.sum AS Сумма, " +
                                                " return.dataREF AS Дата, " +
                                                " (SELECT Uname FROM units WHERE units.id=return.unitsID) AS Единица "+
                                         " FROM return");

            return GetArray(query);
        }

        public bool InsertReturn(Variable v)
        {
            string query = String.Format("INSERT INTO return(arktikulID, price, quantity, unitsID, dataREF) VALUES({0}, {1}, {2}, {3}, '{4}');", v.SecondID, v.Price, v.Quantity, v.UnitsID, v.Data);

            string query2 = String.Format("UPDATE product SET product.quantity = IIF({1}> product.quantity, 0, product.quantity+{1})   WHERE product.artikul={0};", v.SecondID, v.Quantity);

            return SQLTransaktion(v, query, query2);
        }

        public bool UpdateReturn(Variable v)
        {
            string query = String.Format("UPDATE return SET arktikulID={0}, price={1}, quantity={2}, unitsID={3}, dataREF='{4}' "+ "WHERE id={5};", v.SecondID, v.Price, v.Quantity, v.UnitsID, v.Data, v.Id);

            string query2 = String.Format("UPDATE product SET product.quantity = IIF({1}> product.quantity, 0, product.quantity+{1})   WHERE product.artikul={0};", v.SecondID, v.Quantity);

            return SQLTransaktion(v, query, query2);
        }

        public bool DeleteReturn(Variable v)
        {
            string query = String.Format("DELETE FROM return WHERE id={0}", v.Id);

            return SQLQuery(v, query);
        }


    }
}
