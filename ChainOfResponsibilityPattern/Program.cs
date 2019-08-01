using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mng = new ManagerExpense();
            var vice = new VicePresidentExpense();
            var president = new PresidentExpense();

            mng.SetSuccescor(vice);
            vice.SetSuccescor(president);

            mng.Expense(new Expense() { Amount = 1200 });

            Console.ReadLine();
        }
    }

    abstract class ExpenseHandler
    {
        protected ExpenseHandler _succesor;
        public abstract void Expense( Expense expense);

        public void SetSuccescor(ExpenseHandler expenseHandler)
        {
            _succesor = expenseHandler;
        }
    }

    class Expense
    {
        public decimal Amount { get; set; }
    }

    class ManagerExpense : ExpenseHandler
    {
        public override void Expense(Expense expense)
        {
            if (expense.Amount <= 100)
                Console.WriteLine("Manager ok");
            else if (_succesor != null)
                _succesor.Expense(expense);
        }
    }

    class VicePresidentExpense : ExpenseHandler
    {
        public override void Expense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount<=1000)
                Console.WriteLine("Vice ok");
            else if (_succesor != null)
                _succesor.Expense(expense);
        }
    }

    class PresidentExpense : ExpenseHandler
    {
        public override void Expense(Expense expense)
        {
            if (expense.Amount > 1000)
                Console.WriteLine("President ok");
            else if (_succesor != null)
                _succesor.Expense(expense);
        }
    }
}
