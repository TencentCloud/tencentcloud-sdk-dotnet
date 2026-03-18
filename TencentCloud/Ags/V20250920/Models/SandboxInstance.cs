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

    public class SandboxInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱实例唯一标识符</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>所属沙箱工具 ID</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>所属沙箱工具名称</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>实例状态：STARTING（启动中）、RUNNING（运行中）、STOPPING（停止中）、STOPPED（已停止）、STOP_FAILED（停止失败）、FAILED（失败状态）</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>超时时间（秒），null 表示无超时设置</p>
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public ulong? TimeoutSeconds{ get; set; }

        /// <summary>
        /// <p>过期时间（ISO 8601 格式），null 表示无过期时间</p>
        /// </summary>
        [JsonProperty("ExpiresAt")]
        public string ExpiresAt{ get; set; }

        /// <summary>
        /// <p>停止原因：manual（手动）、timeout（超时）、error（错误）、system（系统），仅在状态为 STOPPED、STOP_FAILED 或 FAILED 时有值。当 provider 停止失败时，状态为 STOP_FAILED，原因为 error</p>
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// <p>创建时间（ISO 8601 格式）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（ISO 8601 格式）</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>存储挂载选项</p>
        /// </summary>
        [JsonProperty("MountOptions")]
        public MountOption[] MountOptions{ get; set; }

        /// <summary>
        /// <p>沙箱实例自定义配置</p>
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public CustomConfigurationDetail CustomConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "ExpiresAt", this.ExpiresAt);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "MountOptions.", this.MountOptions);
            this.SetParamObj(map, prefix + "CustomConfiguration.", this.CustomConfiguration);
        }
    }
}

