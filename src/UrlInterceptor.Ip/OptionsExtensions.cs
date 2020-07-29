// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using UrlInterceptor.Extension;

namespace UrlInterceptor.Ip
{
    /// <summary>
    ///
    /// </summary>
    public static class OptionsExtensions
    {
        #region 用ip策略

        /// <summary>
        /// 用ip策略
        /// </summary>
        /// <param name="options"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static UrlIntercepOptions UseIpStrategy(this UrlIntercepOptions options, Action<IpOptions> configure)
        {
            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            options.RegisterExtension(new IpUrlInterceptorOptionsExtension(configure));

            return options;
        }

        #endregion
    }
}
