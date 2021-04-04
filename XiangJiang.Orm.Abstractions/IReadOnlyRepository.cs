using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace XiangJiang.Orm.Abstractions
{
    public interface IReadonlyRepository
    {
        /// <summary>
        ///     条件判断是否存在
        /// </summary>
        /// <returns>是否存在</returns>
        /// <param name="predicate">判断条件委托</param>
        bool Exist<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        Task<bool> ExistAsync<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null,
            CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     根据id获取记录
        /// </summary>
        /// <returns>记录</returns>
        /// <param name="id">id.</param>
        TModelBase GetByKeyId<TPrimaryKey, TModelBase>(TPrimaryKey id) where TModelBase : ModelBase<TPrimaryKey>;

        Task<TModelBase> GetByKeyIdAsync<TPrimaryKey, TModelBase>(TPrimaryKey id, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件获取记录集合
        /// </summary>
        /// <returns>集合</returns>
        /// <param name="predicate">筛选条件.</param>
        List<TModelBase> GetList<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        Task<List<TModelBase>> GetListAsync<TPrimaryKey, TModelBase>(
            Expression<Func<TModelBase, bool>> predicate = null, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件获取记录第一条或者默认
        /// </summary>
        /// <returns>记录</returns>
        /// <param name="predicate">筛选条件.</param>
        TModelBase GetFirstOrDefault<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        Task<TModelBase> GetFirstOrDefaultAsync<TPrimaryKey, TModelBase>(
            Expression<Func<TModelBase, bool>> predicate = null, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;

        /// <summary>
        ///     条件查询
        /// </summary>
        /// <returns>IQueryable</returns>
        /// <param name="predicate">筛选条件.</param>
        IQueryable<TModelBase> Query<TPrimaryKey, TModelBase>(Expression<Func<TModelBase, bool>> predicate = null)
            where TModelBase : ModelBase<TPrimaryKey>;

        Task<IQueryable<TModelBase>> QueryAsync<TPrimaryKey, TModelBase>(
            Expression<Func<TModelBase, bool>> predicate = null, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;
    }
}