using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IInternService
    {
        List<Intern> GetAll();
    }
}