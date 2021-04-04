using System;

namespace XiangJiang.Orm.Abstractions
{
    public interface IReadonlyDbContext : IDisposable, IReadonlyRepository
    {
    }
}