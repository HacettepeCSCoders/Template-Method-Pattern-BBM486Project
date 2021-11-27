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
            throw new System.NotImplementedException();
        }

        public void Update(Intern intern)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Intern intern)
        {
            throw new System.NotImplementedException();
        }

        public Intern GetById(int internId)
        {
            throw new System.NotImplementedException();
        }
    }
}