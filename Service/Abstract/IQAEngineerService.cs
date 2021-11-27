using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    
    public interface IQAEngineerService
    {
        
        List<QAEngineer> GetAll();
        
        void Add(QAEngineer qaEngineer);
        void Update(QAEngineer qaEngineer);
        void Delete(QAEngineer qaEngineer); 
        QAEngineer GetById(int qaEngineerId);
    }
}