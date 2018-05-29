using System;
using System.Collections.Generic;

namespace ChooseFI
{
    class FiCalculator
    {
        private readonly double monthlyExpenses;

        public FiCalculator(double monthlyExpenses)
        {
            this.monthlyExpenses = monthlyExpenses;
        }

        // Calculate MileStones of Fi
        //EF(3-6mo expenses), FU(12-24mo expenses)
        //LeanFi(25 expenses)
        //FlexFi(20y), FullFi(25y), FatFi(30y)
        public List<double> CalculateFiMileStones()
        {
            var monthlyMultiplierList = new List<double> { 3, 6, 12, 24};
            var yearlyMultiplierList = new List<double> { 20, 25, 30};
            var milestoneList = new List<double>();
            foreach (var multipier in monthlyMultiplierList)
            {
                milestoneList.Add(monthlyExpenses * multipier);
            }
            foreach (var multipier in yearlyMultiplierList)
            {
                milestoneList.Add(monthlyExpenses * 12 * multipier);
            }
            return milestoneList;
        }

        public void DisplayMilestones()
        {
            var milestoneList = CalculateFiMileStones();
            List<string> MileStoneLabelsList = new List<string> {
                                                              "Emergencey",
                                                              "FU Money",
                                                              "Flex Fi",
                                                              "Full Fi",
                                                              "Fat Fi"
                                                            };
            for (int i = 0; i < MileStoneLabelsList.Count; i++)
            {
                if (i<=1)
                {
                    Console.WriteLine("{0}: \t\t\t{1:C} - {2:C}", MileStoneLabelsList[i], milestoneList[i], milestoneList[i+1]);
                }
                else
                    Console.WriteLine("{0}: \t\t\t{1:C}", MileStoneLabelsList[i], milestoneList[i+2]);
                
            }
        }
    }
}
