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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McpServer : AbstractModel
    {
        
        /// <summary>
        /// MCP Server ID
        /// </summary>
        [JsonProperty("McpServerId")]
        public string McpServerId{ get; set; }

        /// <summary>
        /// MCP Server名称。最大长度：64
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// MCP Server类型。枚举值如下：
        /// 
        /// <li>PUBLIC_PACKAGE：公共包安装</li>
        /// <li>AGENT_GENERATED：AI生成</li>
        /// </summary>
        [JsonProperty("McpServerType")]
        public string McpServerType{ get; set; }

        /// <summary>
        /// MCP Server图标地址
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// Base64编码后的MCP Server启动命令。最大长度：2048
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// MCP Server状态。枚举值如下：
        /// 
        /// <li>PENDING：表示创建中</li>
        /// <li>LAUNCH_FAILED：表示创建失败</li>
        /// <li>RUNNING：表示运行中</li>
        /// <li>STOPPED：表示关闭</li>
        /// <li>STARTING：表示开启中</li>
        /// <li>STOPPING：表示关闭中</li>
        /// <li>RESTARTING：表示重启中</li>
        /// <li>REMOVING：表示删除中</li>
        /// <li>UNKNOWN：表示未知</li>
        /// <li>ENV_ERROR：表示环境错误</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// MCP Server访问地址。传输类型 TransportType 为 STREAMABLE_HTTP 时以 /mcp结尾，为 SSE 时以 /sse结尾。
        /// </summary>
        [JsonProperty("ServerUrl")]
        public string ServerUrl{ get; set; }

        /// <summary>
        /// MCP Server配置
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// MCP Server备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// MCP Server创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// MCP Server修改时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// MCP Server环境变量
        /// </summary>
        [JsonProperty("EnvSet")]
        public McpServerEnv[] EnvSet{ get; set; }

        /// <summary>
        /// 传输类型。枚举值如下：
        /// 
        /// <li>STREAMABLE_HTTP：HTTP协议的流式传输方式</li>
        /// <li>SSE：Server-Sent Events，服务器发送事件</li>
        /// </summary>
        [JsonProperty("TransportType")]
        public string TransportType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "McpServerId", this.McpServerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "McpServerType", this.McpServerType);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "ServerUrl", this.ServerUrl);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "EnvSet.", this.EnvSet);
            this.SetParamSimple(map, prefix + "TransportType", this.TransportType);
        }
    }
}

