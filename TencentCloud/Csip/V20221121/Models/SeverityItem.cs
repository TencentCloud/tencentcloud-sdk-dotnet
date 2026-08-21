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

    public class SeverityItem : AbstractModel
    {
        
        /// <summary>
        /// 风险等级
        /// 枚举值：
        /// critical：严重
        /// high：高危
        /// medium：中危
        /// low：低危
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// 等级中文名
        /// </summary>
        [JsonProperty("SeverityName")]
        public string SeverityName{ get; set; }

        /// <summary>
        /// 该等级风险数量
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 单次扣分
        /// </summary>
        [JsonProperty("DeductPerItem")]
        public long? DeductPerItem{ get; set; }

        /// <summary>
        /// 等级扣分上限
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// 实际扣分
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "SeverityName", this.SeverityName);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "DeductPerItem", this.DeductPerItem);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
        }
    }
}

