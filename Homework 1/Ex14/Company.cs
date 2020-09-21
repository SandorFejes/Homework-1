using System;
using System.Collections.Generic;
using System.Text;

namespace Ex14
{
    class Company
    {
        public string companyName;
        public string companyAdress;
        public string cPhoneNumber;
        public string faxNumber;
        public string website;
        public Company(string name, string addres, string aPhoneNumber, string aFaxNumber, string aWebsite)
        {
            companyName = name;
            companyAdress = addres;
            cPhoneNumber = aPhoneNumber;
            faxNumber = aFaxNumber;
            website = aWebsite;

        }
    }
   
}
