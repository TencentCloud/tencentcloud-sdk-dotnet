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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyCredentialsRequest : AbstractModel
    {
        
        /// <summary>
        /// 0:仅验证签名，1:验证签名和链上状态，2, 仅验证链上状态，默认为0, 3.验证DID和凭证状态以及签名，4. 验证历史凭证有效性
        /// </summary>
        [JsonProperty("VerifyType")]
        public ulong? VerifyType{ get; set; }

        /// <summary>
        /// 凭证内容
        /// </summary>
        [JsonProperty("CredentialData")]
        public string CredentialData{ get; set; }

        /// <summary>
        /// DID应用id
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "CredentialData", this.CredentialData);
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
        }
    }
}

