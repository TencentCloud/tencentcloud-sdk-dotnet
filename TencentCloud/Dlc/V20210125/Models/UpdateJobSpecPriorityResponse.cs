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

    public class UpdateJobSpecPriorityResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>配置ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>配置名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>配置描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>入口命令</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（Builtin: 内置, Custom: 自定义）</p>
        /// </summary>
        [JsonProperty("ImagePullType")]
        public string ImagePullType{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>资源配置(JSON)</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>运行时环境配置(JSON)</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>存储卷和挂载卷配置(JSON)</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>弹性伸缩配置(JSON)</p>
        /// </summary>
        [JsonProperty("AutoscalerOptions")]
        public string AutoscalerOptions{ get; set; }

        /// <summary>
        /// <p>资源配置ID</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public string ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>资源配置模板是否变更</p>
        /// </summary>
        [JsonProperty("ResourceConfigChanged")]
        public bool? ResourceConfigChanged{ get; set; }

        /// <summary>
        /// <p>默认资源分区ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>默认资源分区名称</p>
        /// </summary>
        [JsonProperty("ResourcePartitionName")]
        public string ResourcePartitionName{ get; set; }

        /// <summary>
        /// <p>默认队列名称</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>默认计算组 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>默认集群 ID（与 GroupId 互斥）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群分派策略（本期仅支持 RANDOM；NULL 时退化为依赖 ClusterGroup 配置兜底）</p>
        /// </summary>
        [JsonProperty("DispatchStrategy")]
        public string DispatchStrategy{ get; set; }

        /// <summary>
        /// <p>作业包URL</p>
        /// </summary>
        [JsonProperty("JobPackage")]
        public string JobPackage{ get; set; }

        /// <summary>
        /// <p>作业包名称</p>
        /// </summary>
        [JsonProperty("JobPackageName")]
        public string JobPackageName{ get; set; }

        /// <summary>
        /// <p>作业优先级（1-9，数字越大优先级越高）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建者UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>子用户UIN</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>该配置下未进入终态的作业实例数量</p>
        /// </summary>
        [JsonProperty("JobInstanceCount")]
        public long? JobInstanceCount{ get; set; }

        /// <summary>
        /// <p>是否有运行中的作业实例</p>
        /// </summary>
        [JsonProperty("HasRunningJobs")]
        public bool? HasRunningJobs{ get; set; }

        /// <summary>
        /// <p>高级参数，JSON 字符串（内容为 Key-Value 对象）</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），用于将资源与腾讯云标签系统中的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>作业包来源类型（Local: 本地上传, Cos: 用户自有 COS 桶地址）；缺时按 Local 处理</p>
        /// </summary>
        [JsonProperty("JobPackageSource")]
        public string JobPackageSource{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImagePullType", this.ImagePullType);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "AutoscalerOptions", this.AutoscalerOptions);
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamSimple(map, prefix + "ResourceConfigChanged", this.ResourceConfigChanged);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "ResourcePartitionName", this.ResourcePartitionName);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DispatchStrategy", this.DispatchStrategy);
            this.SetParamSimple(map, prefix + "JobPackage", this.JobPackage);
            this.SetParamSimple(map, prefix + "JobPackageName", this.JobPackageName);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "JobInstanceCount", this.JobInstanceCount);
            this.SetParamSimple(map, prefix + "HasRunningJobs", this.HasRunningJobs);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "JobPackageSource", this.JobPackageSource);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

