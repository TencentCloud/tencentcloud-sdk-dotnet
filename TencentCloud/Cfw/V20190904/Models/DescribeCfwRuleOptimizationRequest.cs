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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwRuleOptimizationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>防火墙规则类型。必填。枚举：border 互联网边界；nat NAT 边界；vpc VPC 间；enterprise_sg 企业安全组。</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// <p>要执行的优化维度白名单。可选，例如 D1、D2、D8；不传默认执行全部支持维度。</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public string[] Dimensions{ get; set; }

        /// <summary>
        /// <p>长期零命中规则阈值天数。可选，默认 180。</p>
        /// </summary>
        [JsonProperty("IdleDays")]
        public long? IdleDays{ get; set; }

        /// <summary>
        /// <p>单 IP 离散过多聚合建议的最小数量。可选，默认 10。</p>
        /// </summary>
        [JsonProperty("IpAggMin")]
        public long? IpAggMin{ get; set; }

        /// <summary>
        /// <p>可迁移 IOC 建议中返回的样例 IOC 数量上限。可选，默认 50。</p>
        /// </summary>
        [JsonProperty("IocSample")]
        public long? IocSample{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "IdleDays", this.IdleDays);
            this.SetParamSimple(map, prefix + "IpAggMin", this.IpAggMin);
            this.SetParamSimple(map, prefix + "IocSample", this.IocSample);
        }
    }
}

