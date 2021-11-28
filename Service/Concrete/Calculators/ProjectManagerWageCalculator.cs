using Service.Abstract;

namespace Service.Concrete
{
    public class ProjectManagerWageCalculator:AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage)
        {
            wage += wage * 300 / 100;
            return wage;
        }

        public override decimal AdditionalShift(decimal wage, int workHour = 0)
        {
            if (workHour > 160)
            {
                int addition = workHour - 160;
                wage += addition * 80;
                return wage;
            }

            return wage;
        }
    }
}