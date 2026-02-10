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
        /// 插件id
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 应用配置的插件header信息
        /// </summary>
        [JsonProperty("Headers")]
        public AgentPluginHeader[] Headers{ get; set; }

        /// <summary>
        /// 插件调用LLM时使用的模型配置，一般用于指定知识库问答插件的生成模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Model")]
        public AgentModelInfo Model{ get; set; }

        /// <summary>
        /// 插件信息类型; 0: 未指定类型; 1: 知识库问答插件
        /// </summary>
        [JsonProperty("PluginInfoType")]
        public ulong? PluginInfoType{ get; set; }

        /// <summary>
        /// 知识库问答插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeQa")]
        public AgentKnowledgeQAPlugin KnowledgeQa{ get; set; }

        /// <summary>
        /// 是否使用一键授权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRoleAuth")]
        public bool? EnableRoleAuth{ get; set; }

        /// <summary>
        /// 应用配置的插件query信息
        /// </summary>
        [JsonProperty("Query")]
        public AgentPluginQuery[] Query{ get; set; }

        /// <summary>
        /// MCP类型
        /// </summary>
        [JsonProperty("McpType")]
        public ulong? McpType{ get; set; }


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
        }
    }
}

