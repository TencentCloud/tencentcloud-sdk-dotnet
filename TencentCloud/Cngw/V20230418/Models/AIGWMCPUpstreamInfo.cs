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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWMCPUpstreamInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>注册中心来源ID</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>MCP服务 id</p>
        /// </summary>
        [JsonProperty("MCPServerId")]
        public string MCPServerId{ get; set; }

        /// <summary>
        /// <p>协议，UpstreamType是Registry 时必传</p><ul><li>http</li><li>https</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>域名或ip</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>服务 id</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>服务分组</p>
        /// </summary>
        [JsonProperty("ServiceGroup")]
        public string ServiceGroup{ get; set; }

        /// <summary>
        /// <p>mcp endpoint</p>
        /// </summary>
        [JsonProperty("MCPEndpoint")]
        public string MCPEndpoint{ get; set; }

        /// <summary>
        /// <p>message端点路径，SSE协议时配置</p>
        /// </summary>
        [JsonProperty("MessageEndpoint")]
        public string MessageEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MCPServerId", this.MCPServerId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceGroup", this.ServiceGroup);
            this.SetParamSimple(map, prefix + "MCPEndpoint", this.MCPEndpoint);
            this.SetParamSimple(map, prefix + "MessageEndpoint", this.MessageEndpoint);
        }
    }
}

