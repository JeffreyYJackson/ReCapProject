using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color:Entity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}