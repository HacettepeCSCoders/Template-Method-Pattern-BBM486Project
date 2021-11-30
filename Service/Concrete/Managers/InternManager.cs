using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class InternManager : IInternService
    {
        private readonly IInternDal _internDal;
        private readonly InternWageCalculator _internWageCalculator = new InternWageCalculator();

        public InternManager(IInternDal internDal)
        {
            _internDal = internDal;
        }

        public List<Intern> GetAll()
        {
            return _internDal.GetAll();
        }

        public List<InternDetailDto> GetInternDetails()
        {
            return _internDal.GetInternDetails();
        }

        public void Add(Intern intern)
        {
            _internDal.Add(intern);
        }

        public void Update(Intern intern)
        {
            _internDal.Update(intern);
        }

        public void Delete(Intern intern)
        {
            _internDal.Delete(intern);
        }

        public Intern GetById(int internId)
        {
            return _internDal.Get(i => i.Id == internId);
        }

        public void UpdateWage(Intern intern, int workHour)
        {
            intern.Wage = _internWageCalculator.Calculate(workHour);
            _internDal.Update(intern);
        }
    }
}