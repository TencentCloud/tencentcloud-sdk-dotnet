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

    public class CreateDatasetRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据集名称，不超过60个字符，仅支持中英文、数字、下划线"_"、短横"-"，只能以中英文、数字开头
        /// </summary>
        [JsonProperty("DatasetName")]
        public string DatasetName{ get; set; }

        /// <summary>
        /// 数据集类型:
        /// TYPE_DATASET_TEXT，文本
        /// TYPE_DATASET_IMAGE，图片
        /// TYPE_DATASET_TABLE，表格
        /// TYPE_DATASET_OTHER，其他
        /// </summary>
        [JsonProperty("DatasetType")]
        public string DatasetType{ get; set; }

        /// <summary>
        /// 数据源cos路径
        /// </summary>
        [JsonProperty("StorageDataPath")]
        public CosPathInfo StorageDataPath{ get; set; }

        /// <summary>
        /// 数据集标签cos存储路径
        /// </summary>
        [JsonProperty("StorageLabelPath")]
        public CosPathInfo StorageLabelPath{ get; set; }

        /// <summary>
        /// 数据集标签
        /// </summary>
        [JsonProperty("DatasetTags")]
        public Tag[] DatasetTags{ get; set; }

        /// <summary>
        /// 数据集标注状态:
        /// STATUS_NON_ANNOTATED，未标注
        /// STATUS_ANNOTATED，已标注
        /// </summary>
        [JsonProperty("AnnotationStatus")]
        public string AnnotationStatus{ get; set; }

        /// <summary>
        /// 标注类型:
        /// ANNOTATION_TYPE_CLASSIFICATION，图片分类
        /// ANNOTATION_TYPE_DETECTION，目标检测
        /// ANNOTATION_TYPE_SEGMENTATION，图片分割
        /// ANNOTATION_TYPE_TRACKING，目标跟踪
        /// ANNOTATION_TYPE_OCR，OCR
        /// ANNOTATION_TYPE_TEXT_CLASSIFICATION，文本分类
        /// </summary>
        [JsonProperty("AnnotationType")]
        public string AnnotationType{ get; set; }

        /// <summary>
        /// 标注格式:
        /// ANNOTATION_FORMAT_TI，TI平台格式
        /// ANNOTATION_FORMAT_PASCAL，Pascal Voc
        /// ANNOTATION_FORMAT_COCO，COCO
        /// ANNOTATION_FORMAT_FILE，文件目录结构
        /// ANNOTATION_FORMAT_TEXT_TI，文本类型TI平台格式
        /// ANNOTATION_FORMAT_TXT，文本类型TXT格式
        /// ANNOTATION_FORMAT_CSV，文本类型CSV格式
        /// ANNOTATION_FORMAT_JSON，文本类型JSON格式
        /// </summary>
        [JsonProperty("AnnotationFormat")]
        public string AnnotationFormat{ get; set; }

        /// <summary>
        /// 表头信息
        /// </summary>
        [JsonProperty("SchemaInfos")]
        public SchemaInfo[] SchemaInfos{ get; set; }

        /// <summary>
        /// 数据是否存在表头
        /// </summary>
        [JsonProperty("IsSchemaExisted")]
        public bool? IsSchemaExisted{ get; set; }

        /// <summary>
        /// 导入文件粒度
        /// TYPE_TEXT_LINE，按行
        /// TYPE_TEXT_FILE，按文件
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 数据集建模一级类别。LLM,CV,STRUCTURE,OTHER
        /// </summary>
        [JsonProperty("DatasetScene")]
        public string DatasetScene{ get; set; }

        /// <summary>
        /// 数据集标签。
        /// </summary>
        [JsonProperty("SceneTags")]
        public string[] SceneTags{ get; set; }

        /// <summary>
        /// 数据集CFS配置。仅支持LLM场景
        /// </summary>
        [JsonProperty("CFSConfig")]
        public CFSConfig CFSConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasetName", this.DatasetName);
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

