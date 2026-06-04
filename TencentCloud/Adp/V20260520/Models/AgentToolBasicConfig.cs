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

    public class AgentToolBasicConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>插件id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>工具id</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>工具输入参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputList")]
        public AgentToolInputParameter[] InputList{ get; set; }

        /// <summary>
        /// <p>工具输出参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputList")]
        public AgentToolOutputParameter[] OutputList{ get; set; }

        /// <summary>
        /// <p>工具Header参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeaderParameterList")]
        public AgentPluginParameter[] HeaderParameterList{ get; set; }

        /// <summary>
        /// <p>工具Query参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryParameterList")]
        public AgentPluginParameter[] QueryParameterList{ get; set; }

        /// <summary>
        /// <p>工具来源: 0-来自插件，1-来自工作流</p>
        /// </summary>
        [JsonProperty("ToolSource")]
        public ulong? ToolSource{ get; set; }

        /// <summary>
        /// <p>是否禁用</p>
        /// </summary>
        [JsonProperty("IsDisabled")]
        public bool? IsDisabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "InputList.", this.InputList);
            this.SetParamArrayObj(map, prefix + "OutputList.", this.OutputList);
            this.SetParamArrayObj(map, prefix + "HeaderParameterList.", this.HeaderParameterList);
            this.SetParamArrayObj(map, prefix + "QueryParameterList.", this.QueryParameterList);
            this.SetParamSimple(map, prefix + "ToolSource", this.ToolSource);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
        }
    }
}

