/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
namespace TencentCloud.Common.Profile
{
    /// <summary>
    /// client选项类
    /// </summary>
    public class ClientProfile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="signMethod">签名方法</param>
        /// <param name="httpProfile">HttpProfile实例</param>
        public ClientProfile(string signMethod, HttpProfile httpProfile)
        {
            this.SignMethod = signMethod;
            this.HttpProfile = httpProfile;
        }

        public ClientProfile(string signMethod)
            : this(signMethod, new HttpProfile())
        {
            
        }

        public ClientProfile()
        {
            SignMethod = SIGN_SHA256;
            HttpProfile = new HttpProfile();
        }

        /// <summary>
        /// http相关选项，请参考 <seealso cref="HttpProfile"/>
        /// </summary>
        public HttpProfile HttpProfile { get; set; }

        /// <summary>
        /// 签名方法
        /// </summary>
        public string SignMethod { get; set; }


        /// <summary>
        /// HmacSHA1签名方法
        /// </summary>
        public const string SIGN_SHA1 = "HmacSHA1";

        /// <summary>
        /// HmacSHA256签名方法
        /// </summary>
        public static string SIGN_SHA256 = "HmacSHA256";
    }
}
