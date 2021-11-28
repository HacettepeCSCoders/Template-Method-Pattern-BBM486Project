using Service.Abstract;

namespace Service.Concrete
{
    public class SoftwareDeveloperWageCalculator:AbstractWageCalculator
    {
        public override decimal BonusShare(decimal wage, int rate = 0)
        {
            throw new System.NotImplementedException();
        }

        public override decimal AdditionalShift(int workHour = 0)
        {
            throw new System.NotImplementedException();
        }
    }
}