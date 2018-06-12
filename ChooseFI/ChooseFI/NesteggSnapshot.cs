namespace ChooseFI
{
    struct NesteggSnapshot
    {
        double BalanceOverTime { get; set; }
        double ContributionsOverTime { get; set; }
        double GainsSoFar { get; set; }
        int YearsInvested { get; set; }

        public NesteggSnapshot(double balanceOverTime,
                               double contributionsOverTime,
                               double gainsSoFar,
                               int yearsInvested)
        {
            BalanceOverTime = balanceOverTime;
            ContributionsOverTime = contributionsOverTime;
            GainsSoFar = gainsSoFar;
            YearsInvested = yearsInvested;
        }
    }
}
