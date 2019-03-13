using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// IDAL 层所有接口的父接口，定义 基础的crud操作
    /// IBaseDAL<T> where T :class,new() 代表T类型必须是引用类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDAL<T> where T:class ,new()
    {
        T Add(T user);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        void DeleteById(int id);

        /// <summary>
        /// 根据条件的lambda表达式进行删除
        /// </summary>
        /// <param name="deleteWhere"></param>
        void DeleteByCondition(Expression<Func<T, bool>> deleteWhere);

        void Modify(T entity, params string[] propertyNames);
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// 根据id查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// 根据条件查找
        /// </summary>
        /// <param name="whereExpression"></param>
        /// <returns></returns>
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> whereExpression);

        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="isAsc"></param>
        /// <param name="orderExpression"></param>
        /// <param name="whereExpression"></param>
        /// <returns></returns>
        IQueryable<T> GetPage<type>(int pageSize, int currentPage, bool isAsc, Expression<Func<T, type>> orderExpression, Expression<Func<T, bool>> whereExpression);
    }
}
