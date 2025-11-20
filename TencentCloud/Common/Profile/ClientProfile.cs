/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
    ///  Client profile configuration.
    ///  This class is used to configure common settings for the client, such as signature method and HTTP profile.
    /// </summary>
    public class ClientProfile
    {
        /// <summary>
        ///  Constructor with signature method and HTTP profile.
        /// </summary>
        /// <param name="signMethod"> The signature algorithm to be used (e.g., HmacSHA256, TC3-HMAC-SHA256). </param>
        /// <param name="httpProfile"> The HTTP profile, which defines HTTP-related settings like timeout.  See <seealso cref="HttpProfile"/>. </param>
        public ClientProfile(string signMethod, HttpProfile httpProfile)
        {
            this.SignMethod = signMethod;
            this.HttpProfile = httpProfile;
            
            this.Language = Language.ZH_CN;
            
        }

        /// <summary>
        ///  Constructor with signature method.  Uses a default HttpProfile.
        /// </summary>
        /// <param name="signMethod"> The signature algorithm to be used. </param>
        public ClientProfile(string signMethod)
            : this(signMethod, new HttpProfile())
        {
        }

        /// <summary>
        ///  Default constructor.  Uses the TC3-HMAC-SHA256 signature method and a default HttpProfile.
        /// </summary>
        public ClientProfile()
            : this(SIGN_TC3SHA256)
        {
        }

        /// <summary>
        ///  HTTP profile settings.  This property controls HTTP-specific options.
        ///  Refer to <seealso cref="HttpProfile"/> for details.
        /// </summary>
        public HttpProfile HttpProfile { get; set; }

        /// <summary>
        ///  The signature method used for authenticating requests.
        ///  Common values include HmacSHA256 and TC3-HMAC-SHA256.
        /// </summary>
        public string SignMethod { get; set; }

        /// <summary>
        ///  The language used for the SDK's responses (e.g., error messages).
        ///  Valid choices are: zh-CN (Simplified Chinese), en-US (US English).
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        ///  Signature method using HmacSHA1 (version 1).
        ///  This method is generally considered less secure than SHA256 variants.
        /// </summary>
        public const string SIGN_SHA1 = "HmacSHA1";

        /// <summary>
        ///  Signature method using HmacSHA256 (version 1).
        ///  A more secure alternative to HmacSHA1.
        /// </summary>
        public static string SIGN_SHA256 = "HmacSHA256";

        /// <summary>
        ///  Signature method using TC3-HMAC-SHA256 (version 3).
        ///  Tencent Cloud's recommended signature method, offering improved security and features.
        /// </summary>
        public static string SIGN_TC3SHA256 = "TC3-HMAC-SHA256";
    }
}