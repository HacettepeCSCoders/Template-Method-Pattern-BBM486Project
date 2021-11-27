using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<SeniorSoftwareDeveloperDto> GetSeniorSoftwareDeveloperDetails()
        {
            return _seniorSoftwareDeveloperDal.GetSeniorSoftwareDeveloperDetails();
        }

        public void Add(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Add(seniorSoftwareDeveloper);
        }

        public void Update(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Update(seniorSoftwareDeveloper);
        }

        public void Delete(SeniorSoftwareDeveloper seniorSoftwareDeveloper)
        {
            _seniorSoftwareDeveloperDal.Delete(seniorSoftwareDeveloper);
        }

        public SeniorSoftwareDeveloper GetById(int seniorSoftwareDeveloperId)
        {
            return _seniorSoftwareDeveloperDal.Get(j=>j.Id==seniorSoftwareDeveloperId);
        }
    }
}