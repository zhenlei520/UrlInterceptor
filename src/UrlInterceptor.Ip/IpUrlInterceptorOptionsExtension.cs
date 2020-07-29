// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using UrlInterceptor.Internal;

namespace UrlInterceptor.Ip
{
    /// <summary>
    ///
    /// </summary>
    public class IpUrlInterceptorOptionsExtension : IUrlInterceptorOptionsExtension
    {
        private readonly Action<IpOptions> _configure;

        /// <summary>
        ///
        /// </summary>
        /// <param name="configure"></param>
        public IpUrlInterceptorOptionsExtension(Action<IpOptions> configure)
        {
            _configure = configure;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="services"></param>
        public void AddServices(IServiceCollection services)
        {
            services.Configure(_configure);
        }
    }
}
