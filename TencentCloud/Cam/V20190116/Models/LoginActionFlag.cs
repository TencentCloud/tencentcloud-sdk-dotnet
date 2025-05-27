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

    public class LoginActionFlag : AbstractModel
    {
        
        /// <summary>
        /// 0: 非安全手机校验 1: 安全手机校验。
        /// </summary>
        [JsonProperty("Phone")]
        public ulong? Phone{ get; set; }

        /// <summary>
        /// 0: 非硬token校验 1: 硬token校验。
        /// </summary>
        [JsonProperty("Token")]
        public ulong? Token{ get; set; }

        /// <summary>
        /// 0: 非软token校验 1: 软token校验
        /// </summary>
        [JsonProperty("Stoken")]
        public ulong? Stoken{ get; set; }

        /// <summary>
        /// 0: 非微信校验 1: 微信校验
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// 0: 非自定义校验 1: 自定义校验
        /// </summary>
        [JsonProperty("Custom")]
        public ulong? Custom{ get; set; }

        /// <summary>
        /// 0: 非邮箱校验 1: 邮箱校验
        /// </summary>
        [JsonProperty("Mail")]
        public ulong? Mail{ get; set; }

        /// <summary>
        /// 0: 非u2f硬件token 1: u2f硬件token
        /// </summary>
        [JsonProperty("U2FToken")]
        public ulong? U2FToken{ get; set; }


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
        }
    }
}

