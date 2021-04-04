using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XiangJiang.Orm.Abstractions
{
    /// <summary>
    ///     实体基类
    /// </summary>
    public abstract class ModelBase<TPrimaryKey>
    {
        /// <summary>
        ///     默认构造函数
        /// </summary>
        protected ModelBase()
        {
            CreateTime = DateTime.UtcNow;
            ModifyTime = DateTime.UtcNow;
            Available = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TPrimaryKey Id
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

    public sealed class Person : ModelBase<Guid>
    {
        public string Name { get; set; }
    }
}