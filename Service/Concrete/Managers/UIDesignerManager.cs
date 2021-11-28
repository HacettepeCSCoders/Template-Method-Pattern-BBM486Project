using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Service.Abstract;
using Service.Abstract.Services;

namespace Service.Concrete.Managers
{
    public class UIDesignerManager:IUIDesignerService
    {
        IUIDesignerDal _uiDesignerDal;
        private UIDesignerWageCalculator _uiDesignerWageCalculator = new UIDesignerWageCalculator();
        
        public UIDesignerManager(IUIDesignerDal uiDesignerDal)
        {
            _uiDesignerDal = uiDesignerDal;
        }

        public List<UIDesigner> GetAll()
        {
            return _uiDesignerDal.GetAll();
        }

        public List<UIDesignerDto> GetUIDesignerDetails()
        {
            return _uiDesignerDal.GetUIDesignerDetails();
        }

        public void Add(UIDesigner uiDesigner)
        {
            _uiDesignerDal.Add(uiDesigner);
        }

        public void Update(UIDesigner uiDesigner)
        {
            _uiDesignerDal.Update(uiDesigner);
        }

        public void Delete(UIDesigner uiDesigner)
        {
            _uiDesignerDal.Delete(uiDesigner);
        }

        public UIDesigner GetById(int uiDesigner)
        {
            return _uiDesignerDal.Get(j => j.Id == uiDesigner);
        }
        public void UpdateWage(UIDesigner uiDesigner, int workHour)
        {
            uiDesigner.Wage = _uiDesignerWageCalculator.Calculate(workHour);
            _uiDesignerDal.Update(uiDesigner);
        }
    }
}