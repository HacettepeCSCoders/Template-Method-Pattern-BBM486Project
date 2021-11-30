using Service.Abstract;

namespace Service.Concrete
{
    public class JuniorSoftwareDeveloperWageCalculator : AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage)
        {
            wage += wage * 50 / 100;
            return wage;
        }

        public override decimal AdditionalShift(decimal wage, int workHour = 0)
        {
            return wage;
        }
    }
}