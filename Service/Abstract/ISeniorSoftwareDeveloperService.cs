using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISeniorSoftwareDeveloperService
    {
        List<SeniorSoftwareDeveloper> GetAll();
        
        void Add(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        void Update(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        void Delete(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        SeniorSoftwareDeveloper GetById(int seniorSoftwareDeveloperId);
    }
}