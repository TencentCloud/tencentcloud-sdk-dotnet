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

    public class CreateAccelerationDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名所属站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 加速域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 源站信息。
        /// </summary>
        [JsonProperty("OriginInfo")]
        public OriginInfo OriginInfo{ get; set; }

        /// <summary>
        /// 回源协议，取值有：
        /// <li>FOLLOW: 协议跟随；</li>
        /// <li>HTTP: HTTP协议回源；</li>
        /// <li>HTTPS: HTTPS协议回源。</li>
        /// <li>不填默认为： FOLLOW。</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP回源端口，取值为1-65535，当OriginProtocol=FOLLOW/HTTP时生效, 不填默认为80。
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS回源端口，取值为1-65535，当OriginProtocol=FOLLOW/HTTPS时生效，不填默认为443。
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// IPv6状态，取值有：
        /// <li>follow：遵循站点IPv6配置；</li>
        /// <li>on：开启状态；</li>
        /// <li>off：关闭状态。</li>
        /// <li>不填默认为：follow。</li>
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamObj(map, prefix + "OriginInfo.", this.OriginInfo);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HttpOriginPort", this.HttpOriginPort);
            this.SetParamSimple(map, prefix + "HttpsOriginPort", this.HttpsOriginPort);
            this.SetParamSimple(map, prefix + "IPv6Status", this.IPv6Status);
        }
    }
}

