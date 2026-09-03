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

    public class ModifyTrainingJobSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>配置 ID</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// <p>配置名称（不传则不更新）</p>
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// <p>配置描述（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>启动命令（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Entrypoint")]
        public string Entrypoint{ get; set; }

        /// <summary>
        /// <p>镜像地址（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像拉取类型（BuiltIn / Custom / CustomCcr，不传则不更新）</p>
        /// </summary>
        [JsonProperty("ImagePullType")]
        public string ImagePullType{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略（Always / IfNotPresent / Never，不传则不更新）</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }

        /// <summary>
        /// <p>代码包 COS URL（不传则不更新）</p>
        /// </summary>
        [JsonProperty("CodePackageUrl")]
        public string CodePackageUrl{ get; set; }

        /// <summary>
        /// <p>运行时环境配置 JSON（不传则不更新）</p>
        /// </summary>
        [JsonProperty("RuntimeEnv")]
        public string RuntimeEnv{ get; set; }

        /// <summary>
        /// <p>资源配置模板 ID（可选）</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public string ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>资源配置 JSON（不传则不更新）</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>资源分区 ID（不传则不更新）</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>队列名称（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>存储卷挂载配置 JSON（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>作业优先级 1-9（不传则不更新）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>高级参数 JSON（不传则不更新）</p>
        /// </summary>
        [JsonProperty("AdvancedOptions")]
        public string AdvancedOptions{ get; set; }

        /// <summary>
        /// <p>MlFlow 实验追踪配置（不传则不更新）</p>
        /// </summary>
        [JsonProperty("MlFlowConfig")]
        public MlFlowConfig MlFlowConfig{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），null 不修改，空数组清空，非空全量替换</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>基础模型ID（用于模型挂载）</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>输出模型名（用于产出模型自动注册）</p>
        /// </summary>
        [JsonProperty("OutputModelName")]
        public string OutputModelName{ get; set; }

        /// <summary>
        /// <p>训练模式：sft / dpo / cpt / grpo（仅 POST_TRAINING 有值）</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>数据集挂载列表（整体替换，不传则不更新）</p>
        /// </summary>
        [JsonProperty("Datasets")]
        public DatasetMount[] Datasets{ get; set; }

        /// <summary>
        /// <p>Checkpoint 产出配置（整体替换，不传则不更新）</p>
        /// </summary>
        [JsonProperty("Checkpoint")]
        public CheckpointConfig Checkpoint{ get; set; }

        /// <summary>
        /// <p>是否启用断点续训（创建时的意图声明；实际续训由实例级「断点续训」按钮触发，不传则不更新）</p>
        /// </summary>
        [JsonProperty("ResumeTraining")]
        public bool? ResumeTraining{ get; set; }

        /// <summary>
        /// <p>调优参数（整体替换，未填字段回模板默认值；不传则不更新；仅 POST_TRAINING）</p>
        /// </summary>
        [JsonProperty("TuningParams")]
        public TrainingTuningParams TuningParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
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
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "AdvancedOptions", this.AdvancedOptions);
            this.SetParamObj(map, prefix + "MlFlowConfig.", this.MlFlowConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "OutputModelName", this.OutputModelName);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamObj(map, prefix + "Checkpoint.", this.Checkpoint);
            this.SetParamSimple(map, prefix + "ResumeTraining", this.ResumeTraining);
            this.SetParamObj(map, prefix + "TuningParams.", this.TuningParams);
        }
    }
}

