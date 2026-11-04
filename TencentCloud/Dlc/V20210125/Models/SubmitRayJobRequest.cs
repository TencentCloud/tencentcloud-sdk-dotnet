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

    public class SubmitRayJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>入口命令</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

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
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>运行时环境</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>镜像名称</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略（Always, IfNotPresent, Never）</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（BuiltIn: 内置, Custom: 自定义-TCR, CustomCcr: 自定义-CCR）</p>
        /// </summary>
        [JsonProperty("ImagePullType")]
        public string ImagePullType{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>目录</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>弹性伸缩配置</p>
        /// </summary>
        [JsonProperty("AutoscalerOptions")]
        public string AutoscalerOptions{ get; set; }

        /// <summary>
        /// <p>高级参数，JSON 字符串（透传到 Neutrino）</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>计算组ID；与 ClusterId 互斥。组成员展开为候选集群后由 neutrino 侧路由</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>集群分派策略，本期仅支持 RANDOM；大小写不敏感</p>
        /// </summary>
        [JsonProperty("DispatchStrategy")]
        public string DispatchStrategy{ get; set; }

        /// <summary>
        /// <p>作业优先级（1-9，数字越大优先级越高）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），用于将资源与腾讯云标签系统中的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>作业包 URL</p>
        /// </summary>
        [JsonProperty("JobPackage")]
        public string JobPackage{ get; set; }

        /// <summary>
        /// <p>作业包名称</p>
        /// </summary>
        [JsonProperty("JobPackageName")]
        public string JobPackageName{ get; set; }

        /// <summary>
        /// <p>作业包来源类型（Local: 本地上传, Cos: 用户自有 COS 桶地址）；缺省时按 Local 处理</p>
        /// </summary>
        [JsonProperty("JobPackageSource")]
        public string JobPackageSource{ get; set; }

        /// <summary>
        /// <p>业务来源标识，只为调用上下文，不落盘 JobSpec</p>
        /// </summary>
        [JsonProperty("JobSource")]
        public string JobSource{ get; set; }

        /// <summary>
        /// <p>外部工作流引擎业务键 flowId</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>外部工作流引擎业务键 executionId</p>
        /// </summary>
        [JsonProperty("ExecutionId")]
        public string ExecutionId{ get; set; }

        /// <summary>
        /// <p>用户网络配置 JSON 字符串</p>
        /// </summary>
        [JsonProperty("NetworkConfig")]
        public string NetworkConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "ImagePullType", this.ImagePullType);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "AutoscalerOptions", this.AutoscalerOptions);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DispatchStrategy", this.DispatchStrategy);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "JobPackage", this.JobPackage);
            this.SetParamSimple(map, prefix + "JobPackageName", this.JobPackageName);
            this.SetParamSimple(map, prefix + "JobPackageSource", this.JobPackageSource);
            this.SetParamSimple(map, prefix + "JobSource", this.JobSource);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "ExecutionId", this.ExecutionId);
            this.SetParamSimple(map, prefix + "NetworkConfig", this.NetworkConfig);
        }
    }
}

