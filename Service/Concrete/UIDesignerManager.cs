using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class UIDesignerManager:IUIDesignerService
    {
        IUIDesignerDal _uıDesignerDal;

        public UIDesignerManager(IUIDesignerDal uıDesignerDal)
        {
            _uıDesignerDal = uıDesignerDal;
        }

        public List<UIDesigner> GetAll()
        {
            return _uıDesignerDal.GetAll();
        }
    }
}