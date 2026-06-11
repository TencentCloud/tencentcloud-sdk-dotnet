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

    public class CreateDatasetRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据集名称，不超过60个字符，仅支持中英文、数字、下划线&quot;_&quot;、短横&quot;-&quot;，只能以中英文、数字开头</p>
        /// </summary>
        [JsonProperty("DatasetName")]
        public string DatasetName{ get; set; }

        /// <summary>
        /// <p>TI工作空间ID</p><p>仅用于“工作空间”白名单功能。如需使用，请联系TI管理员开通白名单。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>数据集类型</p><p>枚举值：</p><ul><li>TYPE_DATASET_IMAGE： 图片</li><li>TYPE_DATASET_LLM： 大模型</li><li>TYPE_DATASET_TABLE： 表格</li><li>TYPE_DATASET_OTHER： 其他</li></ul>
        /// </summary>
        [JsonProperty("DatasetType")]
        public string DatasetType{ get; set; }

        /// <summary>
        /// <p>数据源cos路径</p>
        /// </summary>
        [JsonProperty("StorageDataPath")]
        public CosPathInfo StorageDataPath{ get; set; }

        /// <summary>
        /// <p>数据集标签cos存储路径</p>
        /// </summary>
        [JsonProperty("StorageLabelPath")]
        public CosPathInfo StorageLabelPath{ get; set; }

        /// <summary>
        /// <p>数据集标签</p>
        /// </summary>
        [JsonProperty("DatasetTags")]
        public Tag[] DatasetTags{ get; set; }

        /// <summary>
        /// <p>数据集标注状态</p><p>枚举值：</p><ul><li>STATUS_NON_ANNOTATED： 未标注</li><li>STATUS_ANNOTATED： 已标注</li></ul>
        /// </summary>
        [JsonProperty("AnnotationStatus")]
        public string AnnotationStatus{ get; set; }

        /// <summary>
        /// <p>标注类型</p><p>枚举值：</p><ul><li>ANNOTATION_TYPE_CLASSIFICATION： 图片分类</li><li>ANNOTATION_TYPE_DETECTION： 目标检测</li><li>ANNOTATION_TYPE_SEGMENTATION： 图片分割</li><li>ANNOTATION_TYPE_TRACKING： 目标跟踪</li><li>ANNOTATION_TYPE_OCR： OCR</li></ul>
        /// </summary>
        [JsonProperty("AnnotationType")]
        public string AnnotationType{ get; set; }

        /// <summary>
        /// <p>标注格式</p><p>枚举值：</p><ul><li>ANNOTATION_FORMAT_TI： TI-ONE平台格式</li><li>ANNOTATION_FORMAT_PASCAL： Pascal Voc格式</li><li>ANNOTATION_FORMAT_COCO： COCO格式</li><li>ANNOTATION_FORMAT_FILE： 文件目录结构</li></ul>
        /// </summary>
        [JsonProperty("AnnotationFormat")]
        public string AnnotationFormat{ get; set; }

        /// <summary>
        /// <p>表头信息</p>
        /// </summary>
        [JsonProperty("SchemaInfos")]
        public SchemaInfo[] SchemaInfos{ get; set; }

        /// <summary>
        /// <p>数据是否存在表头</p>
        /// </summary>
        [JsonProperty("IsSchemaExisted")]
        public bool? IsSchemaExisted{ get; set; }

        /// <summary>
        /// <p>导入文件粒度</p><p>枚举值：</p><ul><li>TYPE_TEXT_LINE： 按行</li><li>TYPE_TEXT_FILE： 按文件</li></ul>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>数据集建模一级类别</p><p>枚举值：</p><ul><li>LLM： 大模型建模</li><li>CV： 传统CV建模</li><li>STRUCTURE： 大数据建模</li><li>OTHER： 其它</li></ul>
        /// </summary>
        [JsonProperty("DatasetScene")]
        public string DatasetScene{ get; set; }

        /// <summary>
        /// <p>数据集标签。</p>
        /// </summary>
        [JsonProperty("SceneTags")]
        public string[] SceneTags{ get; set; }

        /// <summary>
        /// <p>数据集CFS配置。仅支持LLM场景</p>
        /// </summary>
        [JsonProperty("CFSConfig")]
        public CFSConfig CFSConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasetName", this.DatasetName);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "DatasetType", this.DatasetType);
            this.SetParamObj(map, prefix + "StorageDataPath.", this.StorageDataPath);
            this.SetParamObj(map, prefix + "StorageLabelPath.", this.StorageLabelPath);
            this.SetParamArrayObj(map, prefix + "DatasetTags.", this.DatasetTags);
            this.SetParamSimple(map, prefix + "AnnotationStatus", this.AnnotationStatus);
            this.SetParamSimple(map, prefix + "AnnotationType", this.AnnotationType);
            this.SetParamSimple(map, prefix + "AnnotationFormat", this.AnnotationFormat);
            this.SetParamArrayObj(map, prefix + "SchemaInfos.", this.SchemaInfos);
            this.SetParamSimple(map, prefix + "IsSchemaExisted", this.IsSchemaExisted);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "DatasetScene", this.DatasetScene);
            this.SetParamArraySimple(map, prefix + "SceneTags.", this.SceneTags);
            this.SetParamObj(map, prefix + "CFSConfig.", this.CFSConfig);
        }
    }
}

