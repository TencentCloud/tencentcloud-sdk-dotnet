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

    public class PluginConfig : AbstractModel
    {
        
        /// <summary>
        /// API插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiPluginConfig")]
        public ApiPluginConfig ApiPluginConfig{ get; set; }

        /// <summary>
        /// 应用插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppPluginConfig")]
        public AppPluginConfig AppPluginConfig{ get; set; }

        /// <summary>
        /// mcp插件配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCPPluginConfig")]
        public MCPPluginConfig MCPPluginConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ApiPluginConfig.", this.ApiPluginConfig);
            this.SetParamObj(map, prefix + "AppPluginConfig.", this.AppPluginConfig);
            this.SetParamObj(map, prefix + "MCPPluginConfig.", this.MCPPluginConfig);
        }
    }
}

