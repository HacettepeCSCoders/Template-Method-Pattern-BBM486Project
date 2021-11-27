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

        public void Add(QAEngineer qaEngineer)
        {
            throw new System.NotImplementedException();
        }

        public void Update(QAEngineer qaEngineer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(QAEngineer qaEngineer)
        {
            throw new System.NotImplementedException();
        }

        public QAEngineer GetById(int qaEngineerId)
        {
            throw new System.NotImplementedException();
        }
    }
}