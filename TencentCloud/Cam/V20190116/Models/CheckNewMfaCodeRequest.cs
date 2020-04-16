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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckNewMfaCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 登录态Skey
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }

        /// <summary>
        /// 接口名
        /// </summary>
        [JsonProperty("Interface")]
        public string Interface{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// 浏览器UA
        /// </summary>
        [JsonProperty("ClientUA")]
        public string ClientUA{ get; set; }

        /// <summary>
        /// 验证类型
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 主账号uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }

        /// <summary>
        /// 手机验证码
        /// </summary>
        [JsonProperty("PhoneCode")]
        public ulong? PhoneCode{ get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public ulong? PhoneNumber{ get; set; }

        /// <summary>
        /// 邮箱验证码
        /// </summary>
        [JsonProperty("MailCode")]
        public ulong? MailCode{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 手机国码
        /// </summary>
        [JsonProperty("CountryCode")]
        public ulong? CountryCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
            this.SetParamSimple(map, prefix + "Interface", this.Interface);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "ClientUA", this.ClientUA);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "PhoneCode", this.PhoneCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "MailCode", this.MailCode);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
        }
    }
}

