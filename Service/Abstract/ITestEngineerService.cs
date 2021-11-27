using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ITestEngineerService
    {
        List<TestEngineer> GetAll();
    }
}