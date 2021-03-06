using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color> {
            new Color{ Id=1,ColorName="Siyah"},
            new Color{ Id=2,ColorName="Beyaz"},
            new Color{ Id=3,ColorName="Kırmızı"},
            new Color{ Id=4,ColorName="Mavi"},
            new Color{ Id=5,ColorName="Sarı"},
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
          Color deleteToColor=_colors.SingleOrDefault(x => x.Id == entity.Id);
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
          Color updateToColor=_colors.SingleOrDefault(x => x.Id == entity.Id);
            updateToColor.ColorName = entity.ColorName;
        }
    }
}
