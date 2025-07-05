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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WafRuleLimit : AbstractModel
    {
        
        /// <summary>
        /// 自定义CC的规格
        /// </summary>
        [JsonProperty("CC")]
        public ulong? CC{ get; set; }

        /// <summary>
        /// 自定义策略的规格
        /// </summary>
        [JsonProperty("CustomRule")]
        public ulong? CustomRule{ get; set; }

        /// <summary>
        /// 黑白名单的规格
        /// </summary>
        [JsonProperty("IPControl")]
        public ulong? IPControl{ get; set; }

        /// <summary>
        /// 信息防泄漏的规格
        /// </summary>
        [JsonProperty("AntiLeak")]
        public ulong? AntiLeak{ get; set; }

        /// <summary>
        /// 防篡改的规格
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// 紧急CC的规格
        /// </summary>
        [JsonProperty("AutoCC")]
        public ulong? AutoCC{ get; set; }

        /// <summary>
        /// 地域封禁的规格
        /// </summary>
        [JsonProperty("AreaBan")]
        public ulong? AreaBan{ get; set; }

        /// <summary>
        /// 自定义CC中配置session
        /// </summary>
        [JsonProperty("CCSession")]
        public ulong? CCSession{ get; set; }

        /// <summary>
        /// AI的规格
        /// </summary>
        [JsonProperty("AI")]
        public ulong? AI{ get; set; }

        /// <summary>
        /// 精准白名单的规格
        /// </summary>
        [JsonProperty("CustomWhite")]
        public ulong? CustomWhite{ get; set; }

        /// <summary>
        /// api安全的规格
        /// </summary>
        [JsonProperty("ApiSecurity")]
        public ulong? ApiSecurity{ get; set; }

        /// <summary>
        /// 客户端流量标记的规格
        /// </summary>
        [JsonProperty("ClientMsg")]
        public ulong? ClientMsg{ get; set; }

        /// <summary>
        /// 流量标记的规格
        /// </summary>
        [JsonProperty("TrafficMarking")]
        public ulong? TrafficMarking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CC", this.CC);
            this.SetParamSimple(map, prefix + "CustomRule", this.CustomRule);
            this.SetParamSimple(map, prefix + "IPControl", this.IPControl);
            this.SetParamSimple(map, prefix + "AntiLeak", this.AntiLeak);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AutoCC", this.AutoCC);
            this.SetParamSimple(map, prefix + "AreaBan", this.AreaBan);
            this.SetParamSimple(map, prefix + "CCSession", this.CCSession);
            this.SetParamSimple(map, prefix + "AI", this.AI);
            this.SetParamSimple(map, prefix + "CustomWhite", this.CustomWhite);
            this.SetParamSimple(map, prefix + "ApiSecurity", this.ApiSecurity);
            this.SetParamSimple(map, prefix + "ClientMsg", this.ClientMsg);
            this.SetParamSimple(map, prefix + "TrafficMarking", this.TrafficMarking);
        }
    }
}

