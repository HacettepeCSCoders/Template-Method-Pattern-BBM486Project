using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQAEngineerDal : EfEntityRepositoryBase<QAEngineer, EmployeeContext>, IQAEngineerDal
    {
        public List<QAEngineerDto> GetQAEngineerDetails()
        {
            using (var context = new EmployeeContext())
            {
                var result = from q in context.QAEngineers
                    join p in context.ProjectManagers
                        on q.ManagerId.Value equals p.Id
                    select new QAEngineerDto
                    {
                        Id = q.Id,
                        ManagerId = p.Id,
                        FirstName = q.FirstName,
                        LastName = q.LastName,
                        ManagerName = p.FirstName + " " + p.LastName,
                        Wage = q.Wage.Value
                    };
                return result.ToList();
            }
        }
    }
}