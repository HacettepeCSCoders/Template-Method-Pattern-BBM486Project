using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISoftwareDeveloperService
    {
        List<SoftwareDeveloper> GetAll();
    }
}