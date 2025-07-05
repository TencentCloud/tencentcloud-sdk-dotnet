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

    public class UpdateCredentialStateRequest : AbstractModel
    {
        
        /// <summary>
        /// DID应用Id
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }

        /// <summary>
        /// 更新VC状态的临时凭证内容，通过创建凭证接口(CreateCredential)生成并签名，凭证类型为：OperateCredential, 为安全起见凭证过期时间不适合太长，如设置为1分钟内
        /// </summary>
        [JsonProperty("OperateCredential")]
        public string OperateCredential{ get; set; }

        /// <summary>
        /// 待更新凭证状态的原始凭证内容
        /// </summary>
        [JsonProperty("OriginCredential")]
        public string OriginCredential{ get; set; }

        /// <summary>
        /// 凭证状态信息
        /// </summary>
        [JsonProperty("CredentialStatus")]
        public CredentialStatusInfo CredentialStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
            this.SetParamSimple(map, prefix + "OperateCredential", this.OperateCredential);
            this.SetParamSimple(map, prefix + "OriginCredential", this.OriginCredential);
            this.SetParamObj(map, prefix + "CredentialStatus.", this.CredentialStatus);
        }
    }
}

