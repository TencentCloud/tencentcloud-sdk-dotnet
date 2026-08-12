/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class LoginActionFlagIntl : AbstractModel
    {
        
        /// <summary>
        /// <p>手机</p>
        /// </summary>
        [JsonProperty("Phone")]
        public ulong? Phone{ get; set; }

        /// <summary>
        /// <p>硬token</p>
        /// </summary>
        [JsonProperty("Token")]
        public ulong? Token{ get; set; }

        /// <summary>
        /// <p>软token</p>
        /// </summary>
        [JsonProperty("Stoken")]
        public ulong? Stoken{ get; set; }

        /// <summary>
        /// <p>微信</p>
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// <p>自定义</p>
        /// </summary>
        [JsonProperty("Custom")]
        public ulong? Custom{ get; set; }

        /// <summary>
        /// <p>邮件</p>
        /// </summary>
        [JsonProperty("Mail")]
        public ulong? Mail{ get; set; }

        /// <summary>
        /// <p>u2f硬件token</p>
        /// </summary>
        [JsonProperty("U2FToken")]
        public ulong? U2FToken{ get; set; }

        /// <summary>
        /// <p>passkey通行密钥</p>
        /// </summary>
        [JsonProperty("Passkey")]
        public ulong? Passkey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Stoken", this.Stoken);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Custom", this.Custom);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "U2FToken", this.U2FToken);
            this.SetParamSimple(map, prefix + "Passkey", this.Passkey);
        }
    }
}

