using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChooseFI //TODO: Finish me chose data Structure
{
    class DebtStacker
    {
        private List<DebtItem> _debtList = new List<DebtItem>();

        public void ConsoleAddDebtItem()
        {
            Console.Write("\nEnter Company name: ");
            var name = Console.ReadLine();
            Console.Write("\nEnter current balance: ");
            var balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter current monthly payment: ");
            var monthlyPayment = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter current interest rate: ");
            var interestRate = Convert.ToDouble(Console.ReadLine());

            var debt = new DebtItem(name, balance, monthlyPayment, interestRate);
            _debtList.Add(debt);
        }

        public void AddDebtItem(DebtItem debt)
        {
            _debtList.Add(debt);
        }

        public void DisplayList() //TODO: Finish this method
        {

        }

        public IEnumerable<DebtItem> SortList()
        {
            IEnumerable<DebtItem> debtList = _debtList;

            debtList = debtList
                               .OrderBy(d => d.InterestRate)
                               .Reverse();
            Console.WriteLine("\nAfter Sort....\n");
            foreach(var item in debtList)
            {
                Console.WriteLine("{0,-15} {1,-15:C} {2,5}%", item.Name, item.Balance, item.InterestRate);
            }
            return debtList;
        }
    }
}
