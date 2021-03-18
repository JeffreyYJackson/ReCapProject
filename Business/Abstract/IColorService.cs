using System.Collections.Generic;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        Color GetById(int id);
        List<Color> GetAll();
    }
}