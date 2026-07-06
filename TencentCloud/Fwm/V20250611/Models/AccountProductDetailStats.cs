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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountProductDetailStats : AbstractModel
    {
        
        /// <summary>
        /// 产品类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 产品名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 体检策略数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyCount")]
        public long? PolicyCount{ get; set; }

        /// <summary>
        /// 待整改风险数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UntreatedRiskCount")]
        public long? UntreatedRiskCount{ get; set; }

        /// <summary>
        /// 总风险数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRiskCount")]
        public long? TotalRiskCount{ get; set; }

        /// <summary>
        /// 已处置数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreatedRiskCount")]
        public long? TreatedRiskCount{ get; set; }

        /// <summary>
        /// 已忽略数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoredRiskCount")]
        public long? IgnoredRiskCount{ get; set; }

        /// <summary>
        /// 整改率，如 50%，无需整改时为 无需整改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RectifyRate")]
        public string RectifyRate{ get; set; }

        /// <summary>
        /// 最近一次体检时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// 子类 ID 列表
        /// </summary>
        [JsonProperty("SubcategoryIds")]
        public string[] SubcategoryIds{ get; set; }

        /// <summary>
        /// 是否超时未体检
        /// </summary>
        [JsonProperty("IsOverdue")]
        public bool? IsOverdue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "PolicyCount", this.PolicyCount);
            this.SetParamSimple(map, prefix + "UntreatedRiskCount", this.UntreatedRiskCount);
            this.SetParamSimple(map, prefix + "TotalRiskCount", this.TotalRiskCount);
            this.SetParamSimple(map, prefix + "TreatedRiskCount", this.TreatedRiskCount);
            this.SetParamSimple(map, prefix + "IgnoredRiskCount", this.IgnoredRiskCount);
            this.SetParamSimple(map, prefix + "RectifyRate", this.RectifyRate);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamArraySimple(map, prefix + "SubcategoryIds.", this.SubcategoryIds);
            this.SetParamSimple(map, prefix + "IsOverdue", this.IsOverdue);
        }
    }
}

