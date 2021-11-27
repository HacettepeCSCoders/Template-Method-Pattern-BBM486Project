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

        public void Add(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public void Update(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public SeniorSoftwareDeveloper GetById(int seniorSoftwareDeveloperId)
        {
            throw new System.NotImplementedException();
        }
    }
}