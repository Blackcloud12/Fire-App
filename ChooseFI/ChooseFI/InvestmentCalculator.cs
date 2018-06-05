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

        public double SavingsGoal(double amountNeeded, double interestRate, int yearsUntilDone) //TODO
        {
            return 0.0;
        }

        public void SimulateUntilRetirement(double contributions, double InterestRate, int yearsUntilDone)//TODO
        {

        }

    }
}
