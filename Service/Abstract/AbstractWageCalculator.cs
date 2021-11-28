namespace Service.Abstract
{
    public abstract class AbstractWageCalculator
    {
        public decimal MinimumWage()
        {
            return 2729;
        }

        public decimal IndividualPensionShare(decimal wage,int rate=0)
        {
            wage -= wage * rate / 100;
            return wage;
        }

        public abstract decimal BonusShare(decimal wage, int rate=0);
        public abstract decimal AdditionalShift(int workHour=0);
        
        // Template Method
        public  decimal Calculate()
        {
            decimal wage = MinimumWage();
            wage = IndividualPensionShare(wage);
            wage = BonusShare(wage);
            wage += AdditionalShift();
            return wage;
        }
    }
}