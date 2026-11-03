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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailServiceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>审核服务地址来源：manual 手动填写完整 URL，service 引用本网关服务管理中的 Kong Service。二者互斥；创建时按接口要求显式传入。</p>
        /// </summary>
        [JsonProperty("AddressMode")]
        public string AddressMode{ get; set; }

        /// <summary>
        /// <p>AddressMode=service 时必填。填写审核引擎对应的 Kong Service ID，不是被审核的模型 API、MCP Server 或 Agent API ID。按该服务的 protocol、host、port、path 拼出审核 URL；直接请求该 URL，不是经过该服务的网关 Route，也不会自动继承其 Route 插件或业务鉴权。manual 模式不得填写。</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>AddressMode=manual 时必填，审核引擎接受 POST 的 HTTP/HTTPS 完整 URL，例如 https://audit.example.com/v2/audit；路径以实际引擎为准，不会自动补 /v2/audit。service 模式不得填写。请填写 URL 原文，不要粘贴 Markdown 链接。</p>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// <p>是否校验审核引擎 HTTPS 证书，创建默认 true；仅影响审核 HTTP 调用，不是客户端访问网关的 TLS 设置。</p>
        /// </summary>
        [JsonProperty("SSLVerify")]
        public bool? SSLVerify{ get; set; }

        /// <summary>
        /// <p>是否把原业务请求的完整 Query 字符串写入送审包，创建默认 false。开启可能把 Query 中的凭据或个人信息传给审核服务，须确认接收方可信；不是审核服务 URL 自身的 Query 开关。</p>
        /// </summary>
        [JsonProperty("QueryPassthroughEnabled")]
        public bool? QueryPassthroughEnabled{ get; set; }

        /// <summary>
        /// <p>允许额外写入送审包的原始 HTTP Header 名称，最多 64 项，每项最长 128 字节；名称不区分大小写，默认 []。内置保留 content-type、accept、mcp-protocol-version、a2a-version；Authorization、Cookie、API Key、MCP 会话标识和内部 Relay 等受限头不会因加入本列表而放行。审核服务自身的鉴权请使用 AuthConfig。</p>
        /// </summary>
        [JsonProperty("HeaderAllowList")]
        public string[] HeaderAllowList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressMode", this.AddressMode);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "SSLVerify", this.SSLVerify);
            this.SetParamSimple(map, prefix + "QueryPassthroughEnabled", this.QueryPassthroughEnabled);
            this.SetParamArraySimple(map, prefix + "HeaderAllowList.", this.HeaderAllowList);
        }
    }
}

