using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class TestEngineerManager:ITestEngineerService
    { 
        ITestEngineerDal _testEngineerDal;

        public TestEngineerManager(ITestEngineerDal testEngineerDal)
        {
            _testEngineerDal = testEngineerDal;
        }


        public List<TestEngineer> GetAll()
        {
            return _testEngineerDal.GetAll();
        }

        public void Add(TestEngineer testEngineer)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TestEngineer testEngineer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TestEngineer testEngineer)
        {
            throw new System.NotImplementedException();
        }

        public TestEngineer GetById(int testEngineerId)
        {
            throw new System.NotImplementedException();
        }
    }
}