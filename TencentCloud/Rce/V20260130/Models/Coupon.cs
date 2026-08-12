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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Coupon : AbstractModel
    {
        
        /// <summary>
        /// <p>优惠券ID</p>
        /// </summary>
        [JsonProperty("CouponId")]
        public string CouponId{ get; set; }

        /// <summary>
        /// <p>优惠券名称</p>
        /// </summary>
        [JsonProperty("CouponName")]
        public string CouponName{ get; set; }

        /// <summary>
        /// <p>优惠券开始时间</p><p>参数格式：符合ISO 8601标准的带UTC时区的毫秒级时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>优惠券过期时间</p><p>参数格式：符合ISO 8601标准的带UTC时区的毫秒级时间</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>折扣百分比，如果折扣为 10%，则发送“0.1”</p>
        /// </summary>
        [JsonProperty("PercentageRate")]
        public float? PercentageRate{ get; set; }

        /// <summary>
        /// <p>折扣金额</p>
        /// </summary>
        [JsonProperty("DiscountAmount")]
        public Amount DiscountAmount{ get; set; }

        /// <summary>
        /// <p>优惠券门槛</p>
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CouponId", this.CouponId);
            this.SetParamSimple(map, prefix + "CouponName", this.CouponName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "PercentageRate", this.PercentageRate);
            this.SetParamObj(map, prefix + "DiscountAmount.", this.DiscountAmount);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

