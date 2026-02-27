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

    public class SandboxTool : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱工具唯一标识符</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>沙箱工具名称，长度 1-50 字符，支持中英文、数字、下划线。同一 AppId 下沙箱工具名称必须唯一</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>沙箱工具类型，取值：browser（浏览器工具）、code-interpreter（代码解释器工具）、computer（计算机控制工具）、mobile（移动设备工具）</p>
        /// </summary>
        [JsonProperty("ToolType")]
        public string ToolType{ get; set; }

        /// <summary>
        /// <p>沙箱工具状态，取值：CREATING（创建中）、ACTIVE（可用）、DELETING（删除中）、FAILED（失败）</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>沙箱工具描述信息，最大长度 200 字符</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>默认超时时间，支持格式：5m、300s、1h 等，不指定则使用系统默认值（5 分钟）。最大 24 小时</p>
        /// </summary>
        [JsonProperty("DefaultTimeoutSeconds")]
        public ulong? DefaultTimeoutSeconds{ get; set; }

        /// <summary>
        /// <p>网络配置</p>
        /// </summary>
        [JsonProperty("NetworkConfiguration")]
        public NetworkConfiguration NetworkConfiguration{ get; set; }

        /// <summary>
        /// <p>标签规格，包含资源标签绑定关系。用于为沙箱工具绑定标签，支持多种资源类型的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>沙箱工具创建时间，格式：ISO8601</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>沙箱工具更新时间，格式：ISO8601</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>沙箱工具绑定角色ARN</p>
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// <p>沙箱工具中实例存储挂载配置</p>
        /// </summary>
        [JsonProperty("StorageMounts")]
        public StorageMount[] StorageMounts{ get; set; }

        /// <summary>
        /// <p>沙箱工具自定义配置</p>
        /// </summary>
        [JsonProperty("CustomConfiguration")]
        public CustomConfigurationDetail CustomConfiguration{ get; set; }

        /// <summary>
        /// <p>沙箱工具日志推送相关配置</p>
        /// </summary>
        [JsonProperty("LogConfiguration")]
        public LogConfiguration LogConfiguration{ get; set; }

        /// <summary>
        /// <p>用于说明沙箱工具处于该状态的原因</p>
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolType", this.ToolType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DefaultTimeoutSeconds", this.DefaultTimeoutSeconds);
            this.SetParamObj(map, prefix + "NetworkConfiguration.", this.NetworkConfiguration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamArrayObj(map, prefix + "StorageMounts.", this.StorageMounts);
            this.SetParamObj(map, prefix + "CustomConfiguration.", this.CustomConfiguration);
            this.SetParamObj(map, prefix + "LogConfiguration.", this.LogConfiguration);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
        }
    }
}

