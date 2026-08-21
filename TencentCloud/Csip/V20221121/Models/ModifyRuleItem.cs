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

    public class ModifyRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 规则类型
        /// 枚举值：
        /// dimension：维度级规则
        /// category：子项级规则
        /// severity：等级级规则
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 维度ID
        /// </summary>
        [JsonProperty("DimensionId")]
        public string DimensionId{ get; set; }

        /// <summary>
        /// 子项ID，category和severity级别必填
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// 等级，severity级别必填
        /// 枚举值：
        /// critical：严重
        /// high：高危
        /// medium：中危
        /// low：低危
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// 扣分上限
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// 单次扣分
        /// </summary>
        [JsonProperty("DeductPerItem")]
        public long? DeductPerItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "DimensionId", this.DimensionId);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductPerItem", this.DeductPerItem);
        }
    }
}

