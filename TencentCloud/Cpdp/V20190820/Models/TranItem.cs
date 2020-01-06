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

    public class TranItem : AbstractModel
    {
        
        /// <summary>
        /// STRING(50)，资金汇总账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FundSummaryAcctNo")]
        public string FundSummaryAcctNo{ get; set; }

        /// <summary>
        /// STRING(50)，见证子账户的账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，会员名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// STRING(5)，会员证件类型（详情见“常见问题”）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberGlobalType")]
        public string MemberGlobalType{ get; set; }

        /// <summary>
        /// STRING(32)，会员证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberGlobalId")]
        public string MemberGlobalId{ get; set; }

        /// <summary>
        /// STRING(50)，会员绑定账户的账号（提现的银行卡）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberAcctNo")]
        public string MemberAcctNo{ get; set; }

        /// <summary>
        /// STRING(10)，会员绑定账户的本他行类型（1: 本行; 2: 他行）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankType")]
        public string BankType{ get; set; }

        /// <summary>
        /// STRING(150)，会员绑定账户的开户行名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AcctOpenBranchName")]
        public string AcctOpenBranchName{ get; set; }

        /// <summary>
        /// STRING(20)，会员绑定账户的开户行的联行号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CnapsBranchId")]
        public string CnapsBranchId{ get; set; }

        /// <summary>
        /// STRING(20)，会员绑定账户的开户行的超级网银行号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EiconBankBranchId")]
        public string EiconBankBranchId{ get; set; }

        /// <summary>
        /// STRING(30)，会员的手机号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FundSummaryAcctNo", this.FundSummaryAcctNo);
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "MemberGlobalType", this.MemberGlobalType);
            this.SetParamSimple(map, prefix + "MemberGlobalId", this.MemberGlobalId);
            this.SetParamSimple(map, prefix + "MemberAcctNo", this.MemberAcctNo);
            this.SetParamSimple(map, prefix + "BankType", this.BankType);
            this.SetParamSimple(map, prefix + "AcctOpenBranchName", this.AcctOpenBranchName);
            this.SetParamSimple(map, prefix + "CnapsBranchId", this.CnapsBranchId);
            this.SetParamSimple(map, prefix + "EiconBankBranchId", this.EiconBankBranchId);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
        }
    }
}

