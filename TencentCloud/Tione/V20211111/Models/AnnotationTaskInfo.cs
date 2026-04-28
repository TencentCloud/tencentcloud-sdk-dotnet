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

    public class AnnotationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>标注任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>标注任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>数据集id</p>
        /// </summary>
        [JsonProperty("DatasetId")]
        public string DatasetId{ get; set; }

        /// <summary>
        /// <p>数据集名称</p>
        /// </summary>
        [JsonProperty("DatasetName")]
        public string DatasetName{ get; set; }

        /// <summary>
        /// <p>标注场景名称</p>
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// <p>标注任务的label信息数组</p>
        /// </summary>
        [JsonProperty("LabelValueList")]
        public LabelValue[] LabelValueList{ get; set; }

        /// <summary>
        /// <p>tag详情数组</p>
        /// </summary>
        [JsonProperty("CamTagList")]
        public CamTag[] CamTagList{ get; set; }

        /// <summary>
        /// <p>任务状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>创建任务失败原因说明</p>
        /// </summary>
        [JsonProperty("AbnormalMsg")]
        public string AbnormalMsg{ get; set; }

        /// <summary>
        /// <p>标注任务是否正在提交</p>
        /// </summary>
        [JsonProperty("IsSubmitting")]
        public bool? IsSubmitting{ get; set; }

        /// <summary>
        /// <p>任务详情描述</p>
        /// </summary>
        [JsonProperty("TaskNote")]
        public string TaskNote{ get; set; }

        /// <summary>
        /// <p>数据集版本</p>
        /// </summary>
        [JsonProperty("DataSetVersion")]
        public string DataSetVersion{ get; set; }

        /// <summary>
        /// <p>已经标注的图片数量</p>
        /// </summary>
        [JsonProperty("NumAnnotated")]
        public ulong? NumAnnotated{ get; set; }

        /// <summary>
        /// <p>标注的总图片数量</p>
        /// </summary>
        [JsonProperty("NumTotal")]
        public ulong? NumTotal{ get; set; }

        /// <summary>
        /// <p>创建任务的时间戳</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Ocr Tool Type</p>
        /// </summary>
        [JsonProperty("OcrToolType")]
        public ulong? OcrToolType{ get; set; }

        /// <summary>
        /// <p>Ocr Text Attribute Annotate Enable</p>
        /// </summary>
        [JsonProperty("OcrTextAttributeAnnotateEnable")]
        public bool? OcrTextAttributeAnnotateEnable{ get; set; }

        /// <summary>
        /// <p>导出格式</p>
        /// </summary>
        [JsonProperty("ExportFormat")]
        public string ExportFormat{ get; set; }

        /// <summary>
        /// <p>提交错误说明</p>
        /// </summary>
        [JsonProperty("SubmittingErrorMsg")]
        public string SubmittingErrorMsg{ get; set; }

        /// <summary>
        /// <p>ocr任务类型：1-识别。2-智能结构化</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrAnnotationContentType")]
        public ulong? OcrAnnotationContentType{ get; set; }

        /// <summary>
        /// <p>OCR任务：是否启用辅助标注</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableAuxiliaryAnnotation")]
        public bool? EnableAuxiliaryAnnotation{ get; set; }

        /// <summary>
        /// <p>数据集创建者UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasetCreator")]
        public string DatasetCreator{ get; set; }

        /// <summary>
        /// <p>任务创建者UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>数据集创建者名称</p>
        /// </summary>
        [JsonProperty("DatasetCreatorName")]
        public string DatasetCreatorName{ get; set; }

        /// <summary>
        /// <p>任务创建者名称</p>
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// <p>标注任务状态枚举</p><p>枚举值：</p><ul><li>CREATING： 创建中</li><li>CREATE_SUCCESS： 创建成功，可标注</li><li>CREATE_FAILED： 创建失败</li><li>SUBMITTING： 提交中</li><li>SUBMIT_SUCCESS： 提交成功，需重启才可标注</li><li>SUBMIT_FAILED： 提交失败</li><li>ABNORMAL： 数据版本异常，需删除重建（大模型场景）</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DatasetId", this.DatasetId);
            this.SetParamSimple(map, prefix + "DatasetName", this.DatasetName);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamArrayObj(map, prefix + "LabelValueList.", this.LabelValueList);
            this.SetParamArrayObj(map, prefix + "CamTagList.", this.CamTagList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AbnormalMsg", this.AbnormalMsg);
            this.SetParamSimple(map, prefix + "IsSubmitting", this.IsSubmitting);
            this.SetParamSimple(map, prefix + "TaskNote", this.TaskNote);
            this.SetParamSimple(map, prefix + "DataSetVersion", this.DataSetVersion);
            this.SetParamSimple(map, prefix + "NumAnnotated", this.NumAnnotated);
            this.SetParamSimple(map, prefix + "NumTotal", this.NumTotal);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "OcrToolType", this.OcrToolType);
            this.SetParamSimple(map, prefix + "OcrTextAttributeAnnotateEnable", this.OcrTextAttributeAnnotateEnable);
            this.SetParamSimple(map, prefix + "ExportFormat", this.ExportFormat);
            this.SetParamSimple(map, prefix + "SubmittingErrorMsg", this.SubmittingErrorMsg);
            this.SetParamSimple(map, prefix + "OcrAnnotationContentType", this.OcrAnnotationContentType);
            this.SetParamSimple(map, prefix + "EnableAuxiliaryAnnotation", this.EnableAuxiliaryAnnotation);
            this.SetParamSimple(map, prefix + "DatasetCreator", this.DatasetCreator);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "DatasetCreatorName", this.DatasetCreatorName);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
        }
    }
}

