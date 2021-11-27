using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ITestEngineerService
    {
        List<TestEngineer> GetAll();
        
        void Add(TestEngineer testEngineer);
        void Update(TestEngineer testEngineer);
        void Delete(TestEngineer testEngineer);
        TestEngineer GetById(int testEngineerId);
    }
}