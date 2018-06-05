
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseFI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\nEnter Expenses: ");
                var expense = Convert.ToDouble(Console.ReadLine());
                var ficalc = new FiCalculator(expense);
                ficalc.DisplayMilestones();

                var debtList = new DebtStacker();
                //string exit = "";
                //while (exit.ToLower() != "exit")
                //{
                //    debtList.ConsoleAddDebtItem();
                //    Console.Write("\nAdd another? type exit to quit. ");
                //    exit = Console.ReadLine();
                //}
                debtList.AddDebtItem(new DebtItem("Citicard", 118.23, 25.00, 11.74));
                debtList.AddDebtItem(new DebtItem("M&T bank", 108484.35, 557.00, 3.5));
                debtList.AddDebtItem(new DebtItem("BestBuy", 987.56, 25.00, 27.99));
                debtList.AddDebtItem(new DebtItem("Tsp Res Loan", 15167.89, 200.00, 1.8));



                debtList.SortList();
            }
            catch (Exception)
            {

                Console.WriteLine("Oops! Something went wrong! Bye.");
            }
            
        }
    }
}
