using System;
using System.Collections;
using ARK.MyInterface;

namespace ARK.SQL
{
    public class SQL_Sale : Foundation
    {
        public ArrayList GetSale()
        {
            string query = String.Format("SELECT (SELECT product.nameProd FROM product WHERE product.artikul=sale.arktikulID) AS Товар, " +
                                                "sale.price AS Цена, "+
                                                "sale.quantity AS Количество, "+
                                                "sale.Sum AS Сумма, "+
                                                "(SELECT units.Uname FROM units WHERE units.id= sale.unitsID) AS Единица, " +
                                                "(SELECT (buyer.Bname & ' ' & buyer.surname) FROM buyer WHERE buyer.id=sale.buyerID) AS Покупатель, "+
                                                "sale.dataOF AS Дата, "+
                                                "sale.id  AS ID " +
                                         "FROM sale");

            return GetArray(query);
        }

        public ArrayList GetBuyer()
        {
            string query = String.Format("SELECT b.id AS ID, ( [Bname] & ' ' & [surname] ) AS ФИО FROM buyer b");

            return GetArray(query);
        }

        public bool InsertSale(Variable v)
        {
            string query = String.Format(" INSERT INTO [sale]([arktikulID], [price], [quantity], [unitsID], [buyerID], [dataOF]) " +
                                         " VALUES({0}, {1}, {2}, {3}, {4}, '{5}');", v.SecondID, v.Price, v.Quantity, v.UnitsID, v.Third, v.Data);

            string query2 = String.Format("UPDATE product SET product.quantity = IIF({1}> product.quantity, 0, product.quantity-{1})   WHERE product.artikul={0};", v.SecondID, v.Quantity);


            return SQLTransaktion(v, query, query2);
        }

        public bool UpdateSale(Variable v)
        {
            string query = null, query2 = null;
            try
            {
                 query = String.Format(" UPDATE [sale] SET [arktikulID]={0}, [price]={1}, [quantity]={2}, [unitsID]={3}, [buyerID]={4}, [dataOF]='{5}' " +

                                          " WHERE [id] ={6};", v.SecondID, v.Price, v.Quantity, v.UnitsID, v.Third, v.Data, v.MainID);

                 query2 = String.Format("UPDATE product SET product.quantity = IIF({1}> product.quantity, 0, product.quantity-{1})   WHERE product.artikul={0};", v.SecondID, v.Quantity);


            }
            catch (Exception ex)
            {
                new MyButtonClick().Error(ex);
            }
            return SQLTransaktion(v, query, query2);
        }

        public bool DeleteSale(Variable v)
        {
            string query = String.Format("DELETE FROM [sale] WHERE [id]={0}", v.Id);

            return SQLQuery(v, query);
        }
    }
}
