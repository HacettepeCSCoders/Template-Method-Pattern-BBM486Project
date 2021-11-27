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
    public class EfUIDesignerDal : EfEntityRepositoryBase<UIDesigner,EmployeeContext>,IUIDesignerDal
    {
        public List<UIDesignerDto> GetUIDesignerDetails()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from s in context.UIDesigners
                    join p in context.ProjectManagers
                        on s.ManagerId equals p.Id
                    select new UIDesignerDto()
                    {
                        Id = s.Id,
                        ManagerId = p.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        ManagerName = p.FirstName + " " + p.LastName,
                        Wage = s.Wage
                    };
                return result.ToList();
            }        
        }
    }
}