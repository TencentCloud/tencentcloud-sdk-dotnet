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

    public class KnowledgeQaPlugin : AbstractModel
    {
        
        /// <summary>
        /// 插件ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 插件图标
        /// </summary>
        [JsonProperty("PluginIcon")]
        public string PluginIcon{ get; set; }

        /// <summary>
        /// 工具ID
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
        /// 工具输入参数
        /// </summary>
        [JsonProperty("Inputs")]
        public PluginToolReqParam[] Inputs{ get; set; }

        /// <summary>
        /// 插件是否和知识库绑定
        /// </summary>
        [JsonProperty("IsBindingKnowledge")]
        public bool? IsBindingKnowledge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginIcon", this.PluginIcon);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolDesc", this.ToolDesc);
            this.SetParamArrayObj(map, prefix + "Inputs.", this.Inputs);
            this.SetParamSimple(map, prefix + "IsBindingKnowledge", this.IsBindingKnowledge);
        }
    }
}

