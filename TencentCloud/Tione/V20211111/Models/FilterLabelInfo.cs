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

    public class FilterLabelInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据集id
        /// </summary>
        [JsonProperty("DatasetId")]
        public string DatasetId{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 分类标签结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationLabels")]
        public string[] ClassificationLabels{ get; set; }

        /// <summary>
        /// 检测标签结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectionLabels")]
        public DetectionLabelInfo[] DetectionLabels{ get; set; }

        /// <summary>
        /// 分割标签结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegmentationLabels")]
        public SegmentationInfo[] SegmentationLabels{ get; set; }

        /// <summary>
        /// RGB 图片路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RGBPath")]
        public string RGBPath{ get; set; }

        /// <summary>
        /// 标签模板类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelTemplateType")]
        public string LabelTemplateType{ get; set; }

        /// <summary>
        /// 下载url链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 缩略图下载链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadThumbnailUrl")]
        public string DownloadThumbnailUrl{ get; set; }

        /// <summary>
        /// 分割结果图片下载链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadRGBUrl")]
        public string DownloadRGBUrl{ get; set; }

        /// <summary>
        /// OCR场景
        /// IDENTITY：识别
        /// STRUCTURE：智能结构化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrScene")]
        public string OcrScene{ get; set; }

        /// <summary>
        /// OCR场景标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrLabels")]
        public OcrLabelInfo[] OcrLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasetId", this.DatasetId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamArraySimple(map, prefix + "ClassificationLabels.", this.ClassificationLabels);
            this.SetParamArrayObj(map, prefix + "DetectionLabels.", this.DetectionLabels);
            this.SetParamArrayObj(map, prefix + "SegmentationLabels.", this.SegmentationLabels);
            this.SetParamSimple(map, prefix + "RGBPath", this.RGBPath);
            this.SetParamSimple(map, prefix + "LabelTemplateType", this.LabelTemplateType);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "DownloadThumbnailUrl", this.DownloadThumbnailUrl);
            this.SetParamSimple(map, prefix + "DownloadRGBUrl", this.DownloadRGBUrl);
            this.SetParamSimple(map, prefix + "OcrScene", this.OcrScene);
            this.SetParamArrayObj(map, prefix + "OcrLabels.", this.OcrLabels);
        }
    }
}

