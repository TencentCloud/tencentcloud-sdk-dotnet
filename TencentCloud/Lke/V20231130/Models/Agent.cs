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

    public class Agent : AbstractModel
    {
        
        /// <summary>
        /// AgentID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// WorkflowID，非空则当前Agent从workflow转换而来
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Agent名称，同一个应用内，Agent名称不能重复
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Agent图标url
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// Agent指令；当该Agent被调用时，将作为“系统提示词”使用，描述Agent应执行的操作和响应方式
        /// </summary>
        [JsonProperty("Instructions")]
        public string Instructions{ get; set; }

        /// <summary>
        /// 当Agent作为转交目标时的描述，用于让其他Agent的LLM理解其功能和转交时机
        /// </summary>
        [JsonProperty("HandoffDescription")]
        public string HandoffDescription{ get; set; }

        /// <summary>
        /// Agent可转交的子AgentId列表
        /// </summary>
        [JsonProperty("Handoffs")]
        public string[] Handoffs{ get; set; }

        /// <summary>
        /// Agent调用LLM时使用的模型配置
        /// </summary>
        [JsonProperty("Model")]
        public AgentModelInfo Model{ get; set; }

        /// <summary>
        /// Agent可使用的工具列表
        /// </summary>
        [JsonProperty("Tools")]
        public AgentToolInfo[] Tools{ get; set; }

        /// <summary>
        /// Agent可使用的插件列表
        /// </summary>
        [JsonProperty("Plugins")]
        public AgentPluginInfo[] Plugins{ get; set; }

        /// <summary>
        /// 当前Agent是否是启动Agent
        /// </summary>
        [JsonProperty("IsStartingAgent")]
        public bool? IsStartingAgent{ get; set; }

        /// <summary>
        /// Agent类型; 0: 未指定类型; 1: 知识库检索Agent
        /// </summary>
        [JsonProperty("AgentType")]
        public ulong? AgentType{ get; set; }

        /// <summary>
        /// 0 自由转交，1 计划与执行
        /// </summary>
        [JsonProperty("AgentMode")]
        public long? AgentMode{ get; set; }

        /// <summary>
        /// 高级设置
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public AgentAdvancedConfig AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Instructions", this.Instructions);
            this.SetParamSimple(map, prefix + "HandoffDescription", this.HandoffDescription);
            this.SetParamArraySimple(map, prefix + "Handoffs.", this.Handoffs);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamArrayObj(map, prefix + "Tools.", this.Tools);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamSimple(map, prefix + "IsStartingAgent", this.IsStartingAgent);
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
            this.SetParamSimple(map, prefix + "AgentMode", this.AgentMode);
            this.SetParamObj(map, prefix + "AdvancedConfig.", this.AdvancedConfig);
        }
    }
}

