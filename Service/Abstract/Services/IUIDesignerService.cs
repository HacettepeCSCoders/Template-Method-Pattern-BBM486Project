using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Service.Abstract.Services
{
    public interface IUIDesignerService
    {
        List<UIDesigner> GetAll();
        List<UIDesignerDto> GetUIDesignerDetails();
        void Add(UIDesigner uiDesigner);
        void Update(UIDesigner uiDesigner);
        void Delete(UIDesigner uiDesigner);
        UIDesigner GetById(int uiDesignerId);
        void UpdateWage(UIDesigner uiDesigner, int workHour);
    }
}