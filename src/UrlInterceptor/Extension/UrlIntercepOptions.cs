// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using UrlInterceptor.Internal;

namespace UrlInterceptor.Extension
{
    /// <summary>
    /// 拦截器配置
    /// </summary>
    public class UrlIntercepOptions
    {
        /// <summary>
        ///
        /// </summary>
        internal IList<IUrlInterceptorOptionsExtension> Extensions { get; }

        /// <summary>
        /// Registers an extension that will be executed when building services.
        /// </summary>
        /// <param name="extension"></param>
        public void RegisterExtension(IUrlInterceptorOptionsExtension extension)
        {
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            Extensions.Add(extension);
        }
    }
}
