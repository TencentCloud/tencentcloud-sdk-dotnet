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

    public class CreateInferenceServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>推理服务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模型 UID（业务级唯一标识）</p>
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>推理引擎（vllm / xgboost）</p>
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// <p>副本数</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// <p>资源分区 ID（目标 K8s 集群分区）</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>Ray Serve 部署镜像</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>模型标识符（OpenAI 兼容 API 中的 model 字段）</p>
        /// </summary>
        [JsonProperty("ModelIdentifier")]
        public string ModelIdentifier{ get; set; }

        /// <summary>
        /// <p>队列名（K8s namespace）</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>部署名称（可选，未提供时自动生成）</p>
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// <p>模型版本（如 v1, v2），未提供时使用最新版本</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>ray head 是否开始高可用（是否申请 redis 实例用于 head 连接）</p>
        /// </summary>
        [JsonProperty("HeadHighAvailabilityEnabled")]
        public bool? HeadHighAvailabilityEnabled{ get; set; }

        /// <summary>
        /// <p>高级参数（JSON 字符串，可选）</p>
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public string AdvancedParams{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略（默认 IfNotPresent）</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>是否启用弹性伸缩</p>
        /// </summary>
        [JsonProperty("AutoscalingEnabled")]
        public bool? AutoscalingEnabled{ get; set; }

        /// <summary>
        /// <p>最小副本数（启用弹性伸缩时生效，0 表示缩容到 0）</p>
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// <p>最大副本数（启用弹性伸缩时生效）</p>
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// <p>Autoscaler 配置（JSON 字符串）</p>
        /// </summary>
        [JsonProperty("AutoscalerOptions")]
        public string AutoscalerOptions{ get; set; }

        /// <summary>
        /// <p>ApiKeyIds</p>
        /// </summary>
        [JsonProperty("ApiKeyIds")]
        public string[] ApiKeyIds{ get; set; }

        /// <summary>
        /// <p>AdvancedOptions 高级参数 JSON 字符串（可选），扁平 KV 结构，作用于 K8s RayService CR YAML 字段级</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>系统标签列表（TagKey-TagValue）</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>自定义RayServe提交</p>
        /// </summary>
        [JsonProperty("IsCustom")]
        public bool? IsCustom{ get; set; }

        /// <summary>
        /// <p>python runtime env</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ModelIdentifier", this.ModelIdentifier);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "HeadHighAvailabilityEnabled", this.HeadHighAvailabilityEnabled);
            this.SetParamSimple(map, prefix + "AdvancedParams", this.AdvancedParams);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "AutoscalingEnabled", this.AutoscalingEnabled);
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "AutoscalerOptions", this.AutoscalerOptions);
            this.SetParamArraySimple(map, prefix + "ApiKeyIds.", this.ApiKeyIds);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
        }
    }
}

