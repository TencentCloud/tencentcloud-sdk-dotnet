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

    public class BGPIPInstanceUsages : AbstractModel
    {
        
        /// <summary>
        /// 已使用的端口规则数，单位条
        /// </summary>
        [JsonProperty("PortRulesUsage")]
        public ulong? PortRulesUsage{ get; set; }

        /// <summary>
        /// 已使用的域名规则数，单位条
        /// </summary>
        [JsonProperty("DomainRulesUsage")]
        public ulong? DomainRulesUsage{ get; set; }

        /// <summary>
        /// 最近7天的攻击次数，单位次
        /// </summary>
        [JsonProperty("Last7DayAttackCount")]
        public ulong? Last7DayAttackCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PortRulesUsage", this.PortRulesUsage);
            this.SetParamSimple(map, prefix + "DomainRulesUsage", this.DomainRulesUsage);
            this.SetParamSimple(map, prefix + "Last7DayAttackCount", this.Last7DayAttackCount);
        }
    }
}

