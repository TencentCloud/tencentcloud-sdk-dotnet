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

    public class ReservedInstancesOffering : AbstractModel
    {
        
        /// <summary>
        /// 预留实例计费可购买的可用区。形如：ap-guangzhou-1。
        /// 返回项：<a href="https://cloud.tencent.com/document/product/213/6091">可用区列表</a>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 可购买的预留实例计费类型的结算货币，使用ISO 4217标准货币代码。
        /// 返回项：USD（美元）。
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// 预留实例计费【有效期】即预留实例计费购买时长。形如：31536000。
        /// 计量单位：秒
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 预留实例计费的购买价格。形如：4000.0。
        /// 计量单位：与 currencyCode 一致，目前支持 USD（美元）
        /// </summary>
        [JsonProperty("FixedPrice")]
        public float? FixedPrice{ get; set; }

        /// <summary>
        /// 预留实例计费的实例类型。形如：S3.MEDIUM4。
        /// 返回项：<a href="https://cloud.tencent.com/product/cvm/instances">预留实例计费类型列表</a>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 预留实例计费的付款类型。形如：All Upfront。
        /// 返回项： All Upfront (预付全部费用)。
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }

        /// <summary>
        /// 可购买的预留实例计费配置ID。形如：650c138f-ae7e-4750-952a-96841d6e9fc1。
        /// </summary>
        [JsonProperty("ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId{ get; set; }

        /// <summary>
        /// 预留实例计费的平台描述（即操作系统）。形如：linux。
        /// 返回项： linux 。
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 扣除预付费之后的使用价格 (按小时计费)。形如：0.0。
        /// 目前，因为只支持 All Upfront 付款类型，所以默认为 0元/小时。
        /// 计量单位：元/小时，货币单位与 currencyCode 一致，目前支持 USD（美元）
        /// </summary>
        [JsonProperty("UsagePrice")]
        public float? UsagePrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CurrencyCode", this.CurrencyCode);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "FixedPrice", this.FixedPrice);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "OfferingType", this.OfferingType);
            this.SetParamSimple(map, prefix + "ReservedInstancesOfferingId", this.ReservedInstancesOfferingId);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "UsagePrice", this.UsagePrice);
        }
    }
}

