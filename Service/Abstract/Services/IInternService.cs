using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface IInternService
    {
        List<Intern> GetAll();
        List<InternDetailDto> GetInternDetails();
        void Add(Intern intern);
        void Update(Intern intern);
        void Delete(Intern intern);
        Intern GetById(int internId);
        void UpdateWage(Intern intern, int workHour);
        
    }
}