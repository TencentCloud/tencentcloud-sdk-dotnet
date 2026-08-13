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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigGroupFunctionTrigger : AbstractModel
    {
        
        /// <summary>
        /// <p><a href="https://cloud.tencent.com/document/product/1552/90438#33f65828-c6c6-4b66-a011-25a20b548d5d">匹配条件。</a></p>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>函数选择配置类型：</p><p>枚举值：</p><ul><li>direct： 直接指定执行函数</li><li>weight： 基于权重比选择函数</li><li>region： 基于客户端 IP 的国家/地区选择函数</li></ul>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>指定执行的函数，取值为函数在站点内的唯一标识。当 TriggerType 为 direct 时生效。</p>
        /// </summary>
        [JsonProperty("Function")]
        public string Function{ get; set; }

        /// <summary>
        /// <p>基于客户端 IP 国家/地区的函数选择配置。</p>
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public ConfigGroupFunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// <p>基于权重的函数选择配置。</p>
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public ConfigGroupFunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// <p>规则描述。</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "Function", this.Function);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

