using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName, companyAdress, cPhoneNumber, faxNumber, website, name, suarname, phoneNumber;
            Console.WriteLine("Introduce comany data");
            Console.WriteLine("introduce company name");
            companyName = Console.ReadLine();
            Console.WriteLine("Introduce company adress ");
            companyAdress = Console.ReadLine();
            Console.WriteLine("introduce company phone number");
            cPhoneNumber = Console.ReadLine();
            Console.WriteLine("Introduce faxnumber");
            faxNumber = Console.ReadLine();
            Console.WriteLine("introduce website");
            website = Console.ReadLine();
            Console.WriteLine("introduce manager name");
            name = Console.ReadLine();
            Console.WriteLine("introduce suarename");
            suarname = Console.ReadLine();
            Console.WriteLine("introduce phonenumber");
            phoneNumber = Console.ReadLine();

            Company Company1 = new Company(companyName, companyAdress, cPhoneNumber, faxNumber, website);
            CompanyManager cManager1 = new CompanyManager(name, suarname, phoneNumber);

            Console.WriteLine("company name: " + Company1.companyName + "Adress: " + Company1.companyAdress + "Company phone" + Company1.cPhoneNumber + "Company fax number: " + Company1.faxNumber + "Company website" + Company1.website);
            Console.WriteLine("manager name: " + cManager1.name + "manager suarename: " + cManager1.suarname + "phone number: " + cManager1.phoneNumber);

        }
    }
}
