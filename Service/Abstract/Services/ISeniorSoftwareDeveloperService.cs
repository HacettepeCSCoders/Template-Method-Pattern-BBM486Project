using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface ISeniorSoftwareDeveloperService
    {
        List<SeniorSoftwareDeveloper> GetAll();
        List<SeniorSoftwareDeveloperDto> GetSeniorSoftwareDeveloperDetails();
        void Add(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        void Update(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        void Delete(SeniorSoftwareDeveloper seniorSoftwareDeveloper);
        SeniorSoftwareDeveloper GetById(int seniorSoftwareDeveloperId);
        void UpdateWage(SeniorSoftwareDeveloper seniorSoftwareDeveloper, int workHour);
    }
}