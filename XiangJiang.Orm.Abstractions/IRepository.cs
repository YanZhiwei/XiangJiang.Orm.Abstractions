using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     标准仓储接口
    /// </summary>
    public interface IRepository
    {
        #region Methods

        /// <summary>
        ///     删除记录
        /// </summary>
        /// <returns>操作是否成功</returns>
        /// <param name="entity">需要操作的实体类.</param>
        bool Delete<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件判断是否存在
        /// </summary>
        /// <returns>是否存在</returns>
        /// <param name="predicate">判断条件委托</param>
        bool Exist<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     根据id获取记录
        /// </summary>
        /// <returns>记录</returns>
        /// <param name="id">id.</param>
        TModelBase GetByKeyId<TPrimaryKey, TModelBase>(object id) where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件获取记录集合
        /// </summary>
        /// <returns>集合</returns>
        /// <param name="predicate">筛选条件.</param>
        List<TModelBase> GetList<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件获取记录第一条或者默认
        /// </summary>
        /// <returns>记录</returns>
        /// <param name="predicate">筛选条件.</param>
        TModelBase GetFirstOrDefault<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     创建一条记录
        /// </summary>
        /// <returns>操作是否成功.</returns>
        /// <param name="entity">实体类记录.</param>
        bool Create<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件查询
        /// </summary>
        /// <returns>IQueryable</returns>
        /// <param name="predicate">筛选条件.</param>
        IQueryable<TModelBase> Query<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     根据记录
        /// </summary>
        /// <returns>操作是否成功.</returns>
        /// <param name="entity">实体类记录.</param>
        bool Update<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        #endregion Methods
    }
}