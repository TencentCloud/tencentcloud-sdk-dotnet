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

    public class McpServerTemplate : AbstractModel
    {
        
        /// <summary>
        /// MCP Server名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Base64编码之后的MCP Server启动命令。
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// MCP Server图标地址
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// MCP Server社区地址
        /// </summary>
        [JsonProperty("CommunityUrl")]
        public string CommunityUrl{ get; set; }

        /// <summary>
        /// MCP Server关联的开发平台地址或开放平台地址
        /// </summary>
        [JsonProperty("PlatformUrl")]
        public string PlatformUrl{ get; set; }

        /// <summary>
        /// MCP Server环境变量
        /// </summary>
        [JsonProperty("EnvSet")]
        public McpServerTemplateEnv[] EnvSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "CommunityUrl", this.CommunityUrl);
            this.SetParamSimple(map, prefix + "PlatformUrl", this.PlatformUrl);
            this.SetParamArrayObj(map, prefix + "EnvSet.", this.EnvSet);
        }
    }
}

