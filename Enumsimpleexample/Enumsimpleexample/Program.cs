using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumsimpleexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
           customers[0] = new Customer { Name = "Mark",Gender = Gender.Male};
           customers[1] =  new Customer {Name = "Sonia" ,Gender = Gender.Female};
           customers[2] = new Customer { Name = "stark", Gender = Gender.Unknown };
           foreach (Customer customer in customers)
           {
               Console.WriteLine("Name={0} Gender={1}", customer.Name, getgender(customer.Gender));

           }
         }

        public static string getgender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                case Gender.Unknown:
                     return "Unknown";
               default: 
                    return "invalid gender";


            }


        }
    }

    
    
    
    public enum Gender
    {
        Unknown,
        Male,
        Female

    }
    public class Customer
    {
        private string name;
        public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }

        }
        public Gender Gender { set; get; }

    }
}
