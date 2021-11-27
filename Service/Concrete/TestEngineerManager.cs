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
    }
}