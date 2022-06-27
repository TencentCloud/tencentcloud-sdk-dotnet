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

    public class OpenBankQueryRefundOrderResult : AbstractModel
    {
        
        /// <summary>
        /// 外部商户退款单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutRefundId")]
        public string OutRefundId{ get; set; }

        /// <summary>
        /// 渠道退款单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelRefundId")]
        public string ChannelRefundId{ get; set; }

        /// <summary>
        /// 退款原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundReason")]
        public string RefundReason{ get; set; }

        /// <summary>
        /// 退款金额，单位分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundAmount")]
        public long? RefundAmount{ get; set; }

        /// <summary>
        /// 实际退款金额，单位分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealRefundAmount")]
        public long? RealRefundAmount{ get; set; }

        /// <summary>
        /// 原支付订单总金额，单位分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 退款完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFinish")]
        public string TimeFinish{ get; set; }

        /// <summary>
        /// 退款订单状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundStatus")]
        public string RefundStatus{ get; set; }

        /// <summary>
        /// 退款明细信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundInfo")]
        public string RefundInfo{ get; set; }

        /// <summary>
        /// 退款手续费金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeAmount")]
        public long? FeeAmount{ get; set; }

        /// <summary>
        /// 退款返回描述，比如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundMessage")]
        public string RefundMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutRefundId", this.OutRefundId);
            this.SetParamSimple(map, prefix + "ChannelRefundId", this.ChannelRefundId);
            this.SetParamSimple(map, prefix + "RefundReason", this.RefundReason);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "RealRefundAmount", this.RealRefundAmount);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "TimeFinish", this.TimeFinish);
            this.SetParamSimple(map, prefix + "RefundStatus", this.RefundStatus);
            this.SetParamSimple(map, prefix + "RefundInfo", this.RefundInfo);
            this.SetParamSimple(map, prefix + "FeeAmount", this.FeeAmount);
            this.SetParamSimple(map, prefix + "RefundMessage", this.RefundMessage);
        }
    }
}

