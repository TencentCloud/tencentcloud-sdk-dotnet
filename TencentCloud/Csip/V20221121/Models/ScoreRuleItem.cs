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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreRuleItem : AbstractModel
    {
        
        /// <summary>
        /// <p>规则类型<br>枚举值：<br>dimension：维度级规则<br>category：子项级规则<br>severity：等级级规则</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// <p>维度ID</p>
        /// </summary>
        [JsonProperty("DimensionId")]
        public string DimensionId{ get; set; }

        /// <summary>
        /// <p>维度名称</p>
        /// </summary>
        [JsonProperty("DimensionName")]
        public string DimensionName{ get; set; }

        /// <summary>
        /// <p>子项ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>子项扣分规则说明</p>
        /// </summary>
        [JsonProperty("CategoryDesc")]
        public string CategoryDesc{ get; set; }

        /// <summary>
        /// <p>子项名称</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>等级<br>枚举值：<br>critical：严重<br>high：高危<br>medium：中危<br>low：低危</p>
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// <p>扣分上限</p>
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// <p>单次扣分</p>
        /// </summary>
        [JsonProperty("DeductPerItem")]
        public long? DeductPerItem{ get; set; }

        /// <summary>
        /// <p>单项扣分是否不可编辑（防护配置维度子项为 true）</p>
        /// </summary>
        [JsonProperty("DeductPerItemDisabled")]
        public bool? DeductPerItemDisabled{ get; set; }

        /// <summary>
        /// <p>排序序号</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public long? SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "DimensionId", this.DimensionId);
            this.SetParamSimple(map, prefix + "DimensionName", this.DimensionName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryDesc", this.CategoryDesc);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductPerItem", this.DeductPerItem);
            this.SetParamSimple(map, prefix + "DeductPerItemDisabled", this.DeductPerItemDisabled);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

