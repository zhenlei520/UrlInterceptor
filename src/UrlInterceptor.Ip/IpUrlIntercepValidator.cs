// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using UrlInterceptor.Common;
using UrlInterceptor.Configurations.Dto;
using UrlInterceptor.Internal;

namespace UrlInterceptor.Ip
{
    /// <summary>
    /// ip限制
    /// </summary>
    public class IpUrlIntercepValidator : IUrlIntercepValidator
    {
        /// <summary>
        ///
        /// </summary>
        public IpUrlIntercepValidator()
        {
            this.Order = 1;
        }

        private readonly IpOptions _ipOptions;


        /// <summary>
        ///
        /// </summary>
        /// <param name="ipOptions"></param>
        public IpUrlIntercepValidator(IpOptions ipOptions)
        {
            this._ipOptions = ipOptions;
        }

        public int Order { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public ValidatorResponseDto Validate(HttpContext httpContext)
        {
            string realIp = httpContext.GetRealIp();
            if (this._ipOptions.RuleType == IpRuleType.Black)
            {
                return ValidatorResponseDto.Output(!this._ipOptions.IpList.Contains(realIp), _ipOptions.GetTip());
            }

            return ValidatorResponseDto.Output(this._ipOptions.IpList.Contains(realIp), this._ipOptions.GetTip());
        }
    }
}
