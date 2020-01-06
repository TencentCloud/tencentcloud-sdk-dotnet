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

    public class ModifyMntMbrBindRelateAcctBankCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(50)，见证子账户的账号
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// STRING(50)，会员绑定账号
        /// </summary>
        [JsonProperty("MemberBindAcctNo")]
        public string MemberBindAcctNo{ get; set; }

        /// <summary>
        /// STRING(150)，开户行名称（若大小额行号不填则送超级网银号对应的银行名称，若填大小额行号则送大小额行号对应的银行名称）
        /// </summary>
        [JsonProperty("AcctOpenBranchName")]
        public string AcctOpenBranchName{ get; set; }

        /// <summary>
        /// STRING(20)，大小额行号（CnapsBranchId和EiconBankBranchId两者二选一必填）
        /// </summary>
        [JsonProperty("CnapsBranchId")]
        public string CnapsBranchId{ get; set; }

        /// <summary>
        /// STRING(20)，超级网银行号
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
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "MemberBindAcctNo", this.MemberBindAcctNo);
            this.SetParamSimple(map, prefix + "AcctOpenBranchName", this.AcctOpenBranchName);
            this.SetParamSimple(map, prefix + "CnapsBranchId", this.CnapsBranchId);
            this.SetParamSimple(map, prefix + "EiconBankBranchId", this.EiconBankBranchId);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
        }
    }
}

