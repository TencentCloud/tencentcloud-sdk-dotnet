/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrgMemberAccountBalanceData : AbstractModel
    {
        
        /// <summary>
        /// <p>成员账号Uin</p>
        /// </summary>
        [JsonProperty("MemberUin")]
        public string MemberUin{ get; set; }

        /// <summary>
        /// <p>成员名称</p>
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// <p>是否为信用账户</p>
        /// </summary>
        [JsonProperty("IsCreditAccount")]
        public bool? IsCreditAccount{ get; set; }

        /// <summary>
        /// <p>当前真实可用余额</p><p>单位：分</p>
        /// </summary>
        [JsonProperty("RealBalance")]
        public float? RealBalance{ get; set; }

        /// <summary>
        /// <p>现金账户余额</p><p>单位：分</p>
        /// </summary>
        [JsonProperty("CashAccountBalance")]
        public float? CashAccountBalance{ get; set; }

        /// <summary>
        /// <p>信用额度</p><p>单位：分</p><p>信用额度 = 基础信用额度 + 临时信用额度</p>
        /// </summary>
        [JsonProperty("CreditAmount")]
        public float? CreditAmount{ get; set; }

        /// <summary>
        /// <p>临时信用额度</p><p>单位：分</p>
        /// </summary>
        [JsonProperty("TempCredit")]
        public float? TempCredit{ get; set; }

        /// <summary>
        /// <p>基础信用额度</p><p>单位：分</p>
        /// </summary>
        [JsonProperty("BasicCreditAmount")]
        public float? BasicCreditAmount{ get; set; }

        /// <summary>
        /// <p>欠费金额</p><p>单位：分</p>
        /// </summary>
        [JsonProperty("OweAmount")]
        public float? OweAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "IsCreditAccount", this.IsCreditAccount);
            this.SetParamSimple(map, prefix + "RealBalance", this.RealBalance);
            this.SetParamSimple(map, prefix + "CashAccountBalance", this.CashAccountBalance);
            this.SetParamSimple(map, prefix + "CreditAmount", this.CreditAmount);
            this.SetParamSimple(map, prefix + "TempCredit", this.TempCredit);
            this.SetParamSimple(map, prefix + "BasicCreditAmount", this.BasicCreditAmount);
            this.SetParamSimple(map, prefix + "OweAmount", this.OweAmount);
        }
    }
}

