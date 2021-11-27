using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    
    public interface IQAEngineerService
    {
        
        List<QAEngineer> GetAll();
    }
}