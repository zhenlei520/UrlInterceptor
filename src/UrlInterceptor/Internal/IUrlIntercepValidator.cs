// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using UrlInterceptor.Configurations.Dto;

namespace UrlInterceptor.Internal
{
    /// <summary>
    /// Url拦截器
    /// </summary>
    public interface IUrlIntercepValidator
    {
        /// <summary>
        /// 顺序 约大越先执行
        /// </summary>
        int Order { get; set; }

        /// <summary>
        /// 验证Url请求是否合法
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        ValidatorResponseDto Validate(HttpContext httpContext);
    }
}
