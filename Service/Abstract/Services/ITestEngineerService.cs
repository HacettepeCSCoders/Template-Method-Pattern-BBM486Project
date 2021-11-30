using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface ITestEngineerService
    {
        List<TestEngineer> GetAll();
        List<TestEngineerDto> GetTestEngineerDetails();
        void Add(TestEngineer testEngineer);
        void Update(TestEngineer testEngineer);
        void Delete(TestEngineer testEngineer);
        TestEngineer GetById(int testEngineerId);
        void UpdateWage(TestEngineer testEngineer, int workHour);
    }
}