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

    public class Tool : AbstractModel
    {
        
        /// <summary>
        /// 工具描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 工具id
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// 工具计费信息
        /// </summary>
        [JsonProperty("Billing")]
        public ToolBilling Billing{ get; set; }

        /// <summary>
        /// 工具调用次数
        /// </summary>
        [JsonProperty("CallCount")]
        public ulong? CallCount{ get; set; }

        /// <summary>
        /// <p>工具访问模式</p><p>枚举值：</p><ul><li>0： 未指定</li><li>1： READ_ONLY</li><li>2： WRITE_DELETE</li></ul>
        /// </summary>
        [JsonProperty("ToolAccessMode")]
        public long? ToolAccessMode{ get; set; }

        /// <summary>
        /// 工具配置
        /// </summary>
        [JsonProperty("ToolConfig")]
        public ToolConfig ToolConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "ToolAccessMode", this.ToolAccessMode);
            this.SetParamObj(map, prefix + "ToolConfig.", this.ToolConfig);
        }
    }
}

