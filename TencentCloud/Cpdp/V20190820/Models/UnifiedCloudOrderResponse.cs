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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnifiedCloudOrderResponse : AbstractModel
    {
        
        /// <summary>
        /// 米大师的交易订单号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 开发者的支付订单号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// SDK的支付参数。
        /// 支付参数透传给米大师SDK（原文透传给SDK即可，不需要解码）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayInfo")]
        public string PayInfo{ get; set; }

        /// <summary>
        /// 支付金额，单位：分。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAmt")]
        public long? TotalAmt{ get; set; }

        /// <summary>
        /// 渠道信息，用于拉起渠道支付。j
        /// son字符串，注意此字段仅会在传入正确的PayScene入参时才会有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelInfo")]
        public string ChannelInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "PayInfo", this.PayInfo);
            this.SetParamSimple(map, prefix + "TotalAmt", this.TotalAmt);
            this.SetParamSimple(map, prefix + "ChannelInfo", this.ChannelInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

