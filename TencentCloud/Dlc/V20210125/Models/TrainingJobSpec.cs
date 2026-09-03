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

    public class TrainingJobSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>训练作业配置 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// <p>训练作业配置名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>配置描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>提交模式（LAB / CUSTOM_CODE / POST_TRAINING / UNKNOWN）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>启动命令</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>镜像地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（BuiltIn / Custom / CustomCcr）</p>
        /// </summary>
        [JsonProperty("ImagePullType")]
        public string ImagePullType{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略（Always / IfNotPresent / Never）</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>代码包 COS URL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodePackageUrl")]
        public string CodePackageUrl{ get; set; }

        /// <summary>
        /// <p>Ray runtime_env 配置 JSON</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>资源配置模板 ID</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public string ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>资源配置 JSON</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>资源分区 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>Checkpoint 挂载摘要</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckpointMountInfo")]
        public CheckpointMountInfo CheckpointMountInfo{ get; set; }

        /// <summary>
        /// <p>存储卷挂载配置 JSON</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>关联实例总数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>是否存在运行中实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasRunningInstances")]
        public bool? HasRunningInstances{ get; set; }

        /// <summary>
        /// <p>作业优先级（1-9，数字越大优先级越高）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>提交时 MLflow 配置 JSON（含 MlFlowMode / MlFlowTrackingUri 等）</p>
        /// </summary>
        [JsonProperty("MlFlowConfig")]
        public string MlFlowConfig{ get; set; }

        /// <summary>
        /// <p>产出模型名称（用于后续模型注册）</p>
        /// </summary>
        [JsonProperty("OutputModelName")]
        public string OutputModelName{ get; set; }

        /// <summary>
        /// <p>训练模式：sft / dpo / cpt / grpo（仅 POST_TRAINING 有值）</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>基础模型 modelUid（仅 POST_TRAINING 有值）</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>基础模型名称（仅 POST_TRAINING 有值）</p>
        /// </summary>
        [JsonProperty("BaseModelName")]
        public string BaseModelName{ get; set; }

        /// <summary>
        /// <p>提交时的数据集挂载列表（List&lt;DatasetMount&gt;，仅详情返回）</p>
        /// </summary>
        [JsonProperty("Datasets")]
        public DatasetMount[] Datasets{ get; set; }

        /// <summary>
        /// <p>提交时的 Checkpoint 产出配置（仅详情返回）</p>
        /// </summary>
        [JsonProperty("LastInstanceStatus")]
        public string LastInstanceStatus{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue）</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>提交时的 Checkpoint 产出配置（仅详情返回）</p>
        /// </summary>
        [JsonProperty("Checkpoint")]
        public CheckpointConfig Checkpoint{ get; set; }

        /// <summary>
        /// <p>提交时的调优参数（仅 POST_TRAINING，仅详情返回）</p>
        /// </summary>
        [JsonProperty("TuningParams")]
        public TrainingTuningParams TuningParams{ get; set; }

        /// <summary>
        /// <p>提交时的断点续训意图声明（仅详情返回）</p>
        /// </summary>
        [JsonProperty("ResumeTraining")]
        public bool? ResumeTraining{ get; set; }

        /// <summary>
        /// <p>高级参数 JSON（透传给 Neutrino advanced_options）</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImagePullType", this.ImagePullType);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "CodePackageUrl", this.CodePackageUrl);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "ResourcePartitionName", this.ResourcePartitionName);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamObj(map, prefix + "CheckpointMountInfo.", this.CheckpointMountInfo);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "HasRunningInstances", this.HasRunningInstances);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "MlFlowConfig", this.MlFlowConfig);
            this.SetParamSimple(map, prefix + "OutputModelName", this.OutputModelName);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "BaseModelName", this.BaseModelName);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamSimple(map, prefix + "LastInstanceStatus", this.LastInstanceStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Checkpoint.", this.Checkpoint);
            this.SetParamObj(map, prefix + "TuningParams.", this.TuningParams);
            this.SetParamSimple(map, prefix + "ResumeTraining", this.ResumeTraining);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
        }
    }
}

