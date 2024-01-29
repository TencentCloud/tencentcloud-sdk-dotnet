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

    public class PreviewDataTableCsvRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Cos 存储桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 文件在cos上的存储路径，该路径有固定前缀，/datastudio/data_manage/import/项目ID，example: /datastudio/data_manage/import/1460947878944567296/demo_2.csv
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 首行是否为字段名，默认为 false，如果选择 true，会将首行解析成列名，且在数据中会跳过第一行
        /// </summary>
        [JsonProperty("HeaderLine")]
        public bool? HeaderLine{ get; set; }

        /// <summary>
        /// 字段分隔符，取值为 0,1,2,3,4,5，各值含义为0: \u0001(hive默认)，1: 竖线 （ | ） ，2: 空格，3: 分号，4: 英文逗号，5: 制表符 \t，如果没填或填错，默认为英文逗号
        /// </summary>
        [JsonProperty("ColumnDelimiter")]
        public string ColumnDelimiter{ get; set; }

        /// <summary>
        /// 转义符，char 类型，只取当前参数的第一个字符，如果不传，默认为 \
        /// </summary>
        [JsonProperty("Escape")]
        public string Escape{ get; set; }

        /// <summary>
        /// 引号符，取值为 0、1，各个值的含义为 0: 英文单引号，1: 英文双引号，如果没填或填错，默认为英文双引号
        /// </summary>
        [JsonProperty("Quote")]
        public string Quote{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "HeaderLine", this.HeaderLine);
            this.SetParamSimple(map, prefix + "ColumnDelimiter", this.ColumnDelimiter);
            this.SetParamSimple(map, prefix + "Escape", this.Escape);
            this.SetParamSimple(map, prefix + "Quote", this.Quote);
        }
    }
}

