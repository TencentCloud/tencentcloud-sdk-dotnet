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

    public class QueryOutwardOrderData : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 对接方汇出指令编号
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 财务日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AcctDate")]
        public string AcctDate{ get; set; }

        /// <summary>
        /// 定价币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PricingCurrency")]
        public string PricingCurrency{ get; set; }

        /// <summary>
        /// 源币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceCurrency")]
        public string SourceCurrency{ get; set; }

        /// <summary>
        /// 源金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceAmount")]
        public string SourceAmount{ get; set; }

        /// <summary>
        /// 目的币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetCurrency")]
        public string TargetCurrency{ get; set; }

        /// <summary>
        /// 目的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAmount")]
        public string TargetAmount{ get; set; }

        /// <summary>
        /// 汇率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FxRate")]
        public string FxRate{ get; set; }

        /// <summary>
        /// 指令状态
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
        /// 退汇金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundAmount")]
        public string RefundAmount{ get; set; }

        /// <summary>
        /// 退汇币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundCurrency")]
        public string RefundCurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "AcctDate", this.AcctDate);
            this.SetParamSimple(map, prefix + "PricingCurrency", this.PricingCurrency);
            this.SetParamSimple(map, prefix + "SourceCurrency", this.SourceCurrency);
            this.SetParamSimple(map, prefix + "SourceAmount", this.SourceAmount);
            this.SetParamSimple(map, prefix + "TargetCurrency", this.TargetCurrency);
            this.SetParamSimple(map, prefix + "TargetAmount", this.TargetAmount);
            this.SetParamSimple(map, prefix + "FxRate", this.FxRate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "RefundCurrency", this.RefundCurrency);
        }
    }
}

