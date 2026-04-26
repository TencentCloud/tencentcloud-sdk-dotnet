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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartSandboxInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱工具 ID，与 ToolName 至少有一个要填</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>沙箱工具名称，与 ToolId 至少有一个要填</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>超时时间，超过这个时间就自动回收实例。支持格式：5m、300s、1h 等，默认 5m。最小 30s，最大 24h</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public string Timeout{ get; set; }

        /// <summary>
        /// <p>幂等性 Token，长度不超过 64 字符</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>沙箱实例存储挂载配置</p>
        /// </summary>
        [JsonProperty("MountOptions")]
        public MountOption[] MountOptions{ get; set; }

        /// <summary>
        /// <p>沙箱实例自定义配置</p>
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public CustomConfiguration CustomConfiguration{ get; set; }

        /// <summary>
        /// <p>沙箱访问认证模式</p><p>枚举值：</p><ul><li>DEFAULT： 默认，即 TOKEN 认证</li><li>TOKEN： Token认证，即所有端口访问都需携带TOKEN</li><li>NONE： 免认证，即所有端口访问无需携带TOKEN</li><li>PUBLIC： 公开模式，即ENVD管理端口（49983）访问需携带TOKEN，其他端口无需携带TOKEN</li></ul><p>默认值：DEFAULT</p>
        /// </summary>
        [JsonProperty("AuthMode")]
        public string AuthMode{ get; set; }

        /// <summary>
        /// <p>沙箱元数据</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataVar[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamArrayObj(map, prefix + "MountOptions.", this.MountOptions);
            this.SetParamObj(map, prefix + "CustomConfiguration.", this.CustomConfiguration);
            this.SetParamSimple(map, prefix + "AuthMode", this.AuthMode);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

