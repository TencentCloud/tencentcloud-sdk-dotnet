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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentPluginInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>插件id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>应用配置的插件header信息</p>
        /// </summary>
        [JsonProperty("Headers")]
        public AgentPluginHeader[] Headers{ get; set; }

        /// <summary>
        /// <p>插件调用LLM时使用的模型配置，一般用于指定知识库问答插件的生成模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Model")]
        public AgentModelInfo Model{ get; set; }

        /// <summary>
        /// <p>插件信息类型; 0: 未指定类型; 1: 知识库问答插件</p>
        /// </summary>
        [JsonProperty("PluginInfoType")]
        public ulong? PluginInfoType{ get; set; }

        /// <summary>
        /// <p>知识库问答插件配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeQa")]
        public AgentKnowledgeQAPlugin KnowledgeQa{ get; set; }

        /// <summary>
        /// <p>是否使用一键授权</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRoleAuth")]
        public bool? EnableRoleAuth{ get; set; }

        /// <summary>
        /// <p>应用配置的插件query信息</p>
        /// </summary>
        [JsonProperty("Query")]
        public AgentPluginQuery[] Query{ get; set; }

        /// <summary>
        /// <p>MCP类型</p><p>枚举值：</p><ul><li>0： SSE 模式</li><li>1： Streamable Http 模式</li></ul>
        /// </summary>
        [JsonProperty("McpType")]
        public ulong? McpType{ get; set; }

        /// <summary>
        /// <p>OAuth授权主体</p><p>枚举值：</p><ul><li>0： 开发者授权</li><li>1： 使用者授权</li></ul>
        /// </summary>
        [JsonProperty("AuthMode")]
        public long? AuthMode{ get; set; }

        /// <summary>
        /// <p>授权方式</p><p>枚举值：</p><ul><li>0： 无鉴权</li><li>1： api key鉴权</li><li>2： 支持CAM授权</li><li>3： 支持Oauth2.0授权</li></ul>
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// <p>授权配置状态</p><p>枚举值：</p><ul><li>0： 不需要授权</li><li>1： 未配置</li><li>2： 已配置</li></ul>
        /// </summary>
        [JsonProperty("AuthConfigStatus")]
        public long? AuthConfigStatus{ get; set; }

        /// <summary>
        /// <p>插件用途类型</p><p>枚举值：</p><ul><li>0： 工具类</li><li>1： 连接器类</li></ul>
        /// </summary>
        [JsonProperty("PluginClass")]
        public long? PluginClass{ get; set; }

        /// <summary>
        /// <p>插件状态</p><p>枚举值：</p><ul><li>1： 成功</li><li>2： 不可用</li></ul>
        /// </summary>
        [JsonProperty("PluginStatus")]
        public long? PluginStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamSimple(map, prefix + "PluginInfoType", this.PluginInfoType);
            this.SetParamObj(map, prefix + "KnowledgeQa.", this.KnowledgeQa);
            this.SetParamSimple(map, prefix + "EnableRoleAuth", this.EnableRoleAuth);
            this.SetParamArrayObj(map, prefix + "Query.", this.Query);
            this.SetParamSimple(map, prefix + "McpType", this.McpType);
            this.SetParamSimple(map, prefix + "AuthMode", this.AuthMode);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthConfigStatus", this.AuthConfigStatus);
            this.SetParamSimple(map, prefix + "PluginClass", this.PluginClass);
            this.SetParamSimple(map, prefix + "PluginStatus", this.PluginStatus);
        }
    }
}

