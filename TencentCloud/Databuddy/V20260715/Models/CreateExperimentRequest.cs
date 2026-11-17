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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExperimentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID（必填），可通过 ListWorkspaces 接口获取</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>实验名称（必填），同一工作空间内唯一</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>实验类型（必填），取值：MACHINE_LEARNING（机器学习）/ CLASSIFICATION（分类）/ REGRESSION（回归）/ FORECASTING（时间序列预测）/ AGENT（智能体）。传入其他值将返回 InvalidParameter.ExperimentTypeInvalid</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>实验描述（可选），建议长度不超过 1024 字符</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Studio目录树文件夹节点ID，即实验所在的目录节点，可通过 ListFiles 接口获取</p>
        /// </summary>
        [JsonProperty("StudioId")]
        public string StudioId{ get; set; }

        /// <summary>
        /// <p>实验标签列表（可选），key/value 均为字符串</p>
        /// </summary>
        [JsonProperty("Tags")]
        public ExperimentTag[] Tags{ get; set; }

        /// <summary>
        /// <p>AutoML配置（可选，仅 Type 为 CLASSIFICATION/REGRESSION/FORECASTING 时需要），包含评估指标、搜索空间、最大运行时间/次数/并发等</p>
        /// </summary>
        [JsonProperty("AutoMlConf")]
        public AutoMlConf AutoMlConf{ get; set; }

        /// <summary>
        /// <p>训练数据配置（可选，仅 AutoML 类型实验需要），指定训练数据表（Catalog.Schema.Table 三段式）与目标标签列</p>
        /// </summary>
        [JsonProperty("TrainingData")]
        public TrainingData TrainingData{ get; set; }

        /// <summary>
        /// <p>计算资源组ID（可选），指定实验运行所使用的计算资源，可通过 ListComputeResourceOptions 接口获取</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StudioId", this.StudioId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "AutoMlConf.", this.AutoMlConf);
            this.SetParamObj(map, prefix + "TrainingData.", this.TrainingData);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
        }
    }
}

