// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace UrlInterceptor.Configurations.Dto
{
    /// <summary>
    /// 验证响应信息
    /// </summary>
    public class ValidatorResponseDto
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="state">验证结果</param>
        /// <param name="tip">提示信息</param>
        public ValidatorResponseDto(bool state, string tip)
        {
            State = state;
            Tip = tip;
        }

        #region 成功

        /// <summary>
        /// 成功
        /// </summary>
        /// <returns></returns>
        public static ValidatorResponseDto Success()
        {
            return new ValidatorResponseDto(true, "success");
        }

        #endregion

        #region 失败

        /// <summary>
        /// 失败
        /// </summary>
        /// <param name="tip">提示信息</param>
        /// <returns></returns>
        public static ValidatorResponseDto Error(string tip)
        {
            return new ValidatorResponseDto(false, tip);
        }

        #endregion

        #region 输出

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="state">状态</param>
        /// <param name="error">错误提示</param>
        /// <returns></returns>
        public static ValidatorResponseDto Output(bool state, string error)
        {
            if (state)
            {
                return Success();
            }

            return Error(error);
        }

        #endregion

        /// <summary>
        /// 验证结果
        /// </summary>
        public bool State { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Tip { get; set; }
    }
}
