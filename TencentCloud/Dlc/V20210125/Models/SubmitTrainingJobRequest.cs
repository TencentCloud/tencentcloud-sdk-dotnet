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

    public class SubmitTrainingJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>训练作业配置名称（≤255 字符）</p>
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>描述（≤1024 字符）</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>启动命令</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（BuiltIn: 内置, Custom: 自定义-TCR, CustomCcr: 自定义-CCR）</p>
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
        /// </summary>
        [JsonProperty("CodePackageUrl")]
        public string CodePackageUrl{ get; set; }

        /// <summary>
        /// <p>Ray runtime_env 配置 JSON（含 pip 依赖、env_vars 等，结构参见 2.1）</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>资源配置模板 ID(可选)</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public string ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>资源配置 JSON</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>资源分区 ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>队列名称</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>存储卷挂载配置 JSON（含 Source 字段标记用途）</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>高级参数 JSON（不传则不更新）</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>基础模型Uid</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>算法模式：sft / dpo / cpt / grpo（仅 POST_TRAINING 必填，CUSTOM_CODE / LAB 禁止传入）</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>数据集挂载列表（元素含 DatasetId 或 Catalog 二选一 + DatasetName + Eval 属性）</p>
        /// </summary>
        [JsonProperty("Datasets")]
        public DatasetMount[] Datasets{ get; set; }

        /// <summary>
        /// <p>Checkpoint 产出配置（POST_TRAINING 必填；CUSTOM_CODE / LAB 可选）</p>
        /// </summary>
        [JsonProperty("Checkpoint")]
        public CheckpointConfig Checkpoint{ get; set; }

        /// <summary>
        /// <p>是否启用断点续训</p>
        /// </summary>
        [JsonProperty("ResumeTraining")]
        public bool? ResumeTraining{ get; set; }

        /// <summary>
        /// <p>调优参数（高级参数，仅 POST_TRAINING 使用；CUSTOM_CODE / LAB 禁止传入）</p>
        /// </summary>
        [JsonProperty("TuningParams")]
        public TrainingTuningParams TuningParams{ get; set; }

        /// <summary>
        /// <p>作业优先级（1-9，数字越大优先级越高）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>提交来源标签：LAB / CUSTOM_CODE（可选，用于溯源，不影响处理逻辑）</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>MlFlow 实验追踪配置（可选，不传则不启用 MlFlow）</p>
        /// </summary>
        [JsonProperty("MlFlowConfig")]
        public MlFlowConfig MlFlowConfig{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），用于将任务与腾讯云标签系统中的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>产出模型名称（用于后续模型注册，当前仅保存）</p>
        /// </summary>
        [JsonProperty("OutputModelName")]
        public string OutputModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Entrypoint", this.Entrypoint);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImagePullType", this.ImagePullType);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
            this.SetParamSimple(map, prefix + "CodePackageUrl", this.CodePackageUrl);
            this.SetParamSimple(map, prefix + "RuntimeEnv", this.RuntimeEnv);
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamObj(map, prefix + "Checkpoint.", this.Checkpoint);
            this.SetParamSimple(map, prefix + "ResumeTraining", this.ResumeTraining);
            this.SetParamObj(map, prefix + "TuningParams.", this.TuningParams);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamObj(map, prefix + "MlFlowConfig.", this.MlFlowConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OutputModelName", this.OutputModelName);
        }
    }
}

