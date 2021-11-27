using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IJuniorSoftwareDeveloperService
    {
        List<JuniorSoftwareDeveloper> GetAll();

        void Add(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        void Update(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        void Delete(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        JuniorSoftwareDeveloper GetById(int juniorSoftwareDeveloperId);
    }
}