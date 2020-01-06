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

    public class QuerySingleTransactionStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// String(20)，返回码
        /// </summary>
        [JsonProperty("TxnReturnCode")]
        public string TxnReturnCode{ get; set; }

        /// <summary>
        /// String(100)，返回信息
        /// </summary>
        [JsonProperty("TxnReturnMsg")]
        public string TxnReturnMsg{ get; set; }

        /// <summary>
        /// String(22)，交易流水号
        /// </summary>
        [JsonProperty("CnsmrSeqNo")]
        public string CnsmrSeqNo{ get; set; }

        /// <summary>
        /// STRING(2)，记账标志（记账标志。1: 登记挂账; 2: 支付; 3: 提现; 4: 清分; 5: 下单预支付; 6: 确认并付款; 7: 退款; 8: 支付到平台; N: 其他）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BookingFlag")]
        public string BookingFlag{ get; set; }

        /// <summary>
        /// STRING(32)，交易状态（0: 成功; 1: 失败; 2: 待确认; 5: 待处理; 6: 处理中。0和1是终态，2、5、6是中间态，其中2是特指提现后待确认提现是否成功，5是银行收到交易等待处理，6是交易正在处理）
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
        /// STRING(50)，转入子账户账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InSubAcctNo")]
        public string InSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(50)，转出子账户账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutSubAcctNo")]
        public string OutSubAcctNo{ get; set; }

        /// <summary>
        /// STRING(300)，失败信息（当提现失败时，返回交易失败原因）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailMsg")]
        public string FailMsg{ get; set; }

        /// <summary>
        /// STRING(50)，原前置流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldTranFrontSeqNo")]
        public string OldTranFrontSeqNo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TxnReturnCode", this.TxnReturnCode);
            this.SetParamSimple(map, prefix + "TxnReturnMsg", this.TxnReturnMsg);
            this.SetParamSimple(map, prefix + "CnsmrSeqNo", this.CnsmrSeqNo);
            this.SetParamSimple(map, prefix + "BookingFlag", this.BookingFlag);
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
            this.SetParamSimple(map, prefix + "TranAmt", this.TranAmt);
            this.SetParamSimple(map, prefix + "TranDate", this.TranDate);
            this.SetParamSimple(map, prefix + "TranTime", this.TranTime);
            this.SetParamSimple(map, prefix + "InSubAcctNo", this.InSubAcctNo);
            this.SetParamSimple(map, prefix + "OutSubAcctNo", this.OutSubAcctNo);
            this.SetParamSimple(map, prefix + "FailMsg", this.FailMsg);
            this.SetParamSimple(map, prefix + "OldTranFrontSeqNo", this.OldTranFrontSeqNo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

