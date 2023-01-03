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

    public class CreateBatchModelAccTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型加速任务名称
        /// </summary>
        [JsonProperty("ModelAccTaskName")]
        public string ModelAccTaskName{ get; set; }

        /// <summary>
        /// 批量模型加速任务
        /// </summary>
        [JsonProperty("BatchModelAccTasks")]
        public BatchModelAccTask[] BatchModelAccTasks{ get; set; }

        /// <summary>
        /// 模型加速保存路径
        /// </summary>
        [JsonProperty("ModelOutputPath")]
        public CosPathInfo ModelOutputPath{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 优化级别(NO_LOSS/FP16/INT8)，默认FP16
        /// </summary>
        [JsonProperty("OptimizationLevel")]
        public string OptimizationLevel{ get; set; }

        /// <summary>
        /// GPU卡类型(T4/V100/A10)，默认T4
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }

        /// <summary>
        /// 专业参数设置
        /// </summary>
        [JsonProperty("HyperParameter")]
        public HyperParameter HyperParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelAccTaskName", this.ModelAccTaskName);
            this.SetParamArrayObj(map, prefix + "BatchModelAccTasks.", this.BatchModelAccTasks);
            this.SetParamObj(map, prefix + "ModelOutputPath.", this.ModelOutputPath);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OptimizationLevel", this.OptimizationLevel);
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
            this.SetParamObj(map, prefix + "HyperParameter.", this.HyperParameter);
        }
    }
}

