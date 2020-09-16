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
        /// 手机
        /// </summary>
        [JsonProperty("Phone")]
        public ulong? Phone{ get; set; }

        /// <summary>
        /// 硬token
        /// </summary>
        [JsonProperty("Token")]
        public ulong? Token{ get; set; }

        /// <summary>
        /// 软token
        /// </summary>
        [JsonProperty("Stoken")]
        public ulong? Stoken{ get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// 自定义
        /// </summary>
        [JsonProperty("Custom")]
        public ulong? Custom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Stoken", this.Stoken);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Custom", this.Custom);
        }
    }
}

