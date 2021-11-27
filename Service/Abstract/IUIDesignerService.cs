using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IUIDesignerService
    {
        List<UIDesigner> GetAll();
        
        void Add(UIDesigner uıDesigner);
        void Update(UIDesigner uıDesigner);
        void Delete(UIDesigner uıDesigner);
        UIDesigner GetById(int uıDesignerId);
    }
}