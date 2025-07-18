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

    public class CreateDMSTableRequest : AbstractModel
    {
        
        /// <summary>
        /// 基础对象
        /// </summary>
        [JsonProperty("Asset")]
        public Asset Asset{ get; set; }

        /// <summary>
        /// 表类型：EXTERNAL_TABLE, VIRTUAL_VIEW, MATERIALIZED_VIEW
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

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
        /// 生命周期
        /// </summary>
        [JsonProperty("LifeTime")]
        public long? LifeTime{ get; set; }

        /// <summary>
        /// 数据更新时间
        /// </summary>
        [JsonProperty("DataUpdateTime")]
        public string DataUpdateTime{ get; set; }

        /// <summary>
        /// 结构更新时间
        /// </summary>
        [JsonProperty("StructUpdateTime")]
        public string StructUpdateTime{ get; set; }

        /// <summary>
        /// 最后访问时间
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// 存储对象
        /// </summary>
        [JsonProperty("Sds")]
        public DMSSds Sds{ get; set; }

        /// <summary>
        /// 列
        /// </summary>
        [JsonProperty("Columns")]
        public DMSColumn[] Columns{ get; set; }

        /// <summary>
        /// 分区键值
        /// </summary>
        [JsonProperty("PartitionKeys")]
        public DMSColumn[] PartitionKeys{ get; set; }

        /// <summary>
        /// 视图文本
        /// </summary>
        [JsonProperty("ViewOriginalText")]
        public string ViewOriginalText{ get; set; }

        /// <summary>
        /// 视图文本
        /// </summary>
        [JsonProperty("ViewExpandedText")]
        public string ViewExpandedText{ get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("Partitions")]
        public DMSPartition[] Partitions{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

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
            this.SetParamObj(map, prefix + "Asset.", this.Asset);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "LifeTime", this.LifeTime);
            this.SetParamSimple(map, prefix + "DataUpdateTime", this.DataUpdateTime);
            this.SetParamSimple(map, prefix + "StructUpdateTime", this.StructUpdateTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamObj(map, prefix + "Sds.", this.Sds);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "PartitionKeys.", this.PartitionKeys);
            this.SetParamSimple(map, prefix + "ViewOriginalText", this.ViewOriginalText);
            this.SetParamSimple(map, prefix + "ViewExpandedText", this.ViewExpandedText);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
        }
    }
}

