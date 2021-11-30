using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInternDal : EfEntityRepositoryBase<Intern, EmployeeContext>, IInternDal
    {
        public List<InternDetailDto> GetInternDetails()
        {
            using (var context = new EmployeeContext())
            {
                var result = from i in context.Interns
                    join s in context.SoftwareDevelopers
                        on i.MentorId.Value equals s.Id
                    select new InternDetailDto
                    {
                        Id = i.Id,
                        MentorId = s.Id,
                        FirstName = i.FirstName,
                        LastName = i.LastName,
                        MentorName = s.FirstName + " " + s.LastName,
                        Wage = i.Wage.Value
                    };
                return result.ToList();
            }
        }
    }
}