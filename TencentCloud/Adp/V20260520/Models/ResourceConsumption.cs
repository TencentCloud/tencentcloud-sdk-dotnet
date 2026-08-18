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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceConsumption : AbstractModel
    {
        
        /// <summary>
        /// <p>功能标签，PLATFORM 场景取 PlatformBizType 枚举名称；MODEL/PLUGIN 场景为空</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>消耗计量单位</p><table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>DOSAGE_UNIT_TOKEN</td><td>0</td><td>token（默认）</td></tr><tr><td>DOSAGE_UNIT_PAGE_COUNT</td><td>1</td><td>page_count（页数）</td></tr><tr><td>DOSAGE_UNIT_TIMES</td><td>2</td><td>times（次数）</td></tr><tr><td>DOSAGE_UNIT_SECOND</td><td>3</td><td>second（秒）</td></tr><tr><td>DOSAGE_UNIT_ITEM</td><td>4</td><td>item（条）</td></tr><tr><td>DOSAGE_UNIT_SHEET</td><td>5</td><td>sheet（张）</td></tr><tr><td>DOSAGE_UNIT_CHARACTER</td><td>6</td><td>character（字符）</td></tr><tr><td>DOSAGE_UNIT_GB</td><td>7</td><td>GB</td></tr><tr><td>DOSAGE_UNIT_NUMBER</td><td>8</td><td>number（个数）</td></tr><tr><td>DOSAGE_UNIT_MILL_SECOND</td><td>9</td><td>mill_second（毫秒）</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("Unit")]
        public long? Unit{ get; set; }

        /// <summary>
        /// <p>消耗数值</p>
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

