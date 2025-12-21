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

    public class CreateSandboxToolRequest : AbstractModel
    {
        
        /// <summary>
        /// 沙箱工具名称，长度 1-50 字符，支持英文、数字、下划线和连接线。同一 AppId 下沙箱工具名称必须唯一
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// 沙箱工具类型，目前支持：browser、code-interpreter
        /// </summary>
        [JsonProperty("ToolType")]
        public string ToolType{ get; set; }

        /// <summary>
        /// 网络配置
        /// </summary>
        [JsonProperty("NetworkConfiguration")]
        public NetworkConfiguration NetworkConfiguration{ get; set; }

        /// <summary>
        /// 沙箱工具描述，最大长度 200 字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 默认超时时间，支持格式：5m、300s、1h 等，不指定则使用系统默认值（5 分钟）。最大 24 小时
        /// </summary>
        [JsonProperty("DefaultTimeout")]
        public string DefaultTimeout{ get; set; }

        /// <summary>
        /// 标签规格，为沙箱工具绑定标签，支持多种资源类型的标签绑定
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 幂等性 Token，长度不超过 64 字符
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 角色ARN
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// 沙箱工具存储配置
        /// </summary>
        [JsonProperty("StorageMounts")]
        public StorageMount[] StorageMounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolType", this.ToolType);
            this.SetParamObj(map, prefix + "NetworkConfiguration.", this.NetworkConfiguration);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DefaultTimeout", this.DefaultTimeout);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamArrayObj(map, prefix + "StorageMounts.", this.StorageMounts);
        }
    }
}

