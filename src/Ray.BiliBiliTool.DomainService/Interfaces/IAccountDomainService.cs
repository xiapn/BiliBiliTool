﻿using System;
using System.Collections.Generic;
using System.Text;
using Ray.BiliBiliTool.Agent.Dtos;

namespace Ray.BiliBiliTool.DomainService.Interfaces
{
    public interface IAccountDomainService : IDomainService
    {
        /// <summary>
        /// 使用Cookie登录
        /// </summary>
        /// <returns></returns>
        UseInfo LoginByCookie();

        /// <summary>
        /// 获取每日任务完成情况
        /// </summary>
        /// <returns></returns>
        DailyTaskInfo GetDailyTaskStatus();
    }
}
