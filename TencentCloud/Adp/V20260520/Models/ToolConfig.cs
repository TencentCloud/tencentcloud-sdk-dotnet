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

    public class ToolConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>API工具配置信息</p>
        /// </summary>
        [JsonProperty("ApiToolConfig")]
        public ApiToolConfig ApiToolConfig{ get; set; }

        /// <summary>
        /// <p>应用配置信息</p>
        /// </summary>
        [JsonProperty("AppToolConfig")]
        public AppToolConfig AppToolConfig{ get; set; }

        /// <summary>
        /// <p>代码工具配置信息</p>
        /// </summary>
        [JsonProperty("CodeToolConfig")]
        public CodeToolConfig CodeToolConfig{ get; set; }

        /// <summary>
        /// <p>MCP工具配置信息</p>
        /// </summary>
        [JsonProperty("MCPToolConfig")]
        public MCPToolConfig MCPToolConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ApiToolConfig.", this.ApiToolConfig);
            this.SetParamObj(map, prefix + "AppToolConfig.", this.AppToolConfig);
            this.SetParamObj(map, prefix + "CodeToolConfig.", this.CodeToolConfig);
            this.SetParamObj(map, prefix + "MCPToolConfig.", this.MCPToolConfig);
        }
    }
}

