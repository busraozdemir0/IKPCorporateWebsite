using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList(int dilId);
        List<T> GetList();
        T TGetById(int id);
        //T TGetById(int id, Expression<Func<T, bool>> filter);
    }
}
