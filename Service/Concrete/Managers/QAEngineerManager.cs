using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class QAEngineerManager : IQAEngineerService
    {
        private readonly IQAEngineerDal _qaEngineerDal;
        private readonly QAEngineerWageCalculator _qaEngineerWageCalculator = new QAEngineerWageCalculator();

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
            return _qaEngineerDal.Get(j => j.Id == qaEngineerId);
        }

        public void UpdateWage(QAEngineer qaEngineer, int workHour)
        {
            qaEngineer.Wage = _qaEngineerWageCalculator.Calculate(workHour);
            _qaEngineerDal.Update(qaEngineer);
        }
    }
}