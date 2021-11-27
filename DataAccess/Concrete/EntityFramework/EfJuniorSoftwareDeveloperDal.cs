using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfJuniorSoftwareDeveloperDal : EfEntityRepositoryBase<JuniorSoftwareDeveloper,EmployeeContext>,IJuniorSoftwareDeveloperDal
    {
        public List<JuniorSoftwareDeveloperDto> GetJuniorSoftwareDeveloperDetails()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from j in context.JuniorSoftwareDevelopers
                    join s in context.SeniorSoftwareDevelopers
                        on j.SeniorId equals s.Id
                    select new JuniorSoftwareDeveloperDto
                    {
                        Id = j.Id,
                        SeniorId = s.Id,
                        FirstName = j.FirstName,
                        LastName = j.LastName,
                        SeniorName = s.FirstName + " " + s.LastName,
                        Wage = j.Wage.Value
                    };
                return result.ToList();
            }
        }
    }
}