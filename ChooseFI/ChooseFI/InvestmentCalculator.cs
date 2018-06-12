namespace ChooseFI
{
    class InvestmentCalculator
    {
        public double Balance { get; set; }
        public double MonthlyContribution { get; set; }
        public int TimeHorizon { get; set; }
        public double InterestRate { get; set; }

        public InvestmentCalculator(double balance, 
                                    double monthlyContribution, 
                                    int timeHorizon,
                                    double interestRate)
        {
            Balance = balance;
            MonthlyContribution = monthlyContribution;
            InterestRate = interestRate;
            TimeHorizon = TimeHorizon;
        }

        public NesteggSnapshot[] SavingsGoal(double amountNeeded, int yearsUntilDone) //TODO
        {
            return new NesteggSnapshot[1];
        }

        public void SimulateUntilRetirement(double contributions, int yearsUntilDone)//TODO
        {
            //... 
        }

    }
}
