// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace UrlInterceptor.Common
{
    /// <summary>
    /// 工具类
    /// </summary>
    public static class Utils
    {
        #region 得到真实ip

        /// <summary>
        /// 得到真实ip
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static string GetRealIp(this HttpContext httpContext)
        {
            string realIp = httpContext.Request.Headers["X-Real-IP"].ToString();
            if (string.IsNullOrWhiteSpace(realIp))
            {
                realIp = httpContext.Connection.RemoteIpAddress.ToString();
            }

            return realIp;
        }

        #endregion
    }
}
