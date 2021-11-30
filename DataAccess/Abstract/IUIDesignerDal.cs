using System.Collections.Generic;
using Core.DataAccess.EntityRepositories;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IUIDesignerDal : IEntityRepository<UIDesigner>
    {
        List<UIDesignerDto> GetUIDesignerDetails();
    }
}