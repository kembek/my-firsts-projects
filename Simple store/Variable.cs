using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARK
{
    public class Variable
    {
        int mainID;

        public int MainID
        {
            get { return mainID; }
            set { mainID = value; }
        }
        
        int id; // id, artikul, countryID

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        int secondID; // townID, catID, artikulID

        public int SecondID
        {
            get { return secondID; }
            set { secondID = value; }
        }
        int unitsID; // unitsID

        public int UnitsID
        {
            get { return unitsID; }
            set { unitsID = value; }
        }
        int price; // price

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        int quantity; // quantity

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        int third; // producerID, buyerID

        public int Third
        {
            get { return third; }
            set { third = value; }
        }
        int statusID; // statusID

        public int StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }
        string name; // cname, uname, sname, coname, tname, nameProd, Bname, Pname

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string data; // dataOF, dataREF

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        string comment; // comment, surname

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        string address; // address

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string email; // email

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string number; // number      

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        string passport;

        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
    }
}
