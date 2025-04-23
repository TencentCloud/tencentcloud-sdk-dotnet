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

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    /// <summary>
    ///   Signature helper class.
    ///   Provides methods for generating signatures for Tencent Cloud API requests.
    /// </summary>
    public class SignHelper
    {
        /// <summary>
        ///   Generates a signature for an API request.
        /// </summary>
        /// <param name="signKey">Credential SecretKey.</param>
        /// <param name="secret">Plain text to be signed.</param>
        /// <param name="SignatureMethod">The signature method to use (e.g., HmacSHA1, HmacSHA256).</param>
        /// <returns>The generated signature.</returns>
        public static string Sign(string signKey, string secret, string SignatureMethod)
        {
            string signRet = string.Empty;
            // Use HMACSHA256 if the specified method is SHA256
            if (SignatureMethod == ClientProfile.SIGN_SHA256)
            {
                using (HMACSHA256 mac = new HMACSHA256(Encoding.UTF8.GetBytes(signKey)))
                {
                    byte[] hash = mac.ComputeHash(Encoding.UTF8.GetBytes(secret));
                    signRet = Convert.ToBase64String(hash);
                }
            }
            // Use HMACSHA1 if the specified method is SHA1
            else if (SignatureMethod == ClientProfile.SIGN_SHA1)
            {
                using (HMACSHA1 mac = new HMACSHA1(Encoding.UTF8.GetBytes(signKey)))
                {
                    byte[] hash = mac.ComputeHash(Encoding.UTF8.GetBytes(secret));
                    signRet = Convert.ToBase64String(hash);
                }
            }

            return signRet;
        }

        /// <summary>
        ///   Calculates the SHA256 hash of a string and returns it as a hexadecimal string.
        /// </summary>
        /// <param name="s">The string to hash.</param>
        /// <returns>The SHA256 hash as a hexadecimal string.</returns>
        public static string SHA256Hex(string s)
        {
            return SHA256Hex(Encoding.UTF8.GetBytes(s));
        }

        /// <summary>
        ///   Calculates the SHA256 hash of a byte array and returns it as a hexadecimal string.
        /// </summary>
        /// <param name="s">The byte array to hash.</param>
        /// <returns>The SHA256 hash as a hexadecimal string.</returns>
        public static string SHA256Hex(byte[] s)
        {
            using (SHA256 algo = SHA256.Create())
            {
                byte[] hashbytes = algo.ComputeHash(s);
                StringBuilder builder = new StringBuilder();
                // Format each byte as a two-digit hexadecimal string
                for (int i = 0; i < hashbytes.Length; ++i)
                {
                    builder.Append(hashbytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        /// <summary>
        ///   Calculates the HMAC-SHA256 hash of a message using a key.
        /// </summary>
        /// <param name="key">The key to use for the HMAC calculation.</param>
        /// <param name="msg">The message to hash.</param>
        /// <returns>The HMAC-SHA256 hash as a byte array.</returns>
        public static byte[] HmacSHA256(byte[] key, byte[] msg)
        {
            using (HMACSHA256 mac = new HMACSHA256(key))
            {
                return mac.ComputeHash(msg);
            }
        }

        /// <summary>
        ///   Builds a query string from a sorted dictionary of request parameters.
        /// </summary>
        /// <param name="requestParams">The sorted dictionary of parameters.</param>
        /// <param name="requestMethod">The HTTP request method (default: GET).</param>
        /// <returns>The formatted query string.</returns>
        private static string BuildParamStr(SortedDictionary<string, string> requestParams,
            string requestMethod = "GET")
        {
            string retStr = "";
            // Concatenate key-value pairs with '=' and '&'
            foreach (string key in requestParams.Keys)
            {
                retStr += string.Format("{0}={1}&", key, requestParams[key]);
            }

            return retStr.TrimEnd('&');
        }

        /// <summary>
        ///   Constructs the plain text string to be signed for API requests.
        /// </summary>
        /// <param name="requestParams">The sorted dictionary of request parameters.</param>
        /// <param name="requestMethod">The HTTP request method (e.g., GET, POST).</param>
        /// <param name="requestHost">The request host (e.g., cvm.tencentcloudapi.com).</param>
        /// <param name="requestPath">The request path (e.g., /).</param>
        /// <returns>The plain text string to be signed.</returns>
        public static string MakeSignPlainText(SortedDictionary<string, string> requestParams, string requestMethod,
            string requestHost, string requestPath)
        {
            string retStr = "";
            retStr += requestMethod;
            retStr += requestHost;
            retStr += requestPath;
            retStr += "?";
            retStr += BuildParamStr(requestParams);
            return retStr;
        }
    }
}