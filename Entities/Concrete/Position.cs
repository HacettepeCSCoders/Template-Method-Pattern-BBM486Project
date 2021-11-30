using Core;

namespace Entities.Concrete
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
    }
}