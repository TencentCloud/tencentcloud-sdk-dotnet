/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class TrainingModelVersionDTO : AbstractModel
    {
        
        /// <summary>
        /// 模型id
        /// </summary>
        [JsonProperty("TrainingModelId")]
        public string TrainingModelId{ get; set; }

        /// <summary>
        /// 模型版本id
        /// </summary>
        [JsonProperty("TrainingModelVersionId")]
        public string TrainingModelVersionId{ get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        [JsonProperty("TrainingModelVersion")]
        public string TrainingModelVersion{ get; set; }

        /// <summary>
        /// 模型来源
        /// </summary>
        [JsonProperty("TrainingModelSource")]
        public string TrainingModelSource{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("TrainingModelCreateTime")]
        public string TrainingModelCreateTime{ get; set; }

        /// <summary>
        /// 创建人uin
        /// </summary>
        [JsonProperty("TrainingModelCreator")]
        public string TrainingModelCreator{ get; set; }

        /// <summary>
        /// 算法框架
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 推理环境
        /// </summary>
        [JsonProperty("ReasoningEnvironment")]
        public string ReasoningEnvironment{ get; set; }

        /// <summary>
        /// 推理环境来源
        /// </summary>
        [JsonProperty("ReasoningEnvironmentSource")]
        public string ReasoningEnvironmentSource{ get; set; }

        /// <summary>
        /// 模型指标
        /// </summary>
        [JsonProperty("TrainingModelIndex")]
        public string TrainingModelIndex{ get; set; }

        /// <summary>
        /// 训练任务名称
        /// </summary>
        [JsonProperty("TrainingJobName")]
        public string TrainingJobName{ get; set; }

        /// <summary>
        /// 模型cos路径
        /// </summary>
        [JsonProperty("TrainingModelCosPath")]
        public CosPathInfo TrainingModelCosPath{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("TrainingModelName")]
        public string TrainingModelName{ get; set; }

        /// <summary>
        /// 训练任务id
        /// </summary>
        [JsonProperty("TrainingJobId")]
        public string TrainingJobId{ get; set; }

        /// <summary>
        /// 自定义推理环境
        /// </summary>
        [JsonProperty("ReasoningImageInfo")]
        public ImageInfo ReasoningImageInfo{ get; set; }

        /// <summary>
        /// 模型版本创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模型处理状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingModelStatus")]
        public string TrainingModelStatus{ get; set; }

        /// <summary>
        /// 模型处理进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingModelProgress")]
        public ulong? TrainingModelProgress{ get; set; }

        /// <summary>
        /// 模型错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingModelErrorMsg")]
        public string TrainingModelErrorMsg{ get; set; }

        /// <summary>
        /// 模型格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingModelFormat")]
        public string TrainingModelFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrainingModelId", this.TrainingModelId);
            this.SetParamSimple(map, prefix + "TrainingModelVersionId", this.TrainingModelVersionId);
            this.SetParamSimple(map, prefix + "TrainingModelVersion", this.TrainingModelVersion);
            this.SetParamSimple(map, prefix + "TrainingModelSource", this.TrainingModelSource);
            this.SetParamSimple(map, prefix + "TrainingModelCreateTime", this.TrainingModelCreateTime);
            this.SetParamSimple(map, prefix + "TrainingModelCreator", this.TrainingModelCreator);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "ReasoningEnvironment", this.ReasoningEnvironment);
            this.SetParamSimple(map, prefix + "ReasoningEnvironmentSource", this.ReasoningEnvironmentSource);
            this.SetParamSimple(map, prefix + "TrainingModelIndex", this.TrainingModelIndex);
            this.SetParamSimple(map, prefix + "TrainingJobName", this.TrainingJobName);
            this.SetParamObj(map, prefix + "TrainingModelCosPath.", this.TrainingModelCosPath);
            this.SetParamSimple(map, prefix + "TrainingModelName", this.TrainingModelName);
            this.SetParamSimple(map, prefix + "TrainingJobId", this.TrainingJobId);
            this.SetParamObj(map, prefix + "ReasoningImageInfo.", this.ReasoningImageInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TrainingModelStatus", this.TrainingModelStatus);
            this.SetParamSimple(map, prefix + "TrainingModelProgress", this.TrainingModelProgress);
            this.SetParamSimple(map, prefix + "TrainingModelErrorMsg", this.TrainingModelErrorMsg);
            this.SetParamSimple(map, prefix + "TrainingModelFormat", this.TrainingModelFormat);
        }
    }
}

