// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using UrlInterceptor.Configurations.Dto;

namespace UrlInterceptor.Internal
{
    /// <summary>
    ///
    /// </summary>
    public class UrlIntercepValidatorDefault : IUrlIntercepValidator
    {
        /// <summary>
        ///
        /// </summary>
        public UrlIntercepValidatorDefault()
        {
            this.Order = 1;
        }

        /// <summary>
        /// 顺序 约大越先执行
        /// </summary>
        public int Order { get; set; }

        #region 验证Url请求是否合法

        /// <summary>
        /// 验证Url请求是否合法
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public ValidatorResponseDto Validate(HttpContext httpContext)
        {
            return ValidatorResponseDto.Success();
        }

        #endregion
    }
}
