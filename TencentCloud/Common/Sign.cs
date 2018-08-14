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
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    /// <summary>
    /// 签名工具类
    /// </summary>
    public class SignHelper
    {
        //<summary>生成签名</summary>
        ///<param name="signKey">被加密串</param>
        ///<param name="secret">加密密钥</param>
        ///<returns>签名</returns>
        public static string Sign(string signKey, string secret, string SignatureMethod)
        {
            string signRet = string.Empty;
            if (SignatureMethod == ClientProfile.SIGN_SHA256)
            {
                using (HMACSHA256 mac = new HMACSHA256(Encoding.UTF8.GetBytes(signKey)))
                {
                    byte[] hash = mac.ComputeHash(Encoding.UTF8.GetBytes(secret));
                    signRet = Convert.ToBase64String(hash);
                }
            }
            else if(SignatureMethod == ClientProfile.SIGN_SHA1)
            {
                using (HMACSHA1 mac = new HMACSHA1(Encoding.UTF8.GetBytes(signKey)))
                {
                    byte[] hash = mac.ComputeHash(Encoding.UTF8.GetBytes(secret));
                    signRet = Convert.ToBase64String(hash);
                }
            }
            return signRet;
        }

        private static string BuildParamStr(SortedDictionary<string, string> requestParams, string requestMethod = "GET")
        {
            string retStr = "";
            foreach (string key in requestParams.Keys)
            {
                retStr += string.Format("{0}={1}&", key, requestParams[key]);
            }
            return retStr.TrimEnd('&');
        }

        public static string MakeSignPlainText(SortedDictionary<string, string> requestParams, string requestMethod , string requestHost, string requestPath)
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
