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

    public class RestartModelAccelerateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型加速任务ID
        /// </summary>
        [JsonProperty("ModelAccTaskId")]
        public string ModelAccTaskId{ get; set; }

        /// <summary>
        /// 模型加速任务名称
        /// </summary>
        [JsonProperty("ModelAccTaskName")]
        public string ModelAccTaskName{ get; set; }

        /// <summary>
        /// 模型来源（JOB/COS）
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

        /// <summary>
        /// 算法框架（废弃）
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 模型输入cos路径
        /// </summary>
        [JsonProperty("ModelInputPath")]
        public CosPathInfo ModelInputPath{ get; set; }

        /// <summary>
        /// 优化级别（NO_LOSS/FP16/INT8），默认FP16
        /// </summary>
        [JsonProperty("OptimizationLevel")]
        public string OptimizationLevel{ get; set; }

        /// <summary>
        /// input节点个数（废弃）
        /// </summary>
        [JsonProperty("ModelInputNum")]
        public ulong? ModelInputNum{ get; set; }

        /// <summary>
        /// input节点信息（废弃）
        /// </summary>
        [JsonProperty("ModelInputInfos")]
        public ModelInputInfo[] ModelInputInfos{ get; set; }

        /// <summary>
        /// 模型输出cos路径
        /// </summary>
        [JsonProperty("ModelOutputPath")]
        public CosPathInfo ModelOutputPath{ get; set; }

        /// <summary>
        /// 模型格式（TORCH_SCRIPT/DETECTRON2/SAVED_MODEL/FROZEN_GRAPH/MMDETECTION/ONNX/HUGGING_FACE）
        /// </summary>
        [JsonProperty("ModelFormat")]
        public string ModelFormat{ get; set; }

        /// <summary>
        /// 模型Tensor信息
        /// </summary>
        [JsonProperty("TensorInfos")]
        public string[] TensorInfos{ get; set; }

        /// <summary>
        /// GPU类型（T4/V100/A10），默认T4
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }

        /// <summary>
        /// 模型专业参数
        /// </summary>
        [JsonProperty("HyperParameter")]
        public HyperParameter HyperParameter{ get; set; }

        /// <summary>
        /// 加速引擎版本
        /// </summary>
        [JsonProperty("AccEngineVersion")]
        public string AccEngineVersion{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// SavedModel保存时配置的签名
        /// </summary>
        [JsonProperty("ModelSignature")]
        public string ModelSignature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelAccTaskId", this.ModelAccTaskId);
            this.SetParamSimple(map, prefix + "ModelAccTaskName", this.ModelAccTaskName);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamObj(map, prefix + "ModelInputPath.", this.ModelInputPath);
            this.SetParamSimple(map, prefix + "OptimizationLevel", this.OptimizationLevel);
            this.SetParamSimple(map, prefix + "ModelInputNum", this.ModelInputNum);
            this.SetParamArrayObj(map, prefix + "ModelInputInfos.", this.ModelInputInfos);
            this.SetParamObj(map, prefix + "ModelOutputPath.", this.ModelOutputPath);
            this.SetParamSimple(map, prefix + "ModelFormat", this.ModelFormat);
            this.SetParamArraySimple(map, prefix + "TensorInfos.", this.TensorInfos);
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
            this.SetParamObj(map, prefix + "HyperParameter.", this.HyperParameter);
            this.SetParamSimple(map, prefix + "AccEngineVersion", this.AccEngineVersion);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ModelSignature", this.ModelSignature);
        }
    }
}

