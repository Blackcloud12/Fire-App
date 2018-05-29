using System;
using System.Collections.Generic;
using System.Linq;

namespace ChooseFI
{
    class DebtItem : IComparable
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double MonthlyPayment { get; set; }
        public double InterestRate { get; set; }

        public DebtItem(string name, double balance, double monthlyPayment, double interestRate)
        {
            Name = name;
            Balance = balance;
            MonthlyPayment = monthlyPayment;
            InterestRate = interestRate;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            var otherDebtItem = obj as DebtItem;
            if (otherDebtItem == null)
                throw new ArgumentException("Other object isn't a DebtItem object");

            if (this.InterestRate == otherDebtItem.InterestRate)
                return 0;

            return this.InterestRate > otherDebtItem.InterestRate ? 1 : -1;
        }
    }
}
