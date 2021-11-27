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
    }
}