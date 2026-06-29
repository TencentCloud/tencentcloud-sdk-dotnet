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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MCPPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>MCP插件外部访问地址</p>
        /// </summary>
        [JsonProperty("ExternalMCPServerUrl")]
        public string ExternalMCPServerUrl{ get; set; }

        /// <summary>
        /// <p>MCP server地址</p>
        /// </summary>
        [JsonProperty("MCPServerUrl")]
        public string MCPServerUrl{ get; set; }

        /// <summary>
        /// <p>MCP传输类型: SSE/Streamable<br>枚举值:<br>| uint | 描述 |<br>| --- | --- |<br>| 0 | SSE + HTTP 模式 |<br>| 1 | Streamable HTTP 模式 |</p>
        /// </summary>
        [JsonProperty("MCPTransport")]
        public long? MCPTransport{ get; set; }

        /// <summary>
        /// <p>MCP插件的header参数</p>
        /// </summary>
        [JsonProperty("PluginHeader")]
        public PluginParam[] PluginHeader{ get; set; }

        /// <summary>
        /// <p>MCP插件的query参数</p>
        /// </summary>
        [JsonProperty("PluginQuery")]
        public PluginParam[] PluginQuery{ get; set; }

        /// <summary>
        /// <p>SSE长连接超时时间，单位秒</p>
        /// </summary>
        [JsonProperty("SSEReadTimeout")]
        public long? SSEReadTimeout{ get; set; }

        /// <summary>
        /// <p>请求超时时间，单位秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>授权信息</p>
        /// </summary>
        [JsonProperty("AuthConfig")]
        public AuthConfig AuthConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalMCPServerUrl", this.ExternalMCPServerUrl);
            this.SetParamSimple(map, prefix + "MCPServerUrl", this.MCPServerUrl);
            this.SetParamSimple(map, prefix + "MCPTransport", this.MCPTransport);
            this.SetParamArrayObj(map, prefix + "PluginHeader.", this.PluginHeader);
            this.SetParamArrayObj(map, prefix + "PluginQuery.", this.PluginQuery);
            this.SetParamSimple(map, prefix + "SSEReadTimeout", this.SSEReadTimeout);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "AuthConfig.", this.AuthConfig);
        }
    }
}

