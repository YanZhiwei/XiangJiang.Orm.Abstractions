using System;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     数据访问层异常类
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class OrmException : Exception
    {
        #region Constructors

        /// <summary>
        ///     构造函数
        /// </summary>
        public OrmException()
        {
        }

        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="message">描述错误的消息。</param>
        public OrmException(string message) : base(message)
        {
        }

        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="inner">内置异常</param>
        public OrmException(string message, Exception inner) : base(message, inner)
        {
        }

        #endregion Constructors
    }
}