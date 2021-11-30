using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface IQAEngineerService
    {
        List<QAEngineer> GetAll();
        List<QAEngineerDto> GetQAEngineerDetails();
        void Add(QAEngineer qaEngineer);
        void Update(QAEngineer qaEngineer);
        void Delete(QAEngineer qaEngineer);
        QAEngineer GetById(int qaEngineerId);
        void UpdateWage(QAEngineer qaEngineer, int workHour);
    }
}