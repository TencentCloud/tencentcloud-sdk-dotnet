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

    public class ApplyTradeRequest : AbstractModel
    {
        
        /// <summary>
        /// 贸易材料流水号
        /// </summary>
        [JsonProperty("TradeFileId")]
        public string TradeFileId{ get; set; }

        /// <summary>
        /// 贸易材料订单号
        /// </summary>
        [JsonProperty("TradeOrderId")]
        public string TradeOrderId{ get; set; }

        /// <summary>
        /// 付款人ID
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }

        /// <summary>
        /// 收款人常驻国家或地区编码 (见常见问题)
        /// </summary>
        [JsonProperty("PayeeCountryCode")]
        public string PayeeCountryCode{ get; set; }

        /// <summary>
        /// 贸易类型 (GOODS: 商品, SERVICE: 服务)
        /// </summary>
        [JsonProperty("TradeType")]
        public string TradeType{ get; set; }

        /// <summary>
        /// 交易时间 (格式: yyyyMMdd)
        /// </summary>
        [JsonProperty("TradeTime")]
        public string TradeTime{ get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [JsonProperty("TradeCurrency")]
        public string TradeCurrency{ get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("TradeAmount")]
        public float? TradeAmount{ get; set; }

        /// <summary>
        /// 交易名称 
        /// (TradeType=GOODS时填写物品名称，可填写多个，格式无要求；
        /// TradeType=SERVICE时填写贸易类别，见常见问题-贸易类别)
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 交易数量 (TradeType=GOODS 填写物品数量, TradeType=SERVICE填写服务次数)
        /// </summary>
        [JsonProperty("TradeCount")]
        public long? TradeCount{ get; set; }

        /// <summary>
        /// 货贸承运人 (TradeType=GOODS 必填)
        /// </summary>
        [JsonProperty("GoodsCarrier")]
        public string GoodsCarrier{ get; set; }

        /// <summary>
        /// 服贸交易细节 (TradeType=GOODS 必填, 见常见问题-交易细节)
        /// </summary>
        [JsonProperty("ServiceDetail")]
        public string ServiceDetail{ get; set; }

        /// <summary>
        /// 服贸服务时间 (TradeType=GOODS 必填, 见常见问题-服务时间)
        /// </summary>
        [JsonProperty("ServiceTime")]
        public string ServiceTime{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TradeFileId", this.TradeFileId);
            this.SetParamSimple(map, prefix + "TradeOrderId", this.TradeOrderId);
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
            this.SetParamSimple(map, prefix + "PayeeCountryCode", this.PayeeCountryCode);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "TradeTime", this.TradeTime);
            this.SetParamSimple(map, prefix + "TradeCurrency", this.TradeCurrency);
            this.SetParamSimple(map, prefix + "TradeAmount", this.TradeAmount);
            this.SetParamSimple(map, prefix + "TradeName", this.TradeName);
            this.SetParamSimple(map, prefix + "TradeCount", this.TradeCount);
            this.SetParamSimple(map, prefix + "GoodsCarrier", this.GoodsCarrier);
            this.SetParamSimple(map, prefix + "ServiceDetail", this.ServiceDetail);
            this.SetParamSimple(map, prefix + "ServiceTime", this.ServiceTime);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

