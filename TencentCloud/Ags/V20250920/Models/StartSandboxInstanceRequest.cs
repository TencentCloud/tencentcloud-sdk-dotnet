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
        /// 沙箱工具 ID，与 ToolName 至少有一个要填
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// 沙箱工具名称，与 ToolId 至少有一个要填
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// 超时时间，超过这个时间就自动回收实例。支持格式：5m、300s、1h 等，默认 5m。最小 30s，最大 24h
        /// </summary>
        [JsonProperty("Timeout")]
        public string Timeout{ get; set; }

        /// <summary>
        /// 幂等性 Token，长度不超过 64 字符
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 沙箱实例存储挂载配置
        /// </summary>
        [JsonProperty("MountOptions")]
        public MountOption[] MountOptions{ get; set; }

        /// <summary>
        /// 沙箱实例自定义配置
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public CustomConfiguration CustomConfiguration{ get; set; }


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
        }
    }
}

