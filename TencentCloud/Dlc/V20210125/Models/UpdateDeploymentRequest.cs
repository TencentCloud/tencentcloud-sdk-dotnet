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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDeploymentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>DeploymentId</p>
        /// </summary>
        [JsonProperty("DeploymentId")]
        public string DeploymentId{ get; set; }

        /// <summary>
        /// <p>模型版本（如 v1, v2），未提供时保持当前版本</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>推理引擎（vllm）</p>
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// <p>副本数</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// <p>是否启用弹性伸缩</p>
        /// </summary>
        [JsonProperty("AutoscalingEnabled")]
        public bool? AutoscalingEnabled{ get; set; }

        /// <summary>
        /// <p>代码包 URI（可选，未传时从 primary deployment 继承）</p>
        /// </summary>
        [JsonProperty("CodePackageUri")]
        public string CodePackageUri{ get; set; }

        /// <summary>
        /// <p>代码包原始文件名（可选，详情页「代码引用」回显用，仅记录不参与业务逻辑）</p>
        /// </summary>
        [JsonProperty("CodePackageOriginalName")]
        public string CodePackageOriginalName{ get; set; }

        /// <summary>
        /// <p>CR / PodSpec overrides JSON（可选）</p>
        /// </summary>
        [JsonProperty("CrOverrides")]
        public string CrOverrides{ get; set; }

        /// <summary>
        /// <p>Head 节点高可用开关（可选，不传或 true 为开启，仅 false 为关闭；与当前值不同会触发服务重建）</p>
        /// </summary>
        [JsonProperty("HeadHighAvailabilityEnabled")]
        public bool? HeadHighAvailabilityEnabled{ get; set; }

        /// <summary>
        /// <p>可选：创建时一并挂载的 LoRA 模型版本（首次启动即生效）</p>
        /// </summary>
        [JsonProperty("LoraBindings")]
        public LoraAdapterBinding[] LoraBindings{ get; set; }

        /// <summary>
        /// <p>ray runtime env 字段</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeploymentId", this.DeploymentId);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "AutoscalingEnabled", this.AutoscalingEnabled);
            this.SetParamSimple(map, prefix + "CodePackageUri", this.CodePackageUri);
            this.SetParamSimple(map, prefix + "CodePackageOriginalName", this.CodePackageOriginalName);
            this.SetParamSimple(map, prefix + "CrOverrides", this.CrOverrides);
            this.SetParamSimple(map, prefix + "HeadHighAvailabilityEnabled", this.HeadHighAvailabilityEnabled);
            this.SetParamArrayObj(map, prefix + "LoraBindings.", this.LoraBindings);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
        }
    }
}

