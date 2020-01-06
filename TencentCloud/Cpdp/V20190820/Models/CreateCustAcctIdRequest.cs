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

    public class CreateCustAcctIdRequest : AbstractModel
    {
        
        /// <summary>
        /// STRING(2)，功能标志（1: 开户; 3: 销户）
        /// </summary>
        [JsonProperty("FunctionFlag")]
        public string FunctionFlag{ get; set; }

        /// <summary>
        /// STRING(50)，资金汇总账号（即收单资金归集入账的账号）
        /// </summary>
        [JsonProperty("FundSummaryAcctNo")]
        public string FundSummaryAcctNo{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码（平台端的用户ID，需要保证唯一性，可数字字母混合，如HY_120）
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(10)，会员属性（00-普通子账户(默认); SH-商户子账户）
        /// </summary>
        [JsonProperty("MemberProperty")]
        public string MemberProperty{ get; set; }

        /// <summary>
        /// STRING(30)，手机号码
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// String(2)，是否为自营业务（0位非自营，1为自营）
        /// </summary>
        [JsonProperty("SelfBusiness")]
        public bool? SelfBusiness{ get; set; }

        /// <summary>
        /// String(64)，联系人
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// String(64)，子账户名称
        /// </summary>
        [JsonProperty("SubAcctName")]
        public string SubAcctName{ get; set; }

        /// <summary>
        /// String(64)，子账户简称
        /// </summary>
        [JsonProperty("SubAcctShortName")]
        public string SubAcctShortName{ get; set; }

        /// <summary>
        /// String(4)，子账户类型（0: 个人子账户; 1: 企业子账户）
        /// </summary>
        [JsonProperty("SubAcctType")]
        public long? SubAcctType{ get; set; }

        /// <summary>
        /// STRING(150)，用户昵称
        /// </summary>
        [JsonProperty("UserNickname")]
        public string UserNickname{ get; set; }

        /// <summary>
        /// STRING(150)，邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

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
            this.SetParamSimple(map, prefix + "FunctionFlag", this.FunctionFlag);
            this.SetParamSimple(map, prefix + "FundSummaryAcctNo", this.FundSummaryAcctNo);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberProperty", this.MemberProperty);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "SelfBusiness", this.SelfBusiness);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "SubAcctName", this.SubAcctName);
            this.SetParamSimple(map, prefix + "SubAcctShortName", this.SubAcctShortName);
            this.SetParamSimple(map, prefix + "SubAcctType", this.SubAcctType);
            this.SetParamSimple(map, prefix + "UserNickname", this.UserNickname);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
        }
    }
}

