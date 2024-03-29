﻿namespace Bizer.Extensions.ApplicationService.Abstractions;

/// <summary>
/// 定义查询总数限制的输入。
/// </summary>
public interface IHasTake
{
    /// <summary>
    /// 获取限制查询的记录数。<c>null</c> 表示不限制。
    /// </summary>
    public int? Take { get; }
}
