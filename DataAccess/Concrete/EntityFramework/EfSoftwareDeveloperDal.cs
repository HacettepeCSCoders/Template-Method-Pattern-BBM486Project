using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSoftwareDeveloperDal : EfEntityRepositoryBase<SoftwareDeveloper,EmployeeContext>,ISoftwareDeveloperDal
    {
        public List<SoftwareDeveloperDto> GetSoftwareDeveloperDetails()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from s in context.SoftwareDevelopers
                    join se in context.SeniorSoftwareDevelopers
                        on s.SeniorId.Value equals se.Id
                    select new SoftwareDeveloperDto()
                    {
                        Id = s.Id,
                        SeniorId = se.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        SeniorName = se.FirstName + " " + se.LastName,
                        Wage = s.Wage.Value
                    };
                return result.ToList();
            }        
        }
    }
}