using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract
{
    public interface ISoftwareDeveloperService
    {
        List<SoftwareDeveloper> GetAll();
        List<SoftwareDeveloperDto> GetSoftwareDeveloperDetails();
        void Add(SoftwareDeveloper softwareDeveloper);
        void Update(SoftwareDeveloper softwareDeveloper);
        void Delete(SoftwareDeveloper softwareDeveloper);
        SoftwareDeveloper GetById(int softwareDeveloperId);
    }
}