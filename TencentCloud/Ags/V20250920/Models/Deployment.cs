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

    public class Deployment : AbstractModel
    {
        
        /// <summary>
        /// <p>Deployment 稳定 ID，格式为 dpl- 加 8 位小写 base36 字符。</p>
        /// </summary>
        [JsonProperty("DeploymentId")]
        public string DeploymentId{ get; set; }

        /// <summary>
        /// <p>唯一且创建后不可修改的名称，必须符合 DNS-1123 命名规范。</p>
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// <p>用于关联 Sandbox Tool 的标识，格式为 sdt- 加 8 位小写 base36 字符。</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>完整的活跃容量配置。</p>
        /// </summary>
        [JsonProperty("ScalingConfiguration")]
        public ScalingConfiguration ScalingConfiguration{ get; set; }

        /// <summary>
        /// <p>完整的空闲生命周期配置。</p>
        /// </summary>
        [JsonProperty("LifecycleConfiguration")]
        public LifecycleConfiguration LifecycleConfiguration{ get; set; }

        /// <summary>
        /// <p>可选 Affinity 配置；未启用时省略。</p>
        /// </summary>
        [JsonProperty("AffinityConfiguration")]
        public AffinityConfiguration AffinityConfiguration{ get; set; }

        /// <summary>
        /// <p>Deployment 控制面状态。</p><p>枚举值：</p><ul><li>ACTIVE：入口可用。</li><li>DELETING：入口已关闭并正在异步删除。</li><li>DELETE_FAILED：最近一次异步删除失败，可再次调用 DeleteDeployment。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>DELETE_FAILED 状态下 1..1024 个 UTF-8 字节的安全失败摘要，格式为 {Code}[.{SubCode}]: {Message}；其他状态省略。</p>
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }

        /// <summary>
        /// <p>创建时间，UTC、秒精度 RFC3339 格式。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>最近一次成功公共配置写入或 Deployment 状态迁移时间，UTC、秒精度 RFC3339 格式。</p>
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeploymentId", this.DeploymentId);
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamObj(map, prefix + "ScalingConfiguration.", this.ScalingConfiguration);
            this.SetParamObj(map, prefix + "LifecycleConfiguration.", this.LifecycleConfiguration);
            this.SetParamObj(map, prefix + "AffinityConfiguration.", this.AffinityConfiguration);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

