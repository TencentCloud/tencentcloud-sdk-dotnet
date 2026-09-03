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

    public class TrainingJobInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID（即 RayJob UUID）</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>关联配置 ID</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// <p>配置名称</p>
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>作业优先级（1-9，数字越大优先级越高）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>综合状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>RayJob 实际启动时间（毫秒）</p>
        /// </summary>
        [JsonProperty("JobCreateTime")]
        public long? JobCreateTime{ get; set; }

        /// <summary>
        /// <p>RayJob 运行时长（毫秒）</p>
        /// </summary>
        [JsonProperty("JobRunningTime")]
        public long? JobRunningTime{ get; set; }

        /// <summary>
        /// <p>Ray Dashboard History 链接</p>
        /// </summary>
        [JsonProperty("HistoryUrl")]
        public string HistoryUrl{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建时间（毫秒时间戳）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>资源分区 ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>资源分区名称</p>
        /// </summary>
        [JsonProperty("ResourcePartitionName")]
        public string ResourcePartitionName{ get; set; }

        /// <summary>
        /// <p>队列名称</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>提交时 runtime_env JSON</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>提交时 entrypoint</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>提交时镜像</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>提交时资源配置 JSON</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>提交时存储卷挂载配置 JSON</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>提交时高级参数 JSON</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>训练子类型快照（LAB / CUSTOM_CODE / POST_TRAINING）</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>提交时代码包 URL</p>
        /// </summary>
        [JsonProperty("CodePackageUrl")]
        public string CodePackageUrl{ get; set; }

        /// <summary>
        /// <p>提交时 MLflow 配置 JSON</p>
        /// </summary>
        [JsonProperty("MlFlowConfig")]
        public string MlFlowConfig{ get; set; }

        /// <summary>
        /// <p>Checkpoint 挂载摘要（实例级）</p>
        /// </summary>
        [JsonProperty("CheckpointMountInfo")]
        public CheckpointMountInfo CheckpointMountInfo{ get; set; }

        /// <summary>
        /// <p>训练方式（sft / dpo / cpt / grpo），仅 POST_TRAINING 有值</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>基础模型 modelUid（仅 POST_TRAINING 有值，用于关联推理模型仓库）</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>基础模型名称（仅 POST_TRAINING 有值）</p>
        /// </summary>
        [JsonProperty("BaseModelName")]
        public string BaseModelName{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue）</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>创建实例时的数据集挂载列表快照（List&lt;DatasetMount&gt;，仅详情返回）</p>
        /// </summary>
        [JsonProperty("Datasets")]
        public DatasetMount[] Datasets{ get; set; }

        /// <summary>
        /// <p>创建实例时的 Checkpoint 产出配置快照（仅详情返回）</p>
        /// </summary>
        [JsonProperty("Checkpoint")]
        public CheckpointConfig Checkpoint{ get; set; }

        /// <summary>
        /// <p>创建实例时的调优参数快照（仅 POST_TRAINING，仅详情返回）</p>
        /// </summary>
        [JsonProperty("TuningParams")]
        public TrainingTuningParams TuningParams{ get; set; }

        /// <summary>
        /// <p>创建实例时的断点续训意图声明快照（仅详情返回）</p>
        /// </summary>
        [JsonProperty("ResumeTraining")]
        public bool? ResumeTraining{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "JobCreateTime", this.JobCreateTime);
            this.SetParamSimple(map, prefix + "JobRunningTime", this.JobRunningTime);
            this.SetParamSimple(map, prefix + "HistoryUrl", this.HistoryUrl);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "ResourcePartitionName", this.ResourcePartitionName);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "CodePackageUrl", this.CodePackageUrl);
            this.SetParamSimple(map, prefix + "MlFlowConfig", this.MlFlowConfig);
            this.SetParamObj(map, prefix + "CheckpointMountInfo.", this.CheckpointMountInfo);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "BaseModelName", this.BaseModelName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamObj(map, prefix + "Checkpoint.", this.Checkpoint);
            this.SetParamObj(map, prefix + "TuningParams.", this.TuningParams);
            this.SetParamSimple(map, prefix + "ResumeTraining", this.ResumeTraining);
        }
    }
}

