using System;
using System.Collections;

namespace ARK.SQL
{
    public class SQL_Product : Foundation 
    {
        public ArrayList GetProduct()
        {
            string query = String.Format("SELECT p.artikul  AS Артикул, p.nameProd AS Название, c.Cname  AS Категория, pr.Pname AS Поставщик, p.price AS Цена, p.quantity  AS Количество, u.Uname AS ЕдИзмер, s.Sname AS Статус, p.dataOF AS Дата, p.comment AS Описание, p.sum  AS Сумма " +
                                         "FROM status s INNER JOIN "+
                                         "(category c INNER JOIN (producer pr INNER JOIN "+
                                         "(units u INNER JOIN product p ON u.id = p.unitsID) "+
                                         "ON pr.id = p.producerID) ON c.id = p.catID) "+
                                         "ON s.id = p.statusID");

            return GetArray(query);
        }

        public bool InsertProduct(Variable v)
        {
            string query = String.Format("INSERT INTO [product]([artikul], [nameProd], [catID], [producerID], [price], [quantity], [unitsID], [statusID], [dataOF], [comment]) "+
                                         "VALUES({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, '{8}', '{9}')", v.Id, v.Name, v.SecondID, v.Third, v.Price, v.Quantity, v.UnitsID, v.StatusID, v.Data, v.Comment);
            
            return SQLQuery(v, query);
        }

        public bool UpdateProduct(Variable v)
        {
            string query = String.Format("UPDATE product "+
                                         "SET artikul={0}, nameProd='{1}', catID={2}, producerID={3}, price={4}, quantity={5}, unitsID={6}, statusID={7}, dataOF='{8}', comment='{9}' "+
                                         "WHERE artikul={10}", v.Id, v.Name, v.SecondID, v.Third, v.Price, v.Quantity, v.UnitsID, v.StatusID, v.Data, v.Comment, v.MainID);

            return SQLQuery(v, query);
        }

        public bool DeleteProduct(Variable v)
        {
            string query = String.Format("DELETE FROM product WHERE artikul={0}", v.Id);

            return SQLQuery(v, query);
        }
    }
}
