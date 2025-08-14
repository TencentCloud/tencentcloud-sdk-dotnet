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

    public class ModifyOwaspRuleStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则开关，0：关闭、1：开启、2：只观察
        /// </summary>
        [JsonProperty("RuleStatus")]
        public long? RuleStatus{ get; set; }

        /// <summary>
        /// 是否全选
        /// </summary>
        [JsonProperty("SelectAll")]
        public bool? SelectAll{ get; set; }

        /// <summary>
        /// 规则ID列表
        /// </summary>
        [JsonProperty("RuleIDs")]
        public string[] RuleIDs{ get; set; }

        /// <summary>
        /// 如果反转需要传入类型
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// 修改原因 0：无(兼容记录为空) 1：业务自身特性误报避免 2：规则误报上报 3：核心业务规则灰度 4：其它
        /// </summary>
        [JsonProperty("Reason")]
        public long? Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArraySimple(map, prefix + "RuleIDs.", this.RuleIDs);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

