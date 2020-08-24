﻿using System.Linq;

namespace XiangJiang.Orm.Abstractions.Helper
{
    /// <summary>
    ///     分页辅助类
    /// </summary>
    public static class PageHelper
    {
        /// <summary>
        ///     基于IQueryable分页扩展
        /// </summary>
        /// <param name="allItems">集合</param>
        /// <param name="pageIndex">分页索引</param>
        /// <param name="pageSize">分页大小</param>
        /// <returns>分页集合</returns>
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> allItems, int pageIndex, int pageSize)
        {
            if (pageIndex < 1) pageIndex = 1;

            var itemOfIndex = (pageIndex - 1) * pageSize;
            var pageOfItems = allItems.Skip(itemOfIndex).Take(pageSize).ToList();
            var totalItemCount = allItems.Count();
            return new PagedList<T>(pageOfItems, pageIndex, pageSize, totalItemCount);
        }
    }
}