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

    public class ModelAccelerateTask : AbstractModel
    {
        
        /// <summary>
        /// 模型加速任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccTaskId")]
        public string ModelAccTaskId{ get; set; }

        /// <summary>
        /// 模型加速任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelAccTaskName")]
        public string ModelAccTaskName{ get; set; }

        /// <summary>
        /// 模型ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 模型来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

        /// <summary>
        /// 优化级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptimizationLevel")]
        public string OptimizationLevel{ get; set; }

        /// <summary>
        /// 任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// input节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelInputNum")]
        public ulong? ModelInputNum{ get; set; }

        /// <summary>
        /// input节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelInputInfos")]
        public ModelInputInfo[] ModelInputInfos{ get; set; }

        /// <summary>
        /// GPU型号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }

        /// <summary>
        /// 计费模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 加速比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Speedup")]
        public string Speedup{ get; set; }

        /// <summary>
        /// 模型输入cos路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelInputPath")]
        public CosPathInfo ModelInputPath{ get; set; }

        /// <summary>
        /// 模型输出cos路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelOutputPath")]
        public CosPathInfo ModelOutputPath{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 算法框架
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// 排队个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitNumber")]
        public ulong? WaitNumber{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskProgress")]
        public ulong? TaskProgress{ get; set; }

        /// <summary>
        /// 模型格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelFormat")]
        public string ModelFormat{ get; set; }

        /// <summary>
        /// 模型Tensor信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TensorInfos")]
        public string[] TensorInfos{ get; set; }

        /// <summary>
        /// 模型专业参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HyperParameter")]
        public HyperParameter HyperParameter{ get; set; }

        /// <summary>
        /// 加速引擎版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccEngineVersion")]
        public string AccEngineVersion{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 优化模型是否已保存到模型仓库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSaved")]
        public bool? IsSaved{ get; set; }

        /// <summary>
        /// SAVED_MODEL保存时配置的签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelSignature")]
        public string ModelSignature{ get; set; }

        /// <summary>
        /// 是否是QAT模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QATModel")]
        public bool? QATModel{ get; set; }

        /// <summary>
        /// 加速引擎对应的框架版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// 模型版本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelVersionId")]
        public string ModelVersionId{ get; set; }

        /// <summary>
        /// 资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelAccTaskId", this.ModelAccTaskId);
            this.SetParamSimple(map, prefix + "ModelAccTaskName", this.ModelAccTaskName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamSimple(map, prefix + "OptimizationLevel", this.OptimizationLevel);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "ModelInputNum", this.ModelInputNum);
            this.SetParamArrayObj(map, prefix + "ModelInputInfos.", this.ModelInputInfos);
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "Speedup", this.Speedup);
            this.SetParamObj(map, prefix + "ModelInputPath.", this.ModelInputPath);
            this.SetParamObj(map, prefix + "ModelOutputPath.", this.ModelOutputPath);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "WaitNumber", this.WaitNumber);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TaskProgress", this.TaskProgress);
            this.SetParamSimple(map, prefix + "ModelFormat", this.ModelFormat);
            this.SetParamArraySimple(map, prefix + "TensorInfos.", this.TensorInfos);
            this.SetParamObj(map, prefix + "HyperParameter.", this.HyperParameter);
            this.SetParamSimple(map, prefix + "AccEngineVersion", this.AccEngineVersion);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsSaved", this.IsSaved);
            this.SetParamSimple(map, prefix + "ModelSignature", this.ModelSignature);
            this.SetParamSimple(map, prefix + "QATModel", this.QATModel);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamSimple(map, prefix + "ModelVersionId", this.ModelVersionId);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
        }
    }
}

