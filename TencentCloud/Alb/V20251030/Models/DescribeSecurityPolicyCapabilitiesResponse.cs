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

    public class DescribeSecurityPolicyCapabilitiesResponse : AbstractModel
    {
        
        /// <summary>
        /// 安全策略配置能力列表。返回当前地域支持的所有 TLS 版本及其对应的加密套件信息。
        /// 
        /// **返回内容包含：**
        /// - 支持的 TLS 协议版本（如 TLSv1.0、TLSv1.1、TLSv1.2、TLSv1.3）。
        /// - 每个 TLS 版本支持的加密套件列表。
        /// 
        /// **使用场景：**
        /// - 在创建安全策略（CreateSecurityPolicy）前，调用此接口获取可选的加密套件。
        /// - 在修改安全策略（ModifySecurityPolicyAttributes）前，确认新配置的有效性。
        /// </summary>
        [JsonProperty("SecurityPolicyCapabilities")]
        public SecurityPolicyCapability[] SecurityPolicyCapabilities{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SecurityPolicyCapabilities.", this.SecurityPolicyCapabilities);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

