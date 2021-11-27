using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISoftwareDeveloperService
    {
        List<SoftwareDeveloper> GetAll();
        
        void Add(SoftwareDeveloper softwareDeveloper);
        void Update(SoftwareDeveloper softwareDeveloper);
        void Delete(SoftwareDeveloper softwareDeveloper);
        SoftwareDeveloper GetById(int softwareDeveloperId);
    }
}