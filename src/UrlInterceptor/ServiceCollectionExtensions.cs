// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using UrlInterceptor.Extension;

namespace UrlInterceptor
{
    /// <summary>
    ///
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        #region 添加Url拦截器

        /// <summary>
        /// 添加Url拦截器
        /// </summary>
        /// <param name="services"></param>
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddUrlInterceptor(this IServiceCollection services,
            Action<UrlIntercepOptions> setupAction)
        {
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }

            UrlIntercepOptions intercepOptions = new UrlIntercepOptions();
            setupAction.Invoke(intercepOptions);
            foreach (var serviceExtension in intercepOptions.Extensions)
            {
                serviceExtension.AddServices(services);
            }

            services.AddSingleton(intercepOptions);
            return services;
        }

        #endregion
    }
}
