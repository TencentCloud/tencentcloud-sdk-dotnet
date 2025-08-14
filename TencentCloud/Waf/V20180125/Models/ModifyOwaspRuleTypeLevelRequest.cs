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

    public class ModifyOwaspRuleTypeLevelRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则类型ID列表
        /// </summary>
        [JsonProperty("TypeIDs")]
        public string[] TypeIDs{ get; set; }

        /// <summary>
        /// 规则的防护等级，100：宽松、200：正常、300：严格、400：超严格
        /// </summary>
        [JsonProperty("RuleTypeLevel")]
        public long? RuleTypeLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "TypeIDs.", this.TypeIDs);
            this.SetParamSimple(map, prefix + "RuleTypeLevel", this.RuleTypeLevel);
        }
    }
}

