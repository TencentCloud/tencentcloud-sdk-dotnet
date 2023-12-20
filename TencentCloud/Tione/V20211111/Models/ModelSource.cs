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

    public class ModelSource : AbstractModel
    {
        
        /// <summary>
        /// 来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 来源任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 来源任务版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobVersion")]
        public string JobVersion{ get; set; }

        /// <summary>
        /// 来源任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 算法框架
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 训练偏好
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingPreference")]
        public string TrainingPreference{ get; set; }

        /// <summary>
        /// 推理环境来源，SYSTEM/CUSTOM
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasoningEnvironmentSource")]
        public string ReasoningEnvironmentSource{ get; set; }

        /// <summary>
        /// 推理环境
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasoningEnvironment")]
        public string ReasoningEnvironment{ get; set; }

        /// <summary>
        /// 推理环境id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasoningEnvironmentId")]
        public string ReasoningEnvironmentId{ get; set; }

        /// <summary>
        /// 自定义推理环境
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasoningImageInfo")]
        public ImageInfo ReasoningImageInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobVersion", this.JobVersion);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "TrainingPreference", this.TrainingPreference);
            this.SetParamSimple(map, prefix + "ReasoningEnvironmentSource", this.ReasoningEnvironmentSource);
            this.SetParamSimple(map, prefix + "ReasoningEnvironment", this.ReasoningEnvironment);
            this.SetParamSimple(map, prefix + "ReasoningEnvironmentId", this.ReasoningEnvironmentId);
            this.SetParamObj(map, prefix + "ReasoningImageInfo.", this.ReasoningImageInfo);
        }
    }
}

