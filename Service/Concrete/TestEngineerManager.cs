using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;

namespace Service.Concrete
{
    public class TestEngineerManager:ITestEngineerService
    { 
        ITestEngineerDal _testEngineerDal;
        private TestEngineerWageCalculator _testEngineerWageCalculator = new TestEngineerWageCalculator();
        
        public TestEngineerManager(ITestEngineerDal testEngineerDal)
        {
            _testEngineerDal = testEngineerDal;
        }


        public List<TestEngineer> GetAll()
        {
            return _testEngineerDal.GetAll();
        }

        public List<TestEngineerDto> GetTestEngineerDetails()
        {
            return _testEngineerDal.GetTestEngineerDetails();
        }

        public void Add(TestEngineer testEngineer)
        {
            _testEngineerDal.Add(testEngineer);
        }

        public void Update(TestEngineer testEngineer)
        {
            _testEngineerDal.Update(testEngineer);
        }

        public void Delete(TestEngineer testEngineer)
        {
            _testEngineerDal.Delete(testEngineer);
        }

        public TestEngineer GetById(int testEngineerId)
        {
            return _testEngineerDal.Get(j => j.Id == testEngineerId);
        }
    }
}