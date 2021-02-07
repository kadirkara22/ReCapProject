using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color> {
            new Color{ ColorId=1,ColorName="Siyah"},
            new Color{ ColorId=2,ColorName="Beyaz"},
            new Color{ ColorId=3,ColorName="Kırmızı"},
            new Color{ ColorId=4,ColorName="Mavi"},
            new Color{ ColorId=5,ColorName="Sarı"},
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
          Color deleteToColor=_colors.SingleOrDefault(x => x.ColorId == entity.ColorId);
            _colors.Remove(deleteToColor);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colors;
        }

        public void Update(Color entity)
        {
          Color updateToColor=_colors.SingleOrDefault(x => x.ColorId == entity.ColorId);
            updateToColor.ColorName = entity.ColorName;
        }
    }
}
