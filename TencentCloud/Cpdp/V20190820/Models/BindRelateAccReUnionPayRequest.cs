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

    public class BindRelateAccReUnionPayRequest : AbstractModel
    {
        
        /// <summary>
        /// String(22)，商户号（签约客户号）
        /// </summary>
        [JsonProperty("MrchCode")]
        public string MrchCode{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码（若需要把一个待绑定账户关联到两个会员名下，此字段可上送两个会员的交易网代码，并且须用“|::|”（右侧）进行分隔）
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(50)，会员的待绑定账户的账号（即 BindRelateAcctUnionPay接口中的“会员的待绑定账户的账号”）
        /// </summary>
        [JsonProperty("MemberAcctNo")]
        public string MemberAcctNo{ get; set; }

        /// <summary>
        /// STRING(20)，短信验证码（即 BindRelateAcctUnionPay接口中的手机所接收到的短信验证码）
        /// </summary>
        [JsonProperty("MessageCheckCode")]
        public string MessageCheckCode{ get; set; }

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
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "MemberAcctNo", this.MemberAcctNo);
            this.SetParamSimple(map, prefix + "MessageCheckCode", this.MessageCheckCode);
            this.SetParamSimple(map, prefix + "ReservedMsg", this.ReservedMsg);
        }
    }
}

