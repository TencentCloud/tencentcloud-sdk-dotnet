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

    public class CreateLabRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据实验室名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>资源分区ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>队列名称</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>Ray 集群镜像地址（可选，OpenAPI/SDK 高级控制入口）。前端不再传递此字段；为空时后端按 R1（镜像表查询命中）→ R2（同值 fallback）顺序自动派生。非空时直接作为 Ray 集群镜像，跳过派生（EXPLICIT），且后端不校验其与 LabImage 的兼容性。</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>Lab 镜像地址（必填，用于开发工具如 Jupyter/VSCode/WebShell）。前端在&quot;内置 / 自定义&quot;两态中选择此值；当 Image 字段未显式传入时，后端会基于该字段按 R1（镜像表命中）/R2（同值 fallback）派生 Ray 集群镜像。</p>
        /// </summary>
        [JsonProperty("LabImage")]
        public string LabImage{ get; set; }

        /// <summary>
        /// <p>数据实验室描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略（Always, IfNotPresent, Never）</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>资源配置ID</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public string ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>存储卷和挂载卷配置</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>计算组 ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>服务类型列表(VSCODE, JUPYTER, WEBSHELL)，不填则使用默认配置</p>
        /// </summary>
        [JsonProperty("ServiceTypes")]
        public string[] ServiceTypes{ get; set; }

        /// <summary>
        /// <p>案例ID，当 startMode=EXAMPLE 时必填</p>
        /// </summary>
        [JsonProperty("ExampleId")]
        public string ExampleId{ get; set; }

        /// <summary>
        /// <p>案例代码包地址，当 startMode=EXAMPLE 时填写</p>
        /// </summary>
        [JsonProperty("CodeArchiveUrl")]
        public string CodeArchiveUrl{ get; set; }

        /// <summary>
        /// <p>Lab sidecar 镜像拉取策略（Always, IfNotPresent, Never）</p>
        /// </summary>
        [JsonProperty("LabImagePullPolicy")]
        public string LabImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>高级参数（扁平 Key-Value 的 JSON 字符串），Key 以 spec. 开头，按 RayCluster CRD 下钻；详见 ADVANCED_CLUSTER_OPTIONS_DESIGN.md</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>优先级（1-9，数字越大优先级越高）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），用于将资源与腾讯云标签系统中的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>持久化工作目录配置（可选）。启用后将 COS/CFS 指定路径挂载到容器内 /workspace 工作目录，与现有 Catalog 的卷配置互斥（不允许同时在 Catalog 中显式声明 MountPath=/workspace）。</p>
        /// </summary>
        [JsonProperty("PersistentWorkDir")]
        public PersistentWorkDir PersistentWorkDir{ get; set; }

        /// <summary>
        /// <p>是否开启token认证</p>
        /// </summary>
        [JsonProperty("EnableToken")]
        public bool? EnableToken{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（BuiltIn: 内置, Custom: 自定义-TCR, CustomCcr: 自定义-CCR）</p>
        /// </summary>
        [JsonProperty("ImagePullType")]
        public string ImagePullType{ get; set; }

        /// <summary>
        /// <p>Lab sidecar 镜像拉取类型（BuiltIn: 内置, Custom: 自定义-TCR, CustomCcr: 自定义-CCR）</p>
        /// </summary>
        [JsonProperty("LabImagePullType")]
        public string LabImagePullType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "LabImage", this.LabImage);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "ServiceTypes.", this.ServiceTypes);
            this.SetParamSimple(map, prefix + "ExampleId", this.ExampleId);
            this.SetParamSimple(map, prefix + "CodeArchiveUrl", this.CodeArchiveUrl);
            this.SetParamSimple(map, prefix + "LabImagePullPolicy", this.LabImagePullPolicy);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "PersistentWorkDir.", this.PersistentWorkDir);
            this.SetParamSimple(map, prefix + "EnableToken", this.EnableToken);
            this.SetParamSimple(map, prefix + "ImagePullType", this.ImagePullType);
            this.SetParamSimple(map, prefix + "LabImagePullType", this.LabImagePullType);
        }
    }
}

