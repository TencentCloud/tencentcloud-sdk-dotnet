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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstancePriceItem : AbstractModel
    {
        
        /// <summary>
        /// 付费类型，如："All Upfront","Partial Upfront","No Upfront"
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }

        /// <summary>
        /// 预支合计费用，单位：元。
        /// </summary>
        [JsonProperty("FixedPrice")]
        public float? FixedPrice{ get; set; }

        /// <summary>
        /// 后续合计费用，单位：元/小时
        /// </summary>
        [JsonProperty("UsagePrice")]
        public float? UsagePrice{ get; set; }

        /// <summary>
        /// 预留实例配置ID
        /// </summary>
        [JsonProperty("ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId{ get; set; }

        /// <summary>
        /// 预留实例计费可购买的可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 预留实例计费【有效期】即预留实例计费购买时长。形如：31536000。
        /// 计量单位：秒
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 预留实例计费的平台描述（即操作系统）。形如：Linux。
        /// 返回项： Linux 。
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 预支合计费用，单位：元。
        /// </summary>
        [JsonProperty("DiscountUsagePrice")]
        public float? DiscountUsagePrice{ get; set; }

        /// <summary>
        /// 后续合计费用的折扣价，单位：元/小时
        /// </summary>
        [JsonProperty("DiscountFixedPrice")]
        public float? DiscountFixedPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OfferingType", this.OfferingType);
            this.SetParamSimple(map, prefix + "FixedPrice", this.FixedPrice);
            this.SetParamSimple(map, prefix + "UsagePrice", this.UsagePrice);
            this.SetParamSimple(map, prefix + "ReservedInstancesOfferingId", this.ReservedInstancesOfferingId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "DiscountUsagePrice", this.DiscountUsagePrice);
            this.SetParamSimple(map, prefix + "DiscountFixedPrice", this.DiscountFixedPrice);
        }
    }
}

