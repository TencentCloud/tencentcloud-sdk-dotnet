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

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceBuyVsmRequest : AbstractModel
    {
        
        /// <summary>
        /// 需购买实例的数量
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 付费模式：0表示按需计费/后付费，1表示预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 商品的时间大小，整型参数，举例：当TimeSpan为1，TImeUnit为m时，表示询价购买时长为1个月时的价格
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// 商品的时间单位，m表示月，y表示年
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 默认为CREATE，可选RENEW
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Hsm服务类型，可选值virtualization、physical、GHSM、EHSM、SHSM
        /// </summary>
        [JsonProperty("HsmType")]
        public string HsmType{ get; set; }

        /// <summary>
        /// 货币类型，默认为CNY
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HsmType", this.HsmType);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

