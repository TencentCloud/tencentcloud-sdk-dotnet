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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOpenBankVerificationResult : AbstractModel
    {
        
        /// <summary>
        /// 云企付渠道核销订单号
        /// </summary>
        [JsonProperty("ChannelVerificationId")]
        public string ChannelVerificationId{ get; set; }

        /// <summary>
        /// 第三方支付渠道核销订单号
        /// </summary>
        [JsonProperty("ThirdVerificationId")]
        public string ThirdVerificationId{ get; set; }

        /// <summary>
        /// 核销状态
        /// INIT("INIT","初始化"),
        /// SUCCESS("SUCCESS","核销成功"),
        /// FAILED("FAILED","核销失败"),
        /// PROCESSING("PROCESSING","核销中");
        /// </summary>
        [JsonProperty("VerificationStatus")]
        public string VerificationStatus{ get; set; }

        /// <summary>
        /// 核销金额，单位分
        /// </summary>
        [JsonProperty("VerificationAmount")]
        public long? VerificationAmount{ get; set; }

        /// <summary>
        /// 渠道附加返回信息，一般情况可以不关注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThirdVerificationReturnInfo")]
        public string ThirdVerificationReturnInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelVerificationId", this.ChannelVerificationId);
            this.SetParamSimple(map, prefix + "ThirdVerificationId", this.ThirdVerificationId);
            this.SetParamSimple(map, prefix + "VerificationStatus", this.VerificationStatus);
            this.SetParamSimple(map, prefix + "VerificationAmount", this.VerificationAmount);
            this.SetParamSimple(map, prefix + "ThirdVerificationReturnInfo", this.ThirdVerificationReturnInfo);
        }
    }
}

