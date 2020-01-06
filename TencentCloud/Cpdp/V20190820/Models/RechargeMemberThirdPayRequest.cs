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

    public class RechargeMemberThirdPayRequest : AbstractModel
    {
        
        /// <summary>
        /// STRING(32)，交易网会代码
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(20)，会员充值金额
        /// </summary>
        [JsonProperty("MemberFillAmt")]
        public string MemberFillAmt{ get; set; }

        /// <summary>
        /// STRING(20)，手续费金额
        /// </summary>
        [JsonProperty("Commission")]
        public string Commission{ get; set; }

        /// <summary>
        /// STRING(3)，币种
        /// </summary>
        [JsonProperty("Ccy")]
        public string Ccy{ get; set; }

        /// <summary>
        /// STRING(20)，支付渠道类型
        /// </summary>
        [JsonProperty("PayChannelType")]
        public string PayChannelType{ get; set; }

        /// <summary>
        /// STRING(50)，支付渠道所分配的商户号
        /// </summary>
        [JsonProperty("PayChannelAssignMerNo")]
        public string PayChannelAssignMerNo{ get; set; }

        /// <summary>
        /// STRING(52)，支付渠道交易流水号
        /// </summary>
        [JsonProperty("PayChannelTranSeqNo")]
        public string PayChannelTranSeqNo{ get; set; }

        /// <summary>
        /// STRING(52)，电商见证宝订单号
        /// </summary>
        [JsonProperty("EjzbOrderNo")]
        public string EjzbOrderNo{ get; set; }

        /// <summary>
        /// String(22)，商户号
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(500)，电商见证宝订单内容
        /// </summary>
        [JsonProperty("EjzbOrderContent")]
        public string EjzbOrderContent{ get; set; }

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
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberFillAmt", this.MemberFillAmt);
            this.SetParamSimple(map, prefix + "Commission", this.Commission);
            this.SetParamSimple(map, prefix + "Ccy", this.Ccy);
            this.SetParamSimple(map, prefix + "PayChannelType", this.PayChannelType);
            this.SetParamSimple(map, prefix + "PayChannelAssignMerNo", this.PayChannelAssignMerNo);
            this.SetParamSimple(map, prefix + "PayChannelTranSeqNo", this.PayChannelTranSeqNo);
            this.SetParamSimple(map, prefix + "EjzbOrderNo", this.EjzbOrderNo);
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "EjzbOrderContent", this.EjzbOrderContent);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReservedMsgOne", this.ReservedMsgOne);
            this.SetParamSimple(map, prefix + "ReservedMsgTwo", this.ReservedMsgTwo);
            this.SetParamSimple(map, prefix + "ReservedMsgThree", this.ReservedMsgThree);
        }
    }
}

