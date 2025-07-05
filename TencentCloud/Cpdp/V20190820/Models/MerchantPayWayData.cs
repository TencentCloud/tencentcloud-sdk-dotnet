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

    public class MerchantPayWayData : AbstractModel
    {
        
        /// <summary>
        /// 支付币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayCurrency")]
        public string PayCurrency{ get; set; }

        /// <summary>
        /// 支付图标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayIcon")]
        public string PayIcon{ get; set; }

        /// <summary>
        /// 支付名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayInternalName")]
        public string PayInternalName{ get; set; }

        /// <summary>
        /// 支付简称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// 是否支持退款
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaySplitRefund")]
        public string PaySplitRefund{ get; set; }

        /// <summary>
        /// 支付标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayTag")]
        public string PayTag{ get; set; }

        /// <summary>
        /// 支付凭证图标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayTicketIcon")]
        public string PayTicketIcon{ get; set; }

        /// <summary>
        /// 支付类型，逗号分隔
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 凭证名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TicketName")]
        public string TicketName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayCurrency", this.PayCurrency);
            this.SetParamSimple(map, prefix + "PayIcon", this.PayIcon);
            this.SetParamSimple(map, prefix + "PayInternalName", this.PayInternalName);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamSimple(map, prefix + "PaySplitRefund", this.PaySplitRefund);
            this.SetParamSimple(map, prefix + "PayTag", this.PayTag);
            this.SetParamSimple(map, prefix + "PayTicketIcon", this.PayTicketIcon);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "TicketName", this.TicketName);
        }
    }
}

