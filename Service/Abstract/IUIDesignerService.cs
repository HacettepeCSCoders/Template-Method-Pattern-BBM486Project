using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract
{
    public interface IUIDesignerService
    {
        List<UIDesigner> GetAll();
        List<UIDesignerDto> GetUIDesignerDetails();
        void Add(UIDesigner uıDesigner);
        void Update(UIDesigner uıDesigner);
        void Delete(UIDesigner uıDesigner);
        UIDesigner GetById(int uıDesignerId);
    }
}