using System.Collections.Generic;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class JuniorSoftwareDeveloperManager:IJuniorSoftwareDeveloperService
    {
        IJuniorSoftwareDeveloperDal _juniorSoftwareDeveloperDal;

        public JuniorSoftwareDeveloperManager(IJuniorSoftwareDeveloperDal juniorSoftwareDeveloperDal)
        {
            _juniorSoftwareDeveloperDal = juniorSoftwareDeveloperDal;
        }
        
        
        public List<JuniorSoftwareDeveloper> GetAll()
        {
            return _juniorSoftwareDeveloperDal.GetAll();
        }

        public void Add(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public void Update(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(JuniorSoftwareDeveloper juniorSoftwareDeveloper)
        {
            throw new System.NotImplementedException();
        }

        public JuniorSoftwareDeveloper GetById(int juniorSoftwareDeveloperId)
        {
            throw new System.NotImplementedException();
        }
    }
}