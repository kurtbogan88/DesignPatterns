using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleManager saleManager = new SaleManager();
            saleManager.Attach(new CustomerObserver());
            saleManager.Attach(new EmployeObserver());

            saleManager.UpdatePrice();
            Console.ReadLine();
        }

    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Custoemer Observer");
        }
    }


    class EmployeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Employee Observer");
        }
    }
    
    class SaleManager
    {
        List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void UpdatePrice()
        {
            Console.WriteLine("Customer Update");
            Notify();

        }

        private void Notify()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }

}
