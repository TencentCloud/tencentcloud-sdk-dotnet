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

    public class BindRelateAcctUnionPayRequest : AbstractModel
    {
        
        /// <summary>
        /// STRING(32)，交易网会员代码（若需要把一个待绑定账户关联到两个会员名下，此字段可上送两个会员的交易网代码，并且须用“|::|”（右侧）进行分隔）
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，见证子账户的户名（首次绑定的情况下，此字段即为待绑定的提现账户的户名。非首次绑定的情况下，须注意带绑定的提现账户的户名须与留存在后台系统的会员户名一致）
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

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
        /// STRING(50)，会员的待绑定账户的账号（提现的银行卡）
        /// </summary>
        [JsonProperty("MemberAcctNo")]
        public string MemberAcctNo{ get; set; }

        /// <summary>
        /// STRING(10)，会员的待绑定账户的本他行类型（1: 本行; 2: 他行）
        /// </summary>
        [JsonProperty("BankType")]
        public string BankType{ get; set; }

        /// <summary>
        /// STRING(150)，会员的待绑定账户的开户行名称（若大小额行号不填则送超级网银号对应的银行名称，若填大小额行号则送大小额行号对应的银行名称）
        /// </summary>
        [JsonProperty("AcctOpenBranchName")]
        public string AcctOpenBranchName{ get; set; }

        /// <summary>
        /// STRING(30)，会员的手机号（手机号须由长度为11位的数字构成）
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(20)，会员的待绑定账户的开户行的联行号（本他行类型为他行的情况下，此字段和下一个字段至少一个不为空）
        /// </summary>
        [JsonProperty("CnapsBranchId")]
        public string CnapsBranchId{ get; set; }

        /// <summary>
        /// STRING(20)，会员的待绑定账户的开户行的超级网银行号（本他行类型为他行的情况下，此字段和上一个字段至少一个不为空）
        /// </summary>
        [JsonProperty("EiconBankBranchId")]
        public string EiconBankBranchId{ get; set; }

        /// <summary>
        /// STRING(1027)，保留域
        /// </summary>
        [JsonProperty("ReservedMsg")]
        public string ReservedMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "MemberGlobalType", this.MemberGlobalType);
            this.SetParamSimple(map, prefix + "MemberGlobalId", this.MemberGlobalId);
            this.SetParamSimple(map, prefix + "MemberAcctNo", this.MemberAcctNo);
            this.SetParamSimple(map, prefix + "BankType", this.BankType);
            this.SetParamSimple(map, prefix + "AcctOpenBranchName", this.AcctOpenBranchName);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "CnapsBranchId", this.CnapsBranchId);
            this.SetParamSimple(map, prefix + "EiconBankBranchId", this.EiconBankBranchId);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
        }
    }
}

