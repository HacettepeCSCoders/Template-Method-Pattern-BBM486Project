using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract
{
    public interface IInternService
    {
        List<Intern> GetAll();
        List<InternDetailDto> GetInternDetails();
        void Add(Intern intern);
        void Update(Intern intern);
        void Delete(Intern intern);
        Intern GetById(int internId);
    }
}