using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTestEngineerDal : EfEntityRepositoryBase<TestEngineer, EmployeeContext>, ITestEngineerDal
    {
        public List<TestEngineerDto> GetTestEngineerDetails()
        {
            using (var context = new EmployeeContext())
            {
                var result = from s in context.TestEngineers
                    join p in context.ProjectManagers
                        on s.ManagerId.Value equals p.Id
                    select new TestEngineerDto
                    {
                        Id = s.Id,
                        ManagerId = p.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        ManagerName = p.FirstName + " " + p.LastName,
                        Wage = s.Wage.Value
                    };
                return result.ToList();
            }
        }
    }
}