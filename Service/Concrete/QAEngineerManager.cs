using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class QAEngineerManager:IQAEngineerService
    {
        IQAEngineerDal _qaEngineerDal;

        public QAEngineerManager(IQAEngineerDal qaEngineerDal)
        {
        
            _qaEngineerDal = qaEngineerDal;
        }
        
        
        public List<QAEngineer> GetAll()
        {
        
            return _qaEngineerDal.GetAll();
        }
    }
}