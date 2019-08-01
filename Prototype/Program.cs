using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer() { CityName = "Alanya", Id = 1, Name = "Murat", SirName = "Kurtboğan" };
            Console.WriteLine(cus1.Name + " " + cus1.SirName);

            Customer cus2 = (Customer)cus1.Clone();
            cus2.Name = "Yasar";
            Console.WriteLine(cus2.Name + " " + cus2.SirName);

            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string Name { get; set; }
        public string SirName { get; set; }

    }

    public class Customer:Person
    {
        public string CityName { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}