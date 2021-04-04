using System;
using System.Collections.Generic;
using System.Data;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     数据访问上下文接口
    /// </summary>
    public interface IDbContext : IDisposable, IRepository
    {
        ///// <summary>
        /////     执行Sql 脚本查询
        ///// </summary>
        ///// <param name="sql">Sql语句</param>
        ///// <param name="parameters">参数</param>
        ///// <returns>集合</returns>
        //IEnumerable<T> SqlQuery<T>(string sql, IDbDataParameter[] parameters);
    }
}