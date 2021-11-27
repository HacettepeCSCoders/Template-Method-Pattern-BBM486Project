using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IUIDesignerService
    {
        List<UIDesigner> GetAll();
    }
}