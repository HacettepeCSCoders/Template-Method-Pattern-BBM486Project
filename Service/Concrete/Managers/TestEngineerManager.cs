using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class TestEngineerManager : ITestEngineerService
    {
        private readonly ITestEngineerDal _testEngineerDal;
        private readonly TestEngineerWageCalculator _testEngineerWageCalculator = new TestEngineerWageCalculator();

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

        public void UpdateWage(TestEngineer testEngineer, int workHour)
        {
            testEngineer.Wage = _testEngineerWageCalculator.Calculate(workHour);
            _testEngineerDal.Update(testEngineer);
        }
    }
}