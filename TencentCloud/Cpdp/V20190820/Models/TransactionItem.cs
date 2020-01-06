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

    public class TransactionItem : AbstractModel
    {
        
        /// <summary>
        /// STRING(2)，记账标志（1: 转出; 2: 转入）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BookingFlag")]
        public string BookingFlag{ get; set; }

        /// <summary>
        /// STRING(32)，交易状态（0: 成功）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranStatus")]
        public string TranStatus{ get; set; }

        /// <summary>
        /// STRING(20)，交易金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranAmt")]
        public string TranAmt{ get; set; }

        /// <summary>
        /// STRING(8)，交易日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranDate")]
        public string TranDate{ get; set; }

        /// <summary>
        /// STRING(20)，交易时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranTime")]
        public string TranTime{ get; set; }

        /// <summary>
        /// STRING(52)，见证系统流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontSeqNo")]
        public string FrontSeqNo{ get; set; }

        /// <summary>
        /// STRING(20)，记账类型（详情见“常见问题”）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BookingType")]
        public string BookingType{ get; set; }

        /// <summary>
        /// STRING(50)，转入见证子账户的帐号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InSubAcctNo")]
        public string InSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(50)，转出见证子账户的帐号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutSubAcctNo")]
        public string OutSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(300)，备注（返回交易订单号）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BookingFlag", this.BookingFlag);
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
            this.SetParamSimple(map, prefix + "TranAmt", this.TranAmt);
            this.SetParamSimple(map, prefix + "TranDate", this.TranDate);
            this.SetParamSimple(map, prefix + "TranTime", this.TranTime);
            this.SetParamSimple(map, prefix + "FrontSeqNo", this.FrontSeqNo);
            this.SetParamSimple(map, prefix + "BookingType", this.BookingType);
            this.SetParamSimple(map, prefix + "InSubAcctNo", this.InSubAcctNo);
            this.SetParamSimple(map, prefix + "OutSubAcctNo", this.OutSubAcctNo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

