using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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
    }
}