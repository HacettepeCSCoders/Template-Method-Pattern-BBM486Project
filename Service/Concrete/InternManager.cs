using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;

namespace Service.Concrete
{
    public class InternManager:IInternService
    {
        IInternDal _internDal;
        private InternWageCalculator _internWageCalculator = new InternWageCalculator();

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
            return _internDal.Get(i=>i.Id==internId);
        }
    }
}