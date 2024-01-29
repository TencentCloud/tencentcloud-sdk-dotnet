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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportTableDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }

        /// <summary>
        /// 数据表基本信息
        /// </summary>
        [JsonProperty("TableRequest")]
        public TableHybrisReq TableRequest{ get; set; }

        /// <summary>
        /// 列分隔符
        /// 0， \u0001
        /// 1, |
        /// 2, 空格
        /// 3，分号
        /// 4，逗号 
        /// </summary>
        [JsonProperty("ColumnDelimiter")]
        public string ColumnDelimiter{ get; set; }

        /// <summary>
        /// 1 是， 0 否
        /// </summary>
        [JsonProperty("HeaderLine")]
        public long? HeaderLine{ get; set; }

        /// <summary>
        /// CSV序列化字段域符,列引号， 
        /// 0， 单引号
        /// 1，双引号
        /// </summary>
        [JsonProperty("Quote")]
        public string Quote{ get; set; }

        /// <summary>
        /// 源数据存储路径(如cos，需带上桶名)
        /// </summary>
        [JsonProperty("DatasourcePath")]
        public string DatasourcePath{ get; set; }

        /// <summary>
        /// 数据源存储类型（目前仅支持COS，CSP）
        /// </summary>
        [JsonProperty("StorageDataSourceType")]
        public string StorageDataSourceType{ get; set; }

        /// <summary>
        /// 文件格式（目前仅支持CSV,TSV）
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// 导入表类型（目前仅支持HIVE）
        /// </summary>
        [JsonProperty("ImportTableType")]
        public string ImportTableType{ get; set; }

        /// <summary>
        /// 数据源类型（目前仅支持HIVE）
        /// </summary>
        [JsonProperty("MsType")]
        public string MsType{ get; set; }

        /// <summary>
        /// 表描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// nameCn中文名
        /// </summary>
        [JsonProperty("NameCn")]
        public string NameCn{ get; set; }

        /// <summary>
        /// 表权限类型：0: owner和项目所有成员都有权限 1: 仅owner和项目管理员有权限
        /// </summary>
        [JsonProperty("Privilege")]
        public long? Privilege{ get; set; }

        /// <summary>
        /// CSV序列化转义符
        /// </summary>
        [JsonProperty("Escape")]
        public string Escape{ get; set; }

        /// <summary>
        /// 空值格式
        /// </summary>
        [JsonProperty("NullFormat")]
        public string NullFormat{ get; set; }

        /// <summary>
        /// 文件编码方式 UTF-8/GBK
        /// </summary>
        [JsonProperty("FileEncode")]
        public string FileEncode{ get; set; }

        /// <summary>
        /// 桶名， cos存储是必传
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamObj(map, prefix + "TableRequest.", this.TableRequest);
            this.SetParamSimple(map, prefix + "ColumnDelimiter", this.ColumnDelimiter);
            this.SetParamSimple(map, prefix + "HeaderLine", this.HeaderLine);
            this.SetParamSimple(map, prefix + "Quote", this.Quote);
            this.SetParamSimple(map, prefix + "DatasourcePath", this.DatasourcePath);
            this.SetParamSimple(map, prefix + "StorageDataSourceType", this.StorageDataSourceType);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "ImportTableType", this.ImportTableType);
            this.SetParamSimple(map, prefix + "MsType", this.MsType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "NameCn", this.NameCn);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamSimple(map, prefix + "Escape", this.Escape);
            this.SetParamSimple(map, prefix + "NullFormat", this.NullFormat);
            this.SetParamSimple(map, prefix + "FileEncode", this.FileEncode);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
        }
    }
}

