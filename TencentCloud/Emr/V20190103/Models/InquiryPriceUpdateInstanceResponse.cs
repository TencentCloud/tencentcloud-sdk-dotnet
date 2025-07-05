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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceUpdateInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 原价，单位为元。
        /// </summary>
        [JsonProperty("OriginalCost")]
        public float? OriginalCost{ get; set; }

        /// <summary>
        /// 折扣价，单位为元。
        /// </summary>
        [JsonProperty("DiscountCost")]
        public float? DiscountCost{ get; set; }

        /// <summary>
        /// 变配的时间单位。取值范围：
        /// <li>s：表示秒。</li>
        /// <li>m：表示月份。</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 变配的时长。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 价格详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriceDetail")]
        public PriceDetail[] PriceDetail{ get; set; }

        /// <summary>
        /// 新配置价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewConfigPrice")]
        public PriceResult NewConfigPrice{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "DiscountCost", this.DiscountCost);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamArrayObj(map, prefix + "PriceDetail.", this.PriceDetail);
            this.SetParamObj(map, prefix + "NewConfigPrice.", this.NewConfigPrice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

