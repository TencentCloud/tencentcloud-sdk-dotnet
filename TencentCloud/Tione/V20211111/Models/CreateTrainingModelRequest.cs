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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTrainingModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 导入方式
        /// MODEL：导入新模型
        /// VERSION：导入新版本
        /// EXIST：导入现有版本
        /// </summary>
        [JsonProperty("ImportMethod")]
        public string ImportMethod{ get; set; }

        /// <summary>
        /// 推理环境来源（SYSTEM/CUSTOM）
        /// </summary>
        [JsonProperty("ReasoningEnvironmentSource")]
        public string ReasoningEnvironmentSource{ get; set; }

        /// <summary>
        /// 模型名称，不超过60个字符，仅支持中英文、数字、下划线"_"、短横"-"，只能以中英文、数字开头
        /// </summary>
        [JsonProperty("TrainingModelName")]
        public string TrainingModelName{ get; set; }

        /// <summary>
        /// 标签配置
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 训练任务名称
        /// </summary>
        [JsonProperty("TrainingJobName")]
        public string TrainingJobName{ get; set; }

        /// <summary>
        /// 模型来源cos目录，以/结尾
        /// </summary>
        [JsonProperty("TrainingModelCosPath")]
        public CosPathInfo TrainingModelCosPath{ get; set; }

        /// <summary>
        /// 算法框架 （PYTORCH/TENSORFLOW/DETECTRON2/PMML/MMDETECTION/ONNX)
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 推理环境
        /// </summary>
        [JsonProperty("ReasoningEnvironment")]
        public string ReasoningEnvironment{ get; set; }

        /// <summary>
        /// 训练指标，最多支持1000字符
        /// </summary>
        [JsonProperty("TrainingModelIndex")]
        public string TrainingModelIndex{ get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        [JsonProperty("TrainingModelVersion")]
        public string TrainingModelVersion{ get; set; }

        /// <summary>
        /// 自定义推理环境
        /// </summary>
        [JsonProperty("ReasoningImageInfo")]
        public ImageInfo ReasoningImageInfo{ get; set; }

        /// <summary>
        /// 模型移动方式（CUT/COPY）
        /// </summary>
        [JsonProperty("ModelMoveMode")]
        public string ModelMoveMode{ get; set; }

        /// <summary>
        /// 训练任务ID
        /// </summary>
        [JsonProperty("TrainingJobId")]
        public string TrainingJobId{ get; set; }

        /// <summary>
        /// 模型ID（导入新模型不需要，导入新版本需要）
        /// </summary>
        [JsonProperty("TrainingModelId")]
        public string TrainingModelId{ get; set; }

        /// <summary>
        /// 模型存储cos目录
        /// </summary>
        [JsonProperty("ModelOutputPath")]
        public CosPathInfo ModelOutputPath{ get; set; }

        /// <summary>
        /// 模型来源 （JOB/COS）
        /// </summary>
        [JsonProperty("TrainingModelSource")]
        public string TrainingModelSource{ get; set; }

        /// <summary>
        /// 模型偏好
        /// </summary>
        [JsonProperty("TrainingPreference")]
        public string TrainingPreference{ get; set; }

        /// <summary>
        /// 自动学习任务ID（已废弃）
        /// </summary>
        [JsonProperty("AutoMLTaskId")]
        public string AutoMLTaskId{ get; set; }

        /// <summary>
        /// 任务版本
        /// </summary>
        [JsonProperty("TrainingJobVersion")]
        public string TrainingJobVersion{ get; set; }

        /// <summary>
        /// 模型版本类型；
        /// 枚举值：NORMAL(通用)  ACCELERATE(加速)
        /// 注意:  默认为NORMAL
        /// </summary>
        [JsonProperty("ModelVersionType")]
        public string ModelVersionType{ get; set; }

        /// <summary>
        /// 模型格式 （PYTORCH/TORCH_SCRIPT/DETECTRON2/SAVED_MODEL/FROZEN_GRAPH/PMML/MMDETECTION/ONNX/HUGGING_FACE_BERT/HUGGING_FACE_STABLE_DIFFUSION/HUGGING_FACE_STABLE_DIFFUSION_LORA/WEB_UI_STABLE_DIFFUSION）
        /// </summary>
        [JsonProperty("ModelFormat")]
        public string ModelFormat{ get; set; }

        /// <summary>
        /// 推理镜像ID
        /// </summary>
        [JsonProperty("ReasoningEnvironmentId")]
        public string ReasoningEnvironmentId{ get; set; }

        /// <summary>
        /// 模型自动清理开关(true/false)，当前版本仅支持SAVED_MODEL格式模型
        /// </summary>
        [JsonProperty("AutoClean")]
        public string AutoClean{ get; set; }

        /// <summary>
        /// 模型数量保留上限(默认值为24个，上限为24，下限为1，步长为1)
        /// </summary>
        [JsonProperty("MaxReservedModels")]
        public ulong? MaxReservedModels{ get; set; }

        /// <summary>
        /// 模型清理周期(默认值为1分钟，上限为1440，下限为1分钟，步长为1)
        /// </summary>
        [JsonProperty("ModelCleanPeriod")]
        public ulong? ModelCleanPeriod{ get; set; }

        /// <summary>
        /// 是否QAT模型
        /// </summary>
        [JsonProperty("IsQAT")]
        public bool? IsQAT{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImportMethod", this.ImportMethod);
            this.SetParamSimple(map, prefix + "ReasoningEnvironmentSource", this.ReasoningEnvironmentSource);
            this.SetParamSimple(map, prefix + "TrainingModelName", this.TrainingModelName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TrainingJobName", this.TrainingJobName);
            this.SetParamObj(map, prefix + "TrainingModelCosPath.", this.TrainingModelCosPath);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "ReasoningEnvironment", this.ReasoningEnvironment);
            this.SetParamSimple(map, prefix + "TrainingModelIndex", this.TrainingModelIndex);
            this.SetParamSimple(map, prefix + "TrainingModelVersion", this.TrainingModelVersion);
            this.SetParamObj(map, prefix + "ReasoningImageInfo.", this.ReasoningImageInfo);
            this.SetParamSimple(map, prefix + "ModelMoveMode", this.ModelMoveMode);
            this.SetParamSimple(map, prefix + "TrainingJobId", this.TrainingJobId);
            this.SetParamSimple(map, prefix + "TrainingModelId", this.TrainingModelId);
            this.SetParamObj(map, prefix + "ModelOutputPath.", this.ModelOutputPath);
            this.SetParamSimple(map, prefix + "TrainingModelSource", this.TrainingModelSource);
            this.SetParamSimple(map, prefix + "TrainingPreference", this.TrainingPreference);
            this.SetParamSimple(map, prefix + "AutoMLTaskId", this.AutoMLTaskId);
            this.SetParamSimple(map, prefix + "TrainingJobVersion", this.TrainingJobVersion);
            this.SetParamSimple(map, prefix + "ModelVersionType", this.ModelVersionType);
            this.SetParamSimple(map, prefix + "ModelFormat", this.ModelFormat);
            this.SetParamSimple(map, prefix + "ReasoningEnvironmentId", this.ReasoningEnvironmentId);
            this.SetParamSimple(map, prefix + "AutoClean", this.AutoClean);
            this.SetParamSimple(map, prefix + "MaxReservedModels", this.MaxReservedModels);
            this.SetParamSimple(map, prefix + "ModelCleanPeriod", this.ModelCleanPeriod);
            this.SetParamSimple(map, prefix + "IsQAT", this.IsQAT);
        }
    }
}

