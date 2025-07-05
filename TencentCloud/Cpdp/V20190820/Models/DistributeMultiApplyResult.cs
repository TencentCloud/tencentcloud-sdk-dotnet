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

    public class DistributeMultiApplyResult : AbstractModel
    {
        
        /// <summary>
        /// 分账状态（0分账初始 1分账成功 2分账失败）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 平台分账单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DistributeNo")]
        public string DistributeNo{ get; set; }

        /// <summary>
        /// 入账日期，yyyy-MM-dd格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InDate")]
        public string InDate{ get; set; }

        /// <summary>
        /// 分账金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 商户分账单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutDistributeNo")]
        public string OutDistributeNo{ get; set; }

        /// <summary>
        /// 平台支付单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DistributeNo", this.DistributeNo);
            this.SetParamSimple(map, prefix + "InDate", this.InDate);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "OutDistributeNo", this.OutDistributeNo);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
        }
    }
}

