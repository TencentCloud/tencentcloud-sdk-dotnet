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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmrPrice : AbstractModel
    {
        
        /// <summary>
        /// 刊例价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// 折扣价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountCost")]
        public string DiscountCost{ get; set; }

        /// <summary>
        /// 单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 询价配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriceSpec")]
        public PriceResource PriceSpec{ get; set; }

        /// <summary>
        /// 是否支持竞价实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportSpotPaid")]
        public bool? SupportSpotPaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "DiscountCost", this.DiscountCost);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamObj(map, prefix + "PriceSpec.", this.PriceSpec);
            this.SetParamSimple(map, prefix + "SupportSpotPaid", this.SupportSpotPaid);
        }
    }
}

