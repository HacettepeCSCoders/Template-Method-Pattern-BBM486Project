using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class SoftwareDeveloperManager:ISoftwareDeveloperService
    {
        ISoftwareDeveloperDal _softwareDeveloperDal;

        public SoftwareDeveloperManager(ISoftwareDeveloperDal softwareDeveloperDal)
        {
            _softwareDeveloperDal = softwareDeveloperDal;
        }
        public List<SoftwareDeveloper> GetAll()
        {
            return _softwareDeveloperDal.GetAll();
        }

        public void Add(SoftwareDeveloper softwareDeveloper)
        {
            throw new NotImplementedException();
        }

        public void Update(SoftwareDeveloper softwareDeveloper)
        {
            throw new NotImplementedException();
        }

        public void Delete(SoftwareDeveloper softwareDeveloper)
        {
            throw new NotImplementedException();
        }

        public SoftwareDeveloper GetById(int softwareDeveloperId)
        {
            throw new NotImplementedException();
        }
    }
}