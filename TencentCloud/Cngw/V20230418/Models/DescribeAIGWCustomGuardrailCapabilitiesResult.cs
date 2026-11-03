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

    public class DescribeAIGWCustomGuardrailCapabilitiesResult : AbstractModel
    {
        
        /// <summary>
        /// <p>支持该能力的最低网关版本，当前为 3.9.6</p>
        /// </summary>
        [JsonProperty("MinGatewayVersion")]
        public string MinGatewayVersion{ get; set; }

        /// <summary>
        /// <p>支持绑定的业务资源类型</p>
        /// </summary>
        [JsonProperty("SupportedResourceTypes")]
        public string[] SupportedResourceTypes{ get; set; }

        /// <summary>
        /// <p>当前控制面允许绑定的协议分类，以返回值为准；不表示每种协议变体均可用。目前不开放 Dify、Custom Agent、Legacy SSE MCP。</p>
        /// </summary>
        [JsonProperty("SupportedProtocols")]
        public string[] SupportedProtocols{ get; set; }

        /// <summary>
        /// <p>当前允许配置的审核方向，仅 input（仅输入）和 both（输入加输出）。</p>
        /// </summary>
        [JsonProperty("SupportedDirections")]
        public string[] SupportedDirections{ get; set; }

        /// <summary>
        /// <p>是否支持流式请求与响应审核</p>
        /// </summary>
        [JsonProperty("SupportsStreaming")]
        public bool? SupportsStreaming{ get; set; }

        /// <summary>
        /// <p>是否支持自定义审核响应字段映射</p>
        /// </summary>
        [JsonProperty("SupportsFieldMapping")]
        public bool? SupportsFieldMapping{ get; set; }

        /// <summary>
        /// <p>系统默认拦截提示</p>
        /// </summary>
        [JsonProperty("DefaultBlockMessage")]
        public string DefaultBlockMessage{ get; set; }

        /// <summary>
        /// <p>拦截提示最大字符数</p>
        /// </summary>
        [JsonProperty("MaxBlockMessageLength")]
        public long? MaxBlockMessageLength{ get; set; }

        /// <summary>
        /// <p>控制面公布的能力限制/默认值，不是当前请求可修改的配置对象，也不是逐个 DP 实时读取值。窗口大小、并发审核数等未作为策略 API 入参开放。</p>
        /// </summary>
        [JsonProperty("Limits")]
        public CustomGuardrailCapabilityLimits Limits{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinGatewayVersion", this.MinGatewayVersion);
            this.SetParamArraySimple(map, prefix + "SupportedResourceTypes.", this.SupportedResourceTypes);
            this.SetParamArraySimple(map, prefix + "SupportedProtocols.", this.SupportedProtocols);
            this.SetParamArraySimple(map, prefix + "SupportedDirections.", this.SupportedDirections);
            this.SetParamSimple(map, prefix + "SupportsStreaming", this.SupportsStreaming);
            this.SetParamSimple(map, prefix + "SupportsFieldMapping", this.SupportsFieldMapping);
            this.SetParamSimple(map, prefix + "DefaultBlockMessage", this.DefaultBlockMessage);
            this.SetParamSimple(map, prefix + "MaxBlockMessageLength", this.MaxBlockMessageLength);
            this.SetParamObj(map, prefix + "Limits.", this.Limits);
        }
    }
}

