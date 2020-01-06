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

    public class WithdrawCashMembershipRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(150)，交易网名称（市场名称）
        /// </summary>
        [JsonProperty("TranWebName")]
        public string TranWebName{ get; set; }

        /// <summary>
        /// STRING(5)，会员证件类型（详情见“常见问题”）
        /// </summary>
        [JsonProperty("MemberGlobalType")]
        public string MemberGlobalType{ get; set; }

        /// <summary>
        /// STRING(32)，会员证件号码
        /// </summary>
        [JsonProperty("MemberGlobalId")]
        public string MemberGlobalId{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，会员名称
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// STRING(50)，提现账号（银行卡）
        /// </summary>
        [JsonProperty("TakeCashAcctNo")]
        public string TakeCashAcctNo{ get; set; }

        /// <summary>
        /// STRING(150)，出金账户名称（银行卡户名）
        /// </summary>
        [JsonProperty("OutAmtAcctName")]
        public string OutAmtAcctName{ get; set; }

        /// <summary>
        /// STRING(3)，币种（默认为RMB）
        /// </summary>
        [JsonProperty("Ccy")]
        public string Ccy{ get; set; }

        /// <summary>
        /// STRING(20)，可提现金额
        /// </summary>
        [JsonProperty("CashAmt")]
        public string CashAmt{ get; set; }

        /// <summary>
        /// STRING(300)，备注（建议可送订单号，可在对账文件的备注字段获取到）
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// STRING(1027)，保留域
        /// </summary>
        [JsonProperty("ReservedMsg")]
        public string ReservedMsg{ get; set; }

        /// <summary>
        /// STRING(300)，网银签名
        /// </summary>
        [JsonProperty("WebSign")]
        public string WebSign{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "TranWebName", this.TranWebName);
            this.SetParamSimple(map, prefix + "MemberGlobalType", this.MemberGlobalType);
            this.SetParamSimple(map, prefix + "MemberGlobalId", this.MemberGlobalId);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "TakeCashAcctNo", this.TakeCashAcctNo);
            this.SetParamSimple(map, prefix + "OutAmtAcctName", this.OutAmtAcctName);
            this.SetParamSimple(map, prefix + "Ccy", this.Ccy);
            this.SetParamSimple(map, prefix + "CashAmt", this.CashAmt);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
            this.SetParamSimple(map, prefix + "WebSign", this.WebSign);
        }
    }
}

