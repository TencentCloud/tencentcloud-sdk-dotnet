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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWafAutoDenyRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 触发IP封禁的攻击次数阈值，范围为2~100次
        /// </summary>
        [JsonProperty("AttackThreshold")]
        public long? AttackThreshold{ get; set; }

        /// <summary>
        /// IP封禁统计时间，范围为1-60分钟
        /// </summary>
        [JsonProperty("TimeThreshold")]
        public long? TimeThreshold{ get; set; }

        /// <summary>
        /// 触发IP封禁后的封禁时间，范围为5~360分钟
        /// </summary>
        [JsonProperty("DenyTimeThreshold")]
        public long? DenyTimeThreshold{ get; set; }

        /// <summary>
        /// 自动封禁状态
        /// </summary>
        [JsonProperty("DefenseStatus")]
        public long? DefenseStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AttackThreshold", this.AttackThreshold);
            this.SetParamSimple(map, prefix + "TimeThreshold", this.TimeThreshold);
            this.SetParamSimple(map, prefix + "DenyTimeThreshold", this.DenyTimeThreshold);
            this.SetParamSimple(map, prefix + "DefenseStatus", this.DefenseStatus);
        }
    }
}

