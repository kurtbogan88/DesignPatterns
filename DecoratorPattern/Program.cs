using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var personelCar = new PersonalCar() { HirePrice = 1000, Make = "BMW", Model = "3.20" };

            SpecialOffer specialOffer = new SpecialOffer(personelCar)
            {
                DiscountPercent = 20
            };

            Console.WriteLine("Conrete :{0}", personelCar.HirePrice);
            Console.WriteLine("Special offer :{0}", specialOffer.HirePrice);
            Console.ReadLine();
        }

        abstract class CarBase
        {
            public abstract string Make { get; set; }
            public abstract string Model { get; set; }
            public abstract decimal HirePrice { get; set; }
        }

        class PersonalCar : CarBase
        {
            public override string Make { get; set; }
            public override string Model { get; set; }
            public override decimal HirePrice { get; set; }

        }

        class CommerialCar : CarBase
        {
            public override string Make { get; set; }
            public override string Model { get; set; }
            public override decimal HirePrice { get; set; }
        }

        abstract class CarDecoratorBase:CarBase
        {
            private CarBase CarBase;
            protected CarDecoratorBase(CarBase carBase)
            {
                CarBase = carBase;
            }
        }

        class SpecialOffer : CarDecoratorBase
        {
            public int DiscountPercent { get; set; }
            CarBase CarBase;
            public SpecialOffer(CarBase car):base(car)
            {
                CarBase = car;
            }

            public override string Make { get; set; }
            public override string Model { get; set; }
            public override decimal HirePrice { get {
                    return CarBase.HirePrice - (CarBase.HirePrice * DiscountPercent / 100);

                } set { } }
        }
    }
}
