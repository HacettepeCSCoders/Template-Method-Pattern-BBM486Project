﻿using Core.DataAccess.EntityRepositories;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IPositionDal : IEntityRepository<Position>
    {
    }
}