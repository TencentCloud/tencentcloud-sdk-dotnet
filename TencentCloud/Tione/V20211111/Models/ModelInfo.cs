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

    public class ModelInfo : AbstractModel
    {
        
        /// <summary>
        /// 模型版本id, DescribeTrainingModelVersion查询模型接口时的id
        /// 自动学习类型的模型填写自动学习的任务id
        /// </summary>
        [JsonProperty("ModelVersionId")]
        public string ModelVersionId{ get; set; }

        /// <summary>
        /// 模型id
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型名
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 模型来源
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

        /// <summary>
        /// cos路径信息
        /// </summary>
        [JsonProperty("CosPathInfo")]
        public CosPathInfo CosPathInfo{ get; set; }

        /// <summary>
        /// GooseFSx的配置，ModelSource为GooseFSx时有效
        /// </summary>
        [JsonProperty("GooseFSx")]
        public GooseFSx GooseFSx{ get; set; }

        /// <summary>
        /// 模型对应的算法框架，预留
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 默认为 NORMAL, 已加速模型: ACCELERATE, 自动学习模型 AUTO_ML
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// 模型格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelFormat")]
        public string ModelFormat{ get; set; }

        /// <summary>
        /// 是否为私有化大模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPrivateModel")]
        public bool? IsPrivateModel{ get; set; }

        /// <summary>
        /// 模型的类别 多模态MultiModal, 文本大模型 LLM
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelVersionId", this.ModelVersionId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamObj(map, prefix + "CosPathInfo.", this.CosPathInfo);
            this.SetParamObj(map, prefix + "GooseFSx.", this.GooseFSx);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "ModelFormat", this.ModelFormat);
            this.SetParamSimple(map, prefix + "IsPrivateModel", this.IsPrivateModel);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
        }
    }
}

