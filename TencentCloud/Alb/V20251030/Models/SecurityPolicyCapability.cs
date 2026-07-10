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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityPolicyCapability : AbstractModel
    {
        
        /// <summary>
        /// 支持的加密套件列表。
        /// </summary>
        [JsonProperty("Ciphers")]
        public string[] Ciphers{ get; set; }

        /// <summary>
        /// 支持的 TLS 协议版本。可选值包括：TLSv1.0、TLSv1.1、TLSv1.2、TLSv1.3。
        /// </summary>
        [JsonProperty("TLSVersion")]
        public string TLSVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
        }
    }
}

