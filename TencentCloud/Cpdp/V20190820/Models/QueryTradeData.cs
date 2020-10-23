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

    public class QueryTradeData : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

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
        /// 审核状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

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
        /// 收款人常驻国家或地区编码
        /// </summary>
        [JsonProperty("PayeeCountryCode")]
        public string PayeeCountryCode{ get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("TradeType")]
        public string TradeType{ get; set; }

        /// <summary>
        /// 交易日期
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
        public string TradeAmount{ get; set; }

        /// <summary>
        /// 交易名称
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 交易数量
        /// </summary>
        [JsonProperty("TradeCount")]
        public long? TradeCount{ get; set; }

        /// <summary>
        /// 货贸承运人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GoodsCarrier")]
        public string GoodsCarrier{ get; set; }

        /// <summary>
        /// 服贸交易细节
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDetail")]
        public string ServiceDetail{ get; set; }

        /// <summary>
        /// 服贸服务时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTime")]
        public string ServiceTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "TradeFileId", this.TradeFileId);
            this.SetParamSimple(map, prefix + "TradeOrderId", this.TradeOrderId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
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
        }
    }
}

