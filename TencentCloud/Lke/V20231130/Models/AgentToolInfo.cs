/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class AgentToolInfo : AbstractModel
    {
        
        /// <summary>
        /// 插件id
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 插件图标url
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// 0 自定义插件
        /// 1 官方插件
        /// 2 第三方插件 目前用于第三方实现的mcp server
        /// </summary>
        [JsonProperty("PluginType")]
        public ulong? PluginType{ get; set; }

        /// <summary>
        /// 工具id
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// 工具描述
        /// </summary>
        [JsonProperty("ToolDesc")]
        public string ToolDesc{ get; set; }

        /// <summary>
        /// 输入参数
        /// </summary>
        [JsonProperty("Inputs")]
        public AgentToolReqParam[] Inputs{ get; set; }

        /// <summary>
        /// 输出参数
        /// </summary>
        [JsonProperty("Outputs")]
        public AgentToolRspParam[] Outputs{ get; set; }

        /// <summary>
        /// 创建方式，0:服务创建，1:代码创建，2:MCP创建	
        /// </summary>
        [JsonProperty("CreateType")]
        public long? CreateType{ get; set; }

        /// <summary>
        /// MCP插件的配置信息
        /// </summary>
        [JsonProperty("McpServer")]
        public AgentMCPServerInfo McpServer{ get; set; }

        /// <summary>
        /// 该工具是否和知识库绑定
        /// </summary>
        [JsonProperty("IsBindingKnowledge")]
        public bool? IsBindingKnowledge{ get; set; }

        /// <summary>
        /// 插件状态，1:可用，2:不可用	
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// header信息
        /// </summary>
        [JsonProperty("Headers")]
        public AgentPluginHeader[] Headers{ get; set; }

        /// <summary>
        /// NON_STREAMING: 非流式  STREAMIN: 流式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallingMethod")]
        public string CallingMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolDesc", this.ToolDesc);
            this.SetParamArrayObj(map, prefix + "Inputs.", this.Inputs);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamSimple(map, prefix + "CreateType", this.CreateType);
            this.SetParamObj(map, prefix + "McpServer.", this.McpServer);
            this.SetParamSimple(map, prefix + "IsBindingKnowledge", this.IsBindingKnowledge);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "CallingMethod", this.CallingMethod);
        }
    }
}

