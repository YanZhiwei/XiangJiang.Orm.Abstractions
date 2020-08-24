using System;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     实体基类
    /// </summary>
    public class ModelBase
    {
        /// <summary>
        ///     默认构造函数
        /// </summary>
        public ModelBase()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
            ModifyTime = DateTime.Now;
            Available = true;
        }

        /// <summary>
        ///     主键ID
        /// </summary>
        public Guid Id
        {
            get; // int, not null
            set;
        }

        /// <summary>
        ///     记录创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get; // datetime, not null
            set;
        }

        /// <summary>
        ///     记录修改时间
        /// </summary>
        public DateTime ModifyTime
        {
            get; // datetime, not null
            set;
        }

        /// <summary>
        ///     记录是否可用
        /// </summary>
        public bool Available { get; set; }
    }
}