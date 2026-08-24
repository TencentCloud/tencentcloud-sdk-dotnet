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

    public class CreateDeploymentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>唯一的 Deployment 名称，必须符合 DNS-1123 命名规范，创建后不可修改。</p>
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// <p>用于关联 Sandbox Tool 的标识，格式为 sdt- 加 8 位小写 base36 字符。</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// <p>伸缩配置；省略的成员由服务端补全默认值。</p>
        /// </summary>
        [JsonProperty("ScalingConfiguration")]
        public ScalingConfiguration ScalingConfiguration{ get; set; }

        /// <summary>
        /// <p>空闲生命周期配置；省略的成员由服务端补全默认值。</p>
        /// </summary>
        [JsonProperty("LifecycleConfiguration")]
        public LifecycleConfiguration LifecycleConfiguration{ get; set; }

        /// <summary>
        /// <p>Affinity 配置；省略或空 Mode 表示不启用。</p>
        /// </summary>
        [JsonProperty("AffinityConfiguration")]
        public AffinityConfiguration AffinityConfiguration{ get; set; }

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
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamObj(map, prefix + "ScalingConfiguration.", this.ScalingConfiguration);
            this.SetParamObj(map, prefix + "LifecycleConfiguration.", this.LifecycleConfiguration);
            this.SetParamObj(map, prefix + "AffinityConfiguration.", this.AffinityConfiguration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

