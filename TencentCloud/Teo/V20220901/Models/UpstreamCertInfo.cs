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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamCertInfo : AbstractModel
    {
        
        /// <summary>
        /// 在回源双向认证场景下，该字段为 EO 节点回源时携带的证书（包含公钥、私钥即可），部署在 EO 节点，用于源站对 EO 节点进行认证。在作为入参使用时，不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("UpstreamMutualTLS")]
        public MutualTLS UpstreamMutualTLS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UpstreamMutualTLS.", this.UpstreamMutualTLS);
        }
    }
}

