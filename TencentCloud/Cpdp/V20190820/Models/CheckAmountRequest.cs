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

    public class CheckAmountRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码（若需要把一个待绑定账户关联到两个会员名下，此字段可上送两个会员的交易网代码，并且须用“|::|”(右侧)进行分隔）
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(50)，会员的待绑定账户的账号（即 BindRelateAcctSmallAmount接口中的“会员的待绑定账户的账号”）
        /// </summary>
        [JsonProperty("TakeCashAcctNo")]
        public string TakeCashAcctNo{ get; set; }

        /// <summary>
        /// STRING(20)，鉴权验证金额（即 BindRelateAcctSmallAmount接口中的“会员的待绑定账户收到的验证金额。原小额转账鉴权方式为来账鉴权的情况下此字段须赋值为0.00）
        /// </summary>
        [JsonProperty("AuthAmt")]
        public string AuthAmt{ get; set; }

        /// <summary>
        /// STRING(3)，币种（默认为RMB）
        /// </summary>
        [JsonProperty("Ccy")]
        public string Ccy{ get; set; }

        /// <summary>
        /// STRING(1027)，原小额转账方式（1: 往账鉴权，此为默认值; 2: 来账鉴权）
        /// </summary>
        [JsonProperty("ReservedMsg")]
        public string ReservedMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MrchCode", this.MrchCode);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "TakeCashAcctNo", this.TakeCashAcctNo);
            this.SetParamSimple(map, prefix + "AuthAmt", this.AuthAmt);
            this.SetParamSimple(map, prefix + "Ccy", this.Ccy);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
        }
    }
}

