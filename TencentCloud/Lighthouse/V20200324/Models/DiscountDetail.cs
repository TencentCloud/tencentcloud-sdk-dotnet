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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiscountDetail : AbstractModel
    {
        
        /// <summary>
        /// 计费时长。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 计费单元。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 总价。
        /// </summary>
        [JsonProperty("TotalCost")]
        public float? TotalCost{ get; set; }

        /// <summary>
        /// 折后总价。
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public float? RealTotalCost{ get; set; }

        /// <summary>
        /// 折扣。
        /// </summary>
        [JsonProperty("Discount")]
        public long? Discount{ get; set; }

        /// <summary>
        /// 具体折扣详情。
        /// </summary>
        [JsonProperty("PolicyDetail")]
        public PolicyDetail PolicyDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamObj(map, prefix + "PolicyDetail.", this.PolicyDetail);
        }
    }
}

