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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvocationIndicator : AbstractModel
    {
        
        /// <summary>
        /// 总请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationQuantity")]
        public long? InvocationQuantity{ get; set; }

        /// <summary>
        /// 请求成功率，百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationSuccessRate")]
        public float? InvocationSuccessRate{ get; set; }

        /// <summary>
        /// 请求平均耗时，单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationAvgDuration")]
        public float? InvocationAvgDuration{ get; set; }

        /// <summary>
        /// 成功请求数时间分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationSuccessDistribution")]
        public IndicatorCoord[] InvocationSuccessDistribution{ get; set; }

        /// <summary>
        /// 失败请求数时间分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationFailedDistribution")]
        public IndicatorCoord[] InvocationFailedDistribution{ get; set; }

        /// <summary>
        /// 状态码分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationStatusDistribution")]
        public IndicatorCoord[] InvocationStatusDistribution{ get; set; }

        /// <summary>
        /// 时延分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationDurationDistribution")]
        public IndicatorCoord[] InvocationDurationDistribution{ get; set; }

        /// <summary>
        /// 并发请求次数时间分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationQuantityDistribution")]
        public IndicatorCoord[] InvocationQuantityDistribution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationQuantity", this.InvocationQuantity);
            this.SetParamSimple(map, prefix + "InvocationSuccessRate", this.InvocationSuccessRate);
            this.SetParamSimple(map, prefix + "InvocationAvgDuration", this.InvocationAvgDuration);
            this.SetParamArrayObj(map, prefix + "InvocationSuccessDistribution.", this.InvocationSuccessDistribution);
            this.SetParamArrayObj(map, prefix + "InvocationFailedDistribution.", this.InvocationFailedDistribution);
            this.SetParamArrayObj(map, prefix + "InvocationStatusDistribution.", this.InvocationStatusDistribution);
            this.SetParamArrayObj(map, prefix + "InvocationDurationDistribution.", this.InvocationDurationDistribution);
            this.SetParamArrayObj(map, prefix + "InvocationQuantityDistribution.", this.InvocationQuantityDistribution);
        }
    }
}

