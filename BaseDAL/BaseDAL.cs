using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseDAL
{
   public class BaseDAL<T> where T:class,new()
    {
        protected MyFilaEntities db = new MyFilaEntities();
        public T Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return db.Set<T>().Attach(entity);
        }

        public void DeleteByCondition(Expression<Func<T,bool>> deleteWhere)
        {
            db.Set<T>().RemoveRange(db.Set<T>().Where(deleteWhere));
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            db.Set<T>().Remove(db.Set<T>().Find(id));
            db.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> GetByCondition(Expression<Func<T,bool>> whereExpression)
        {
            return db.Set<T>().Where(whereExpression);
        }

        public IQueryable<T> GetByPage<type>(int pageSize,int currentPage,bool isAsc,Expression<Func<T,type>> orderExpression,Expression<Func<T,bool>> whereExpression)
        {
            if (isAsc)
            {
                return db.Set<T>().Where(whereExpression).OrderBy(orderExpression).Skip((currentPage - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return db.Set<T>().Where(whereExpression).OrderByDescending(orderExpression).Skip((currentPage - 1) * pageSize).Take(pageSize);
            }
        }

        public void Modify(T entity,params string[] propertyNames)
        {
            db.Set<T>().Attach(entity);

            for (int i = 0; i < propertyNames.Length; i++)
            {
                db.Entry(entity).Property(propertyNames[i]).IsModified = true;
            }
            db.SaveChanges();
        }

    }
}
