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

namespace TencentCloud.Market.V20191010.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OfflineProductDeal : AbstractModel
    {
        
        /// <summary>
        /// 产品标签
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品标签
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 计费项
        /// </summary>
        [JsonProperty("BillingItemCode")]
        public string BillingItemCode{ get; set; }

        /// <summary>
        /// 计费细项
        /// </summary>
        [JsonProperty("SubBillingItemCode")]
        public string SubBillingItemCode{ get; set; }

        /// <summary>
        /// 单价（单位：分）
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [JsonProperty("Dosage")]
        public float? Dosage{ get; set; }

        /// <summary>
        /// 用量单位
        /// </summary>
        [JsonProperty("DosageUnit")]
        public string DosageUnit{ get; set; }

        /// <summary>
        /// 商品的时间大小，当TimeUnit 是package时，timeSpan 只能传1。当TimeUnit是year；month；day；hour；minute；second，传具体时长。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public float? TimeSpan{ get; set; }

        /// <summary>
        /// 商品的时间单位：year:年；month:月；day:日；hour:小时；minute:分钟；second:秒; package:与价格无关,一次性购买的产品传package
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 原价 （单位：分）OriginPrice=round(UnitPrice * Dosage * TimeSpan)
        /// </summary>
        [JsonProperty("OriginPrice")]
        public long? OriginPrice{ get; set; }

        /// <summary>
        /// 折扣百分比，传入0-100的值
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 最终扣费金额（单位：分）Fee=round(OriginPrice*Discount/100)
        /// </summary>
        [JsonProperty("Fee")]
        public long? Fee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "BillingItemCode", this.BillingItemCode);
            this.SetParamSimple(map, prefix + "SubBillingItemCode", this.SubBillingItemCode);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "Dosage", this.Dosage);
            this.SetParamSimple(map, prefix + "DosageUnit", this.DosageUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "OriginPrice", this.OriginPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "Fee", this.Fee);
        }
    }
}

