namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     Database context factory.
    /// </summary>
    public interface IDatabaseContextFactory
    {
        /// <summary>
        ///     Create this instance.
        /// </summary>
        /// <returns>The create.</returns>
        IDbContext Create();
    }
}