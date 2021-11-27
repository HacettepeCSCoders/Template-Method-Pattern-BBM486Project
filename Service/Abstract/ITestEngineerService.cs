using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract
{
    public interface ITestEngineerService
    {
        List<TestEngineer> GetAll();
        List<TestEngineerDto> GetTestEngineerDetails();
        void Add(TestEngineer testEngineer);
        void Update(TestEngineer testEngineer);
        void Delete(TestEngineer testEngineer);
        TestEngineer GetById(int testEngineerId);
    }
}