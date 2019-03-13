using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBaseBLL
{
    public interface IBaseBLL<T> where T:class,new()
    {
        void Add(T t);

        void DeleteById(int id);

        /// <summary>
        /// 根据条件的 lambda 表达式进行删除
        /// </summary>
        /// <param name="deleteWhere"></param>
        void DeleteByCondition(Expression<Func<T, bool>> deleteWhere);

        void Modify(T entity, params string[] propertyNames);

        T GetById(int id);

        IQueryable<T> GetAll();

        IQueryable<T> GetByCondition(Expression<Func<T, bool>> whereExprssion);

        IQueryable<T> GetByPage<type>(int pageSize, int currentPage, bool isAsc, Expression<Func<T,type>> orderExpression, Expression<Func<T, bool>> whereExpression);

    }
}
