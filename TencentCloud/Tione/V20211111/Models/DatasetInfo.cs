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

    public class DatasetInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据集id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetId")]
        public string DatasetId{ get; set; }

        /// <summary>
        /// 数据集名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetName")]
        public string DatasetName{ get; set; }

        /// <summary>
        /// 数据集创建者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 数据集版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetVersion")]
        public string DatasetVersion{ get; set; }

        /// <summary>
        /// 数据集类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetType")]
        public string DatasetType{ get; set; }

        /// <summary>
        /// 数据集标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetTags")]
        public Tag[] DatasetTags{ get; set; }

        /// <summary>
        /// 数据集对应标注任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetAnnotationTaskName")]
        public string DatasetAnnotationTaskName{ get; set; }

        /// <summary>
        /// 数据集对应标注任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetAnnotationTaskId")]
        public string DatasetAnnotationTaskId{ get; set; }

        /// <summary>
        /// 处理进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Process")]
        public long? Process{ get; set; }

        /// <summary>
        /// 数据集状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetStatus")]
        public string DatasetStatus{ get; set; }

        /// <summary>
        /// 错误详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 数据集创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 数据集更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 外部任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalTaskType")]
        public string ExternalTaskType{ get; set; }

        /// <summary>
        /// 数据集存储大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetSize")]
        public string DatasetSize{ get; set; }

        /// <summary>
        /// 数据集数据数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileNum")]
        public ulong? FileNum{ get; set; }

        /// <summary>
        /// 数据集源cos 路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageDataPath")]
        public CosPathInfo StorageDataPath{ get; set; }

        /// <summary>
        /// 数据集输出cos路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageLabelPath")]
        public CosPathInfo StorageLabelPath{ get; set; }

        /// <summary>
        /// 数据集标注状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationStatus")]
        public string AnnotationStatus{ get; set; }

        /// <summary>
        /// 数据集类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationType")]
        public string AnnotationType{ get; set; }

        /// <summary>
        /// 数据集标注格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationFormat")]
        public string AnnotationFormat{ get; set; }

        /// <summary>
        /// 数据集范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetScope")]
        public string DatasetScope{ get; set; }

        /// <summary>
        /// 数据集OCR子场景
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrScene")]
        public string OcrScene{ get; set; }

        /// <summary>
        /// 数据集字典修改状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationKeyStatus")]
        public string AnnotationKeyStatus{ get; set; }

        /// <summary>
        /// 内容类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 数据集建模类别。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetScene")]
        public string DatasetScene{ get; set; }

        /// <summary>
        /// CFS配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSConfig")]
        public CFSConfig CFSConfig{ get; set; }

        /// <summary>
        /// 数据集标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneTags")]
        public string[] SceneTags{ get; set; }

        /// <summary>
        /// 已标注数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumAnnotated")]
        public ulong? NumAnnotated{ get; set; }

        /// <summary>
        /// 标注规范
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationSpecification")]
        public string AnnotationSpecification{ get; set; }

        /// <summary>
        /// 标注Schema是否配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnnotationSchemaConfigured")]
        public bool? AnnotationSchemaConfigured{ get; set; }

        /// <summary>
        /// 创建者名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorNickname")]
        public string CreatorNickname{ get; set; }

        /// <summary>
        /// cfs路径是否有修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCfsUpdated")]
        public bool? IsCfsUpdated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasetId", this.DatasetId);
            this.SetParamSimple(map, prefix + "DatasetName", this.DatasetName);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "DatasetVersion", this.DatasetVersion);
            this.SetParamSimple(map, prefix + "DatasetType", this.DatasetType);
            this.SetParamArrayObj(map, prefix + "DatasetTags.", this.DatasetTags);
            this.SetParamSimple(map, prefix + "DatasetAnnotationTaskName", this.DatasetAnnotationTaskName);
            this.SetParamSimple(map, prefix + "DatasetAnnotationTaskId", this.DatasetAnnotationTaskId);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamSimple(map, prefix + "DatasetStatus", this.DatasetStatus);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExternalTaskType", this.ExternalTaskType);
            this.SetParamSimple(map, prefix + "DatasetSize", this.DatasetSize);
            this.SetParamSimple(map, prefix + "FileNum", this.FileNum);
            this.SetParamObj(map, prefix + "StorageDataPath.", this.StorageDataPath);
            this.SetParamObj(map, prefix + "StorageLabelPath.", this.StorageLabelPath);
            this.SetParamSimple(map, prefix + "AnnotationStatus", this.AnnotationStatus);
            this.SetParamSimple(map, prefix + "AnnotationType", this.AnnotationType);
            this.SetParamSimple(map, prefix + "AnnotationFormat", this.AnnotationFormat);
            this.SetParamSimple(map, prefix + "DatasetScope", this.DatasetScope);
            this.SetParamSimple(map, prefix + "OcrScene", this.OcrScene);
            this.SetParamSimple(map, prefix + "AnnotationKeyStatus", this.AnnotationKeyStatus);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "DatasetScene", this.DatasetScene);
            this.SetParamObj(map, prefix + "CFSConfig.", this.CFSConfig);
            this.SetParamArraySimple(map, prefix + "SceneTags.", this.SceneTags);
            this.SetParamSimple(map, prefix + "NumAnnotated", this.NumAnnotated);
            this.SetParamSimple(map, prefix + "AnnotationSpecification", this.AnnotationSpecification);
            this.SetParamSimple(map, prefix + "AnnotationSchemaConfigured", this.AnnotationSchemaConfigured);
            this.SetParamSimple(map, prefix + "CreatorNickname", this.CreatorNickname);
            this.SetParamSimple(map, prefix + "IsCfsUpdated", this.IsCfsUpdated);
        }
    }
}

