using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.Common;

namespace ARK.SQL
{
    public class SQL_ADDITIONAL : Foundation 
    {
        public string ProductCount()
        {
            string query = "SELECT COUNT([artikul]) FROM product;";

            return Count(query);
        }

        public string BuyerCount()
        {
            string query = "SELECT COUNT(id) FROM buyer;";

            return Count(query);
        }

        public string SaleCount()
        {
            string query = "SELECT COUNT(id) FROM sale;";

            return Count(query);
        }

        public string ReturnCount()
        {
            string query = "SELECT COUNT(id) FROM return;";

            return Count(query);
        }

        public string ProducerCount()
        {
            string query = "SELECT COUNT(id) FROM producer;";

            return Count(query);
        }
    }
}
