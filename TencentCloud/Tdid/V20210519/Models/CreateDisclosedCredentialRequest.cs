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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisclosedCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// 披露策略id，PolicyJson和PolicyId任选其一
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// 凭证文本内容，FunctionArg和CredentialText任选其一
        /// </summary>
        [JsonProperty("CredentialData")]
        public string CredentialData{ get; set; }

        /// <summary>
        /// 披露策略文本
        /// </summary>
        [JsonProperty("PolicyJson")]
        public string PolicyJson{ get; set; }

        /// <summary>
        /// DID应用ID
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "CredentialData", this.CredentialData);
            this.SetParamSimple(map, prefix + "PolicyJson", this.PolicyJson);
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
        }
    }
}

