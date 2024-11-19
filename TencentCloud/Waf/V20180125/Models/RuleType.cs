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

    public class RuleType : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("TypeID")]
        public string TypeID{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则类型描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 规则类型状态，即类型生效开关，0：关闭，1：开启
        /// </summary>
        [JsonProperty("RuleTypeStatus")]
        public long? RuleTypeStatus{ get; set; }

        /// <summary>
        /// 类型下生效的规则数量
        /// </summary>
        [JsonProperty("ActiveRuleCount")]
        public long? ActiveRuleCount{ get; set; }

        /// <summary>
        /// 类型下的规则总数量
        /// </summary>
        [JsonProperty("TotalRuleCount")]
        public long? TotalRuleCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeID", this.TypeID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "RuleTypeStatus", this.RuleTypeStatus);
            this.SetParamSimple(map, prefix + "ActiveRuleCount", this.ActiveRuleCount);
            this.SetParamSimple(map, prefix + "TotalRuleCount", this.TotalRuleCount);
        }
    }
}

