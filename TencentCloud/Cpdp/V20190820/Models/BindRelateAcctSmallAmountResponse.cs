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

    public class BindRelateAcctSmallAmountResponse : AbstractModel
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
        /// STRING(1027)，保留域（来账鉴权的方式下，此字段的值为客户需往监管账户转入的金额。在同名子账户绑定的场景下，若返回""VERIFIED""则说明无需验证直接绑定成功）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedMsg")]
        public string ReservedMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

