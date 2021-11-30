using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSeniorSoftwareDeveloperDal : EfEntityRepositoryBase<SeniorSoftwareDeveloper, EmployeeContext>,
        ISeniorSoftwareDeveloperDal
    {
        public List<SeniorSoftwareDeveloperDto> GetSeniorSoftwareDeveloperDetails()
        {
            using (var context = new EmployeeContext())
            {
                var result = from s in context.SeniorSoftwareDevelopers
                    join p in context.ProjectManagers
                        on s.ManagerId.Value equals p.Id
                    select new SeniorSoftwareDeveloperDto
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