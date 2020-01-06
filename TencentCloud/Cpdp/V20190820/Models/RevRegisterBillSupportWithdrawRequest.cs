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

    public class RevRegisterBillSupportWithdrawRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(30)，原订单号（RegisterBillSupportWithdraw接口中的订单号）
        /// </summary>
        [JsonProperty("OldOrderNo")]
        public string OldOrderNo{ get; set; }

        /// <summary>
        /// STRING(20)，撤销金额（支持部分撤销，不能大于原订单可用金额，包含交易费用）
        /// </summary>
        [JsonProperty("CancelAmt")]
        public string CancelAmt{ get; set; }

        /// <summary>
        /// STRING(20)，交易费用（暂未使用，默认传0.0）
        /// </summary>
        [JsonProperty("TranFee")]
        public string TranFee{ get; set; }

        /// <summary>
        /// STRING(300)，备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// STRING(300)，保留域1
        /// </summary>
        [JsonProperty("ReservedMsgOne")]
        public string ReservedMsgOne{ get; set; }

        /// <summary>
        /// STRING(300)，保留域2
        /// </summary>
        [JsonProperty("ReservedMsgTwo")]
        public string ReservedMsgTwo{ get; set; }

        /// <summary>
        /// STRING(300)，保留域3
        /// </summary>
        [JsonProperty("ReservedMsgThree")]
        public string ReservedMsgThree{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "OldOrderNo", this.OldOrderNo);
            this.SetParamSimple(map, prefix + "CancelAmt", this.CancelAmt);
            this.SetParamSimple(map, prefix + "TranFee", this.TranFee);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReservedMsgOne", this.ReservedMsgOne);
            this.SetParamSimple(map, prefix + "ReservedMsgTwo", this.ReservedMsgTwo);
            this.SetParamSimple(map, prefix + "ReservedMsgThree", this.ReservedMsgThree);
        }
    }
}

