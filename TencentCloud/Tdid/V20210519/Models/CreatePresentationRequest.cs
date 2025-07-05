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

    public class CreatePresentationRequest : AbstractModel
    {
        
        /// <summary>
        /// DID应用id
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }

        /// <summary>
        /// 用户应用id
        /// </summary>
        [JsonProperty("UAPId")]
        public ulong? UAPId{ get; set; }

        /// <summary>
        /// 凭证列表
        /// </summary>
        [JsonProperty("Credentials")]
        public string[] Credentials{ get; set; }

        /// <summary>
        /// VP持有人的DID标识
        /// </summary>
        [JsonProperty("Did")]
        public string Did{ get; set; }

        /// <summary>
        /// VP随机验证码
        /// </summary>
        [JsonProperty("VerifyCode")]
        public string VerifyCode{ get; set; }

        /// <summary>
        /// 选择性披露策略
        /// </summary>
        [JsonProperty("PolicyJson")]
        public string PolicyJson{ get; set; }

        /// <summary>
        /// 是否签名，ture时signatureValue为待签名内容由调用端自行签名，false时signatureValue为平台自动已签名的内容。默认false
        /// </summary>
        [JsonProperty("Unsigned")]
        public bool? Unsigned{ get; set; }

        /// <summary>
        /// 可验证凭证证明列表
        /// </summary>
        [JsonProperty("CredentialList")]
        public CredentialProof[] CredentialList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
            this.SetParamSimple(map, prefix + "UAPId", this.UAPId);
            this.SetParamArraySimple(map, prefix + "Credentials.", this.Credentials);
            this.SetParamSimple(map, prefix + "Did", this.Did);
            this.SetParamSimple(map, prefix + "VerifyCode", this.VerifyCode);
            this.SetParamSimple(map, prefix + "PolicyJson", this.PolicyJson);
            this.SetParamSimple(map, prefix + "Unsigned", this.Unsigned);
            this.SetParamArrayObj(map, prefix + "CredentialList.", this.CredentialList);
        }
    }
}

