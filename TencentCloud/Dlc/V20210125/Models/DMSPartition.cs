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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DMSPartition : AbstractModel
    {
        
        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 数据目录名称
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 数据版本
        /// </summary>
        [JsonProperty("DataVersion")]
        public long? DataVersion{ get; set; }

        /// <summary>
        /// 分区名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 值列表
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 存储大小
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 记录数量
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 最后访问时间
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// 附件属性
        /// </summary>
        [JsonProperty("Params")]
        public KVPair[] Params{ get; set; }

        /// <summary>
        /// 存储对象
        /// </summary>
        [JsonProperty("Sds")]
        public DMSSds Sds{ get; set; }

        /// <summary>
        /// 数据源连接名
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "DataVersion", this.DataVersion);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamObj(map, prefix + "Sds.", this.Sds);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
        }
    }
}

