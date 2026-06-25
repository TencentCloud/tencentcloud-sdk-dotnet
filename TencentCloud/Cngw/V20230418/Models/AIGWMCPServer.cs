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

    public class AIGWMCPServer : AbstractModel
    {
        
        /// <summary>
        /// <p>MCP Server ID</p>
        /// </summary>
        [JsonProperty("ServerId")]
        public string ServerId{ get; set; }

        /// <summary>
        /// <p>MCP Server名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>MCP Server类型，取值：MCP/Rest2MCP</p>
        /// </summary>
        [JsonProperty("ServerType")]
        public string ServerType{ get; set; }

        /// <summary>
        /// <p>协议类型，取值: StreamableHttp</p>
        /// </summary>
        [JsonProperty("Transport")]
        public string Transport{ get; set; }

        /// <summary>
        /// <p>服务类型：</p><ul><li>Registry  </li><li>HostIP</li></ul>
        /// </summary>
        [JsonProperty("UpstreamType")]
        public string UpstreamType{ get; set; }

        /// <summary>
        /// <p>展示名字</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>MCP提供给客户端的Endpoint</p>
        /// </summary>
        [JsonProperty("MCPEndpoint")]
        public string MCPEndpoint{ get; set; }

        /// <summary>
        /// <p>注册中心来源信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamInfo")]
        public AIGWMCPUpstreamInfoDetail UpstreamInfo{ get; set; }

        /// <summary>
        /// <p>会话配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionConfig")]
        public AIGWMCPSessionConfig SessionConfig{ get; set; }

        /// <summary>
        /// <p>超时时间，单位ms</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>失败重试次数</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public ulong? RetryCount{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>运行状态</p><p>枚举值：</p><ul><li>Online： 在线</li><li>Offline： 离线</li><li>Error： 错误</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否启用健康检查</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>健康检查配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public AIGWHealthCheckSetting HealthCheck{ get; set; }

        /// <summary>
        /// <p>Tool分组内工具数量限制</p>
        /// </summary>
        [JsonProperty("ToolCountLimit")]
        public ulong? ToolCountLimit{ get; set; }

        /// <summary>
        /// <p>Tool分组内工具命名冲突策略</p><p>枚举值：</p><ul><li>AutoPrefix： 自动前缀</li><li>Reject： 拒绝</li></ul>
        /// </summary>
        [JsonProperty("ConflictStrategy")]
        public string ConflictStrategy{ get; set; }

        /// <summary>
        /// <p>MCP 市场发布状态</p><p>枚举值：</p><ul><li>None： 未发布</li><li>Published： 已发布</li></ul>
        /// </summary>
        [JsonProperty("MarketStatus")]
        public string MarketStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerId", this.ServerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "Transport", this.Transport);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "MCPEndpoint", this.MCPEndpoint);
            this.SetParamObj(map, prefix + "UpstreamInfo.", this.UpstreamInfo);
            this.SetParamObj(map, prefix + "SessionConfig.", this.SessionConfig);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "ToolCountLimit", this.ToolCountLimit);
            this.SetParamSimple(map, prefix + "ConflictStrategy", this.ConflictStrategy);
            this.SetParamSimple(map, prefix + "MarketStatus", this.MarketStatus);
        }
    }
}

