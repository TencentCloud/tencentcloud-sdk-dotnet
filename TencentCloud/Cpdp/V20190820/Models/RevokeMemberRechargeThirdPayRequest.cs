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

    public class RevokeMemberRechargeThirdPayRequest : AbstractModel
    {
        
        /// <summary>
        /// STRING(52)，原充值的前置流水号
        /// </summary>
        [JsonProperty("OldFillFrontSeqNo")]
        public string OldFillFrontSeqNo{ get; set; }

        /// <summary>
        /// STRING(20)，原充值的支付渠道类型
        /// </summary>
        [JsonProperty("OldFillPayChannelType")]
        public string OldFillPayChannelType{ get; set; }

        /// <summary>
        /// STRING(52)，原充值的支付渠道交易流水号
        /// </summary>
        [JsonProperty("OldPayChannelTranSeqNo")]
        public string OldPayChannelTranSeqNo{ get; set; }

        /// <summary>
        /// STRING(52)，原充值的电商见证宝订单号
        /// </summary>
        [JsonProperty("OldFillEjzbOrderNo")]
        public string OldFillEjzbOrderNo{ get; set; }

        /// <summary>
        /// STRING(20)，申请撤销的会员金额
        /// </summary>
        [JsonProperty("ApplyCancelMemberAmt")]
        public string ApplyCancelMemberAmt{ get; set; }

        /// <summary>
        /// STRING(20)，申请撤销的手续费金额
        /// </summary>
        [JsonProperty("ApplyCancelCommission")]
        public string ApplyCancelCommission{ get; set; }

        /// <summary>
        /// String(22)，商户号
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

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
            this.SetParamSimple(map, prefix + "OldFillFrontSeqNo", this.OldFillFrontSeqNo);
            this.SetParamSimple(map, prefix + "OldFillPayChannelType", this.OldFillPayChannelType);
            this.SetParamSimple(map, prefix + "OldPayChannelTranSeqNo", this.OldPayChannelTranSeqNo);
            this.SetParamSimple(map, prefix + "OldFillEjzbOrderNo", this.OldFillEjzbOrderNo);
            this.SetParamSimple(map, prefix + "ApplyCancelMemberAmt", this.ApplyCancelMemberAmt);
            this.SetParamSimple(map, prefix + "ApplyCancelCommission", this.ApplyCancelCommission);
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReservedMsgOne", this.ReservedMsgOne);
            this.SetParamSimple(map, prefix + "ReservedMsgTwo", this.ReservedMsgTwo);
            this.SetParamSimple(map, prefix + "ReservedMsgThree", this.ReservedMsgThree);
        }
    }
}

