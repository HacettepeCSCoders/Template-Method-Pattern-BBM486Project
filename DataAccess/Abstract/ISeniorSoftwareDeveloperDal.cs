using System.Collections.Generic;
using Core.DataAccess;
using Core.DataAccess.EntityRepositories;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ISeniorSoftwareDeveloperDal: IEntityRepository<SeniorSoftwareDeveloper>
    {
        List<SeniorSoftwareDeveloperDto> GetSeniorSoftwareDeveloperDetails();
    }
}