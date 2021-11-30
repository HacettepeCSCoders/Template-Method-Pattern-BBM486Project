using Service.Abstract;

namespace Service.Concrete
{
    public class SeniorSoftwareDeveloperWageCalculator : AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage)
        {
            wage += wage * 200 / 100;
            return wage;
        }

        public override decimal AdditionalShift(decimal wage, int workHour = 0)
        {
            if (workHour > 160)
            {
                var addition = workHour - 160;
                wage += addition * 65;
                return wage;
            }

            return wage;
        }
    }
}