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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelFreeTrialInfo : AbstractModel
    {
        
        /// <summary>
        /// 推荐顺序，值越小排序越靠前。为空表示使用模型默认权重。
        /// </summary>
        [JsonProperty("RecommendWeight")]
        public long? RecommendWeight{ get; set; }

        /// <summary>
        /// 体验包容量大小。
        /// </summary>
        [JsonProperty("CapacitySize")]
        public long? CapacitySize{ get; set; }

        /// <summary>
        /// 容量单位。取值：token。
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 有效期天数（如90天）。为空表示不限期。
        /// </summary>
        [JsonProperty("ValidityDays")]
        public long? ValidityDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecommendWeight", this.RecommendWeight);
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "ValidityDays", this.ValidityDays);
        }
    }
}

