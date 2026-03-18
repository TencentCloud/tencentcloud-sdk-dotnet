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

    public class PublicAlgoVersion : AbstractModel
    {
        
        /// <summary>
        /// 公共算法版本Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAlgoVersionId")]
        public string PublicAlgoVersionId{ get; set; }

        /// <summary>
        /// 对应的公共算法组Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicAlgoGroupId")]
        public string PublicAlgoGroupId{ get; set; }

        /// <summary>
        /// 版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 模型简介
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Introduction")]
        public string Introduction{ get; set; }

        /// <summary>
        /// 预览信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewInfo")]
        public string PreviewInfo{ get; set; }

        /// <summary>
        /// 预置训练镜像信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainImageInfo")]
        public ImageInfo PresetTrainImageInfo{ get; set; }

        /// <summary>
        /// 预置训练代码信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainCodeInfo")]
        public MaterialInfo PresetTrainCodeInfo{ get; set; }

        /// <summary>
        /// 预置模型信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetModelInfo")]
        public MaterialInfo PresetModelInfo{ get; set; }

        /// <summary>
        /// 是否已经被导入到我的算法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsImported")]
        public bool? IsImported{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 默认训练资源规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultResourceSpec")]
        public ResourceSpec DefaultResourceSpec{ get; set; }

        /// <summary>
        /// 默认推理资源规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultInferenceResourceSpec")]
        public ResourceSpec DefaultInferenceResourceSpec{ get; set; }

        /// <summary>
        /// 是否支持直接部署推理服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportDeploy")]
        public bool? SupportDeploy{ get; set; }

        /// <summary>
        /// 内置训练数据集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainDataset")]
        public MaterialInfo PresetTrainDataset{ get; set; }

        /// <summary>
        /// 训练代码包下载路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainCodeDownloadUrl")]
        public string TrainCodeDownloadUrl{ get; set; }

        /// <summary>
        /// 内置数据下载路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainDataDownloadUrl")]
        public string TrainDataDownloadUrl{ get; set; }

        /// <summary>
        /// 训练参数列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainParams")]
        public TrainParam[] TrainParams{ get; set; }

        /// <summary>
        /// 训练启动命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainCodeStartCmd")]
        public string PresetTrainCodeStartCmd{ get; set; }

        /// <summary>
        /// 是否非公开模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPrivateModel")]
        public bool? IsPrivateModel{ get; set; }

        /// <summary>
        /// 各种设备下的训练镜像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainImageInfoList")]
        public DeviceImageInfo[] PresetTrainImageInfoList{ get; set; }

        /// <summary>
        /// 各种设备下的推理镜像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetInferenceImageInfoList")]
        public DeviceImageInfo[] PresetInferenceImageInfoList{ get; set; }

        /// <summary>
        /// 各种设备下的训练代码信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetTrainCodeInfoList")]
        public DeviceMaterialInfo[] PresetTrainCodeInfoList{ get; set; }

        /// <summary>
        /// 各种设备下的内置模型信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetModelInfoList")]
        public DeviceMaterialInfo[] PresetModelInfoList{ get; set; }

        /// <summary>
        /// 模型类别，比如LLM/MultiModal
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }

        /// <summary>
        /// 公共算法Id
        /// </summary>
        [JsonProperty("PublicAlgoSeriesId")]
        public string PublicAlgoSeriesId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicAlgoVersionId", this.PublicAlgoVersionId);
            this.SetParamSimple(map, prefix + "PublicAlgoGroupId", this.PublicAlgoGroupId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Introduction", this.Introduction);
            this.SetParamSimple(map, prefix + "PreviewInfo", this.PreviewInfo);
            this.SetParamObj(map, prefix + "PresetTrainImageInfo.", this.PresetTrainImageInfo);
            this.SetParamObj(map, prefix + "PresetTrainCodeInfo.", this.PresetTrainCodeInfo);
            this.SetParamObj(map, prefix + "PresetModelInfo.", this.PresetModelInfo);
            this.SetParamSimple(map, prefix + "IsImported", this.IsImported);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "DefaultResourceSpec.", this.DefaultResourceSpec);
            this.SetParamObj(map, prefix + "DefaultInferenceResourceSpec.", this.DefaultInferenceResourceSpec);
            this.SetParamSimple(map, prefix + "SupportDeploy", this.SupportDeploy);
            this.SetParamObj(map, prefix + "PresetTrainDataset.", this.PresetTrainDataset);
            this.SetParamSimple(map, prefix + "TrainCodeDownloadUrl", this.TrainCodeDownloadUrl);
            this.SetParamSimple(map, prefix + "TrainDataDownloadUrl", this.TrainDataDownloadUrl);
            this.SetParamArrayObj(map, prefix + "TrainParams.", this.TrainParams);
            this.SetParamSimple(map, prefix + "PresetTrainCodeStartCmd", this.PresetTrainCodeStartCmd);
            this.SetParamSimple(map, prefix + "IsPrivateModel", this.IsPrivateModel);
            this.SetParamArrayObj(map, prefix + "PresetTrainImageInfoList.", this.PresetTrainImageInfoList);
            this.SetParamArrayObj(map, prefix + "PresetInferenceImageInfoList.", this.PresetInferenceImageInfoList);
            this.SetParamArrayObj(map, prefix + "PresetTrainCodeInfoList.", this.PresetTrainCodeInfoList);
            this.SetParamArrayObj(map, prefix + "PresetModelInfoList.", this.PresetModelInfoList);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
            this.SetParamSimple(map, prefix + "PublicAlgoSeriesId", this.PublicAlgoSeriesId);
        }
    }
}

