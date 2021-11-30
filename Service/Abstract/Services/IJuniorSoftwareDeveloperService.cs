using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface IJuniorSoftwareDeveloperService
    {
        List<JuniorSoftwareDeveloper> GetAll();
        List<JuniorSoftwareDeveloperDto> GetJuniorSoftwareDeveloperDetails();
        void Add(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        void Update(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        void Delete(JuniorSoftwareDeveloper juniorSoftwareDeveloper);

        JuniorSoftwareDeveloper GetById(int juniorSoftwareDeveloperId);
        void UpdateWage(JuniorSoftwareDeveloper juniorSoftwareDeveloper, int workHour);
    }
}