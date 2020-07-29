// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel;

namespace UrlInterceptor.Ip
{
    /// <summary>
    /// Ip限制
    /// </summary>
    public class IpOptions
    {
        /// <summary>
        /// ip规则类型
        /// </summary>
        public IpRuleType RuleType { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Tip { get; set; }

        /// <summary>
        /// Ip集合
        /// </summary>
        public List<string> IpList { get; set; }

        /// <summary>
        /// 得到提示信息
        /// </summary>
        /// <returns></returns>
        internal string GetTip()
        {
            if (!string.IsNullOrEmpty(Tip))
            {
                return Tip;
            }

            if (RuleType == IpRuleType.Black)
            {
                return "触发黑名单限制";
            }

            return "暂不支持白名单外的ip访问";
        }
    }

    /// <summary>
    /// Ip规则类型
    /// </summary>
    public enum IpRuleType
    {
        /// <summary>
        /// 白名单
        /// </summary>
        [Description("白名单")] White = 1,

        /// <summary>
        /// 黑名单
        /// </summary>
        [Description("黑名单")] Black = 2
    }
}
