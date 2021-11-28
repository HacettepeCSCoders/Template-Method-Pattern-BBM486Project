using Service.Abstract;

namespace Service.Concrete
{
    public class InternWageCalculator:AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage)
        {
            return wage;
        }

        public override decimal AdditionalShift(decimal wage, int workHour = 0)
        {
            return wage;
        }
    }
}