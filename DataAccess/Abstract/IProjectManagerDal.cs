﻿using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProjectManagerDal: IEntityRepository<ProjectManager>
    {
    }
}