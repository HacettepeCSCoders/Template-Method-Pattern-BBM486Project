using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface ISeniorSoftwareDeveloperService
    {
        List<SeniorSoftwareDeveloper> GetAll();
    }
}