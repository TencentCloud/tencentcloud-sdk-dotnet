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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnifiedOrderInSubOrderList : AbstractModel
    {
        
        /// <summary>
        /// 子订单结算应收金额，单位： 分
        /// </summary>
        [JsonProperty("SubMchIncome")]
        public long? SubMchIncome{ get; set; }

        /// <summary>
        /// 子订单平台应收金额，单位：分
        /// </summary>
        [JsonProperty("PlatformIncome")]
        public long? PlatformIncome{ get; set; }

        /// <summary>
        /// 子订单商品详情
        /// </summary>
        [JsonProperty("ProductDetail")]
        public string ProductDetail{ get; set; }

        /// <summary>
        /// 子订单商品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonProperty("SubOutTradeNo")]
        public string SubOutTradeNo{ get; set; }

        /// <summary>
        /// 子订单支付金额
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// 发货标识，由业务在调用聚鑫下单接口的 时候下发
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 子订单原始金额
        /// </summary>
        [JsonProperty("OriginalAmt")]
        public long? OriginalAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubMchIncome", this.SubMchIncome);
            this.SetParamSimple(map, prefix + "PlatformIncome", this.PlatformIncome);
            this.SetParamSimple(map, prefix + "ProductDetail", this.ProductDetail);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SubOutTradeNo", this.SubOutTradeNo);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "OriginalAmt", this.OriginalAmt);
        }
    }
}

