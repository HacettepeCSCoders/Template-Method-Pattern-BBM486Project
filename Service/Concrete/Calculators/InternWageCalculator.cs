using Service.Abstract;

namespace Service.Concrete
{
    public class InternWageCalculator:AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage = 0, int rate = 0)
        {
            return wage;
        }

        public override decimal AdditionalShift(int workHour = 0)
        {
            return 0;
        }
    }
}