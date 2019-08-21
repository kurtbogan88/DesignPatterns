using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var emp1 = new Model.Emplooye() { Name = "Murat" };
            var emp2 = new Model.Emplooye() { Name = "Ali" };
            var emp3 = new Model.Emplooye() { Name = "Veli" };
            var emp4 = new Model.Emplooye() { Name = "Ahmet" };
            var emp5 = new Model.Emplooye() { Name = "Mehmet" };
            var emp6 = new Model.Emplooye() { Name = "Cevdet" };
            var emp7 = new Model.Emplooye() { Name = "Mahmut" };

            var emp8 = new Model.Emplooye() { Name = "Mehmet" };
            var emp9 = new Model.Emplooye() { Name = "Cevdet" };
            var emp10 = new Model.Emplooye() { Name = "Mahmut" };

            var emp11 = new Model.Emplooye() { Name = "Mahmut" };

            emp1.AddSubOrdinate(emp2);
            emp1.AddSubOrdinate(emp3);
            emp4.AddSubOrdinate(emp4);


            emp5.AddSubOrdinate(emp6);
            emp7.AddSubOrdinate(emp8);
            emp4.AddSubOrdinate(emp4);

            Console.WriteLine(emp1.Name);
            foreach (Model.Emplooye mng in emp1)
            {
                Console.WriteLine(mng.Name);
            }

            Console.ReadLine();
        }

    }
}
