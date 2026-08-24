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

    public class ModifyDeploymentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待修改的 Deployment ID。</p>
        /// </summary>
        [JsonProperty("DeploymentId")]
        public string DeploymentId{ get; set; }

        /// <summary>
        /// <p>完整替换伸缩配置；提供时必须包含全部三个成员。</p>
        /// </summary>
        [JsonProperty("ScalingConfiguration")]
        public ScalingConfiguration ScalingConfiguration{ get; set; }

        /// <summary>
        /// <p>完整替换生命周期配置；提供时必须包含全部两个成员。</p>
        /// </summary>
        [JsonProperty("LifecycleConfiguration")]
        public LifecycleConfiguration LifecycleConfiguration{ get; set; }

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
            this.SetParamObj(map, prefix + "ScalingConfiguration.", this.ScalingConfiguration);
            this.SetParamObj(map, prefix + "LifecycleConfiguration.", this.LifecycleConfiguration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

