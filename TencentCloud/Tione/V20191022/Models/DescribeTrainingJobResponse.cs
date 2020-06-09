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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrainingJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 算法镜像配置
        /// </summary>
        [JsonProperty("AlgorithmSpecification")]
        public AlgorithmSpecification AlgorithmSpecification{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TrainingJobName")]
        public string TrainingJobName{ get; set; }

        /// <summary>
        /// 算法超级参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HyperParameters")]
        public string HyperParameters{ get; set; }

        /// <summary>
        /// 输入数据配置
        /// </summary>
        [JsonProperty("InputDataConfig")]
        public InputDataConfig[] InputDataConfig{ get; set; }

        /// <summary>
        /// 输出数据配置
        /// </summary>
        [JsonProperty("OutputDataConfig")]
        public OutputDataConfig OutputDataConfig{ get; set; }

        /// <summary>
        /// 中止条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition{ get; set; }

        /// <summary>
        /// 计算实例配置
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public ResourceConfig ResourceConfig{ get; set; }

        /// <summary>
        /// 私有网络配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("LastModifiedTime")]
        public string LastModifiedTime{ get; set; }

        /// <summary>
        /// 任务开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingStartTime")]
        public string TrainingStartTime{ get; set; }

        /// <summary>
        /// 任务完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingEndTime")]
        public string TrainingEndTime{ get; set; }

        /// <summary>
        /// 模型输出配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelArtifacts")]
        public ModelArtifacts ModelArtifacts{ get; set; }

        /// <summary>
        /// 详细状态，取值范围
        /// Starting：启动中
        /// Downloading: 准备训练数据
        /// Training: 正在训练
        /// Uploading: 上传训练结果
        /// Completed：已完成
        /// Failed: 失败
        /// MaxRuntimeExceeded: 任务超过最大运行时间
        /// Stopping: 停止中
        /// Stopped：已停止
        /// </summary>
        [JsonProperty("SecondaryStatus")]
        public string SecondaryStatus{ get; set; }

        /// <summary>
        /// 详细状态事件记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryStatusTransitions")]
        public SecondaryStatusTransition[] SecondaryStatusTransitions{ get; set; }

        /// <summary>
        /// 角色名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 训练任务状态，取值范围
        /// InProgress：运行中
        /// Completed: 已完成
        /// Failed: 失败
        /// Stopping: 停止中
        /// Stopped：已停止
        /// </summary>
        [JsonProperty("TrainingJobStatus")]
        public string TrainingJobStatus{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AlgorithmSpecification.", this.AlgorithmSpecification);
            this.SetParamSimple(map, prefix + "TrainingJobName", this.TrainingJobName);
            this.SetParamSimple(map, prefix + "HyperParameters", this.HyperParameters);
            this.SetParamArrayObj(map, prefix + "InputDataConfig.", this.InputDataConfig);
            this.SetParamObj(map, prefix + "OutputDataConfig.", this.OutputDataConfig);
            this.SetParamObj(map, prefix + "StoppingCondition.", this.StoppingCondition);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "LastModifiedTime", this.LastModifiedTime);
            this.SetParamSimple(map, prefix + "TrainingStartTime", this.TrainingStartTime);
            this.SetParamSimple(map, prefix + "TrainingEndTime", this.TrainingEndTime);
            this.SetParamObj(map, prefix + "ModelArtifacts.", this.ModelArtifacts);
            this.SetParamSimple(map, prefix + "SecondaryStatus", this.SecondaryStatus);
            this.SetParamArrayObj(map, prefix + "SecondaryStatusTransitions.", this.SecondaryStatusTransitions);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "TrainingJobStatus", this.TrainingJobStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

