﻿using System.Collections.Generic;
using Core.DataAccess.EntityRepositories;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ISystemAnalystDal : IEntityRepository<SystemAnalyst>
    {
        List<SystemAnalystDto> GetSystemAnalystDetails();
    }
}