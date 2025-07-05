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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPIPInstanceSpecification : AbstractModel
    {
        
        /// <summary>
        /// 保底防护峰值，单位Mbps
        /// </summary>
        [JsonProperty("ProtectBandwidth")]
        public ulong? ProtectBandwidth{ get; set; }

        /// <summary>
        /// CC防护峰值，单位qps
        /// </summary>
        [JsonProperty("ProtectCCQPS")]
        public ulong? ProtectCCQPS{ get; set; }

        /// <summary>
        /// 正常业务带宽，单位Mbps
        /// </summary>
        [JsonProperty("NormalBandwidth")]
        public ulong? NormalBandwidth{ get; set; }

        /// <summary>
        /// 转发规则数，单位条
        /// </summary>
        [JsonProperty("ForwardRulesLimit")]
        public ulong? ForwardRulesLimit{ get; set; }

        /// <summary>
        /// 自动续费状态，取值[
        /// 0：没有开启自动续费
        /// 1：开启了自动续费
        /// ]
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 高防IP线路，取值为[
        /// 1：BGP线路
        /// 2：电信
        /// 3：联通
        /// 4：移动
        /// 99：第三方合作线路
        /// ]
        /// </summary>
        [JsonProperty("Line")]
        public ulong? Line{ get; set; }

        /// <summary>
        /// 弹性防护峰值，单位Mbps
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public ulong? ElasticBandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectBandwidth", this.ProtectBandwidth);
            this.SetParamSimple(map, prefix + "ProtectCCQPS", this.ProtectCCQPS);
            this.SetParamSimple(map, prefix + "NormalBandwidth", this.NormalBandwidth);
            this.SetParamSimple(map, prefix + "ForwardRulesLimit", this.ForwardRulesLimit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
        }
    }
}

