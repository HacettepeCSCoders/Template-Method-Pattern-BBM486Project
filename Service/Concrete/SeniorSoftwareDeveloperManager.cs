using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class SeniorSoftwareDeveloperManager:ISeniorSoftwareDeveloperService
    {
        ISeniorSoftwareDeveloperDal _seniorSoftwareDeveloperDal;

        public SeniorSoftwareDeveloperManager(ISeniorSoftwareDeveloperDal seniorSoftwareDeveloperDal)
        {
            _seniorSoftwareDeveloperDal = seniorSoftwareDeveloperDal;
        }
        
        public List<SeniorSoftwareDeveloper> GetAll()
        { 
            return _seniorSoftwareDeveloperDal.GetAll();
        }
    }
}