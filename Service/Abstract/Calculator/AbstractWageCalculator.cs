namespace Service.Abstract
{
    public abstract class AbstractWageCalculator
    {
        public decimal MinimumWage(int workHour)
        {
            if (workHour >= 160)
            {
                return 2729;
            }

            return 0;
        }

        public decimal IndividualPensionShare(decimal wage)
        {
            wage -= wage * 3 / 100;
            return wage;
        }

        public abstract decimal BonusShare(decimal wage);
        public abstract decimal AdditionalShift(decimal wage, int workHour=0);
        
        // Template Method
        public  decimal Calculate(int workHour)
        {
            decimal wage = MinimumWage(workHour);
            wage = BonusShare(wage);
            wage = AdditionalShift(wage, workHour);
            wage = IndividualPensionShare(wage);
            return wage;
        }
    }
}