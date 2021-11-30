using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface ISoftwareDeveloperService
    {
        List<SoftwareDeveloper> GetAll();
        List<SoftwareDeveloperDto> GetSoftwareDeveloperDetails();
        void Add(SoftwareDeveloper softwareDeveloper);
        void Update(SoftwareDeveloper softwareDeveloper);
        void Delete(SoftwareDeveloper softwareDeveloper);
        SoftwareDeveloper GetById(int softwareDeveloperId);
        void UpdateWage(SoftwareDeveloper softwareDeveloper, int workHour);
    }
}