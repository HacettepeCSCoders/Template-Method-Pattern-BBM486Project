using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQAEngineerDal : EfEntityRepositoryBase<QAEngineer,EmployeeContext>,IQAEngineerDal
    {
        public List<QAEngineerDto> GetQAEngineerDetails()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from q in context.QAEngineers
                    join p in context.ProjectManagers
                        on q.ManagerId equals p.Id
                    select new QAEngineerDto()
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