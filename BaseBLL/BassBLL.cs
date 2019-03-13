using IBaseBLL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseBLL
{
    public class BassBLL<T> where T:class, new()
    {
        private IBaseDAL<T> dal;

        public void SetDal(IBaseDAL<T> dal)
        {
            this.dal = dal;
        }

        public void Add(T t)
        {
            dal.Add(t);
        }

        public void DeleteById(int id)
        {
            dal.DeleteById(id);
        }

        public void DeleteByCondition(Expression<Func<T, bool>> deleteWhere)
        {
            dal.DeleteByCondition(deleteWhere);
        }

        public void Modify(T entity,params string[] propertyNames)
        {
            dal.Modify(entity, propertyNames);
        }

        public T GetById(int id)
        {
            return dal.GetById(id);
        }

        public IQueryable<T> GetAll()
        {
            return dal.GetAll();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T,bool>> whereExpression)
        {
            return dal.GetByCondition(whereExpression);
        }

        public IQueryable<T> GetByPage<type>(int pageSize,int currentPage,bool isAsc,Expression<Func<T,type> > orderExpression,Expression<Func<T,bool>> whereExpression)
        {
            return dal.GetPage(pageSize, currentPage, isAsc, orderExpression, whereExpression);
        }

    }
}
