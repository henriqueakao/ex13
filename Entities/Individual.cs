namespace ex13.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000)
            {
                return (0.15 * AnnualIncome) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (0.25 * AnnualIncome) - (HealthExpenditures * 0.5);
            }
        }
    }
}
