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

    public class OldSubRefund : AbstractModel
    {
        
        /// <summary>
        /// 支付机构退款流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelExternalRefundId")]
        public string ChannelExternalRefundId{ get; set; }

        /// <summary>
        /// 支付机构支付订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelExternalOrderId")]
        public string ChannelExternalOrderId{ get; set; }

        /// <summary>
        /// 渠道退款订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelRefundId")]
        public string ChannelRefundId{ get; set; }

        /// <summary>
        /// 子订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubOutTradeNo")]
        public string SubOutTradeNo{ get; set; }

        /// <summary>
        /// 子单退款金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefundAmt")]
        public string RefundAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelExternalRefundId", this.ChannelExternalRefundId);
            this.SetParamSimple(map, prefix + "ChannelExternalOrderId", this.ChannelExternalOrderId);
            this.SetParamSimple(map, prefix + "ChannelRefundId", this.ChannelRefundId);
            this.SetParamSimple(map, prefix + "SubOutTradeNo", this.SubOutTradeNo);
            this.SetParamSimple(map, prefix + "RefundAmt", this.RefundAmt);
        }
    }
}

