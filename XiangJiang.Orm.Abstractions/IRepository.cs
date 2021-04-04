using System.Threading;
using System.Threading.Tasks;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     标准仓储接口
    /// </summary>
    public interface IRepository : IReadonlyRepository
    {
        #region Methods

        /// <summary>
        ///     删除记录
        /// </summary>
        /// <returns>操作是否成功</returns>
        /// <param name="entity">需要操作的实体类.</param>
        bool Delete<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        Task<bool> DeleteAsync<TPrimaryKey, TModelBase>(TModelBase entity, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;


        /// <summary>
        ///     创建一条记录
        /// </summary>
        /// <returns>操作是否成功.</returns>
        /// <param name="entity">实体类记录.</param>
        bool Create<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        Task<bool> CreateAsync<TPrimaryKey, TModelBase>(TModelBase entity, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;


        /// <summary>
        ///     根据记录
        /// </summary>
        /// <returns>操作是否成功.</returns>
        /// <param name="entity">实体类记录.</param>
        bool Update<TPrimaryKey, TModelBase>(TModelBase entity) where TModelBase : ModelBase<TPrimaryKey>;

        Task<bool> UpdateAsync<TPrimaryKey, TModelBase>(TModelBase entity, CancellationToken token = default)
            where TModelBase : ModelBase<TPrimaryKey>;

        #endregion Methods
    }
}