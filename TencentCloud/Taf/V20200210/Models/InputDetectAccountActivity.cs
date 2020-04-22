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

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputDetectAccountActivity : AbstractModel
    {
        
        /// <summary>
        /// 用户ID值，如微信/QQ openid，或 手机号等（如15912345687）
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 用户账号类型 
        /// 1：QQ开放帐号 
        /// 2：微信开放账号 
        /// 4：手机号 （暂仅支持国内手机号）
        /// 10004： 手机号MD5
        /// </summary>
        [JsonProperty("AccountType")]
        public ulong? AccountType{ get; set; }

        /// <summary>
        /// 用户真实外网IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 用户操作时间戳，单位秒（格林威治时间精确到秒，如1501590972）
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// accountType是QQ或微信开放账号时，该参数必填，表示QQ或微信分配给网站或应用的appId，用来唯一标识网站或应用
        /// </summary>
        [JsonProperty("AppIdU")]
        public string AppIdU{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 手机号。若 accountType 选4（手机号）、或10004（手机号 MD5），则无需重复填写。否则填入对应的手机号（如15912345687）
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 用户邮箱地址（非系统自动生成）
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 用户 HTTP 请求中的 cookie 进行2次 hash 的值，只要保证相同 cookie 的 hash 值一致即可
        /// </summary>
        [JsonProperty("CookieHash")]
        public float? CookieHash{ get; set; }

        /// <summary>
        /// 用户HTTP请求的 userAgent
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户HTTP请求中的 x_forward_for
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// Mac地址或设备唯一标识
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机制造商ID，如果手机注册，请带上此信息
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// 手机设备号
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AppIdU", this.AppIdU);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
        }
    }
}

