using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<QAEngineerDto> GetQAEngineerDetails()
        {
            return _qaEngineerDal.GetQAEngineerDetails();
        }

        public void Add(QAEngineer qaEngineer)
        {
            _qaEngineerDal.Add(qaEngineer);
        }

        public void Update(QAEngineer qaEngineer)
        {
            _qaEngineerDal.Update(qaEngineer);
        }

        public void Delete(QAEngineer qaEngineer)
        {
            _qaEngineerDal.Delete(qaEngineer);
        }

        public QAEngineer GetById(int qaEngineerId)
        {
            return _qaEngineerDal.Get(j=>j.Id==qaEngineerId);
        }
    }
}