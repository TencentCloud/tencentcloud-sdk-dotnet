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

    public class ClearItem : AbstractModel
    {
        
        /// <summary>
        /// STRING(8)，日期（格式: 20190101）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// STRING(40)，子账号类型（子帐号类型。1: 普通会员子账号; 2: 挂账子账号; 3: 手续费子账号; 4: 利息子账号; 5: 平台担保子账号; 7: 在途; 8: 理财购买子帐号; 9: 理财赎回子帐号; 10: 平台子拥有结算子帐号）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctType")]
        public string SubAcctType{ get; set; }

        /// <summary>
        /// STRING(3)，对账状态（0: 成功; 1: 失败）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReconcileStatus")]
        public string ReconcileStatus{ get; set; }

        /// <summary>
        /// STRING(300)，对账返回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReconcileReturnMsg")]
        public string ReconcileReturnMsg{ get; set; }

        /// <summary>
        /// STRING(20)，清算状态（0: 成功; 1: 失败; 2: 异常; 3: 待处理）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClearingStatus")]
        public string ClearingStatus{ get; set; }

        /// <summary>
        /// STRING(2)，清算返回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClearingReturnMsg")]
        public string ClearingReturnMsg{ get; set; }

        /// <summary>
        /// STRING(300)，待清算总金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAmt")]
        public string TotalAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "SubAcctType", this.SubAcctType);
            this.SetParamSimple(map, prefix + "ReconcileStatus", this.ReconcileStatus);
            this.SetParamSimple(map, prefix + "ReconcileReturnMsg", this.ReconcileReturnMsg);
            this.SetParamSimple(map, prefix + "ClearingStatus", this.ClearingStatus);
            this.SetParamSimple(map, prefix + "ClearingReturnMsg", this.ClearingReturnMsg);
            this.SetParamSimple(map, prefix + "TotalAmt", this.TotalAmt);
        }
    }
}

