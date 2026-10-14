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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableStatistics : AbstractModel
    {
        
        /// <summary>
        /// <p>表名。</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>Schema 名。</p>
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// <p>库名（catalog）。</p>
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>存储引擎。</p>
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// <p>数据空间。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("DataLength")]
        public float? DataLength{ get; set; }

        /// <summary>
        /// <p>索引空间。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("IndexLength")]
        public float? IndexLength{ get; set; }

        /// <summary>
        /// <p>总分配空间。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("TotalLength")]
        public float? TotalLength{ get; set; }

        /// <summary>
        /// <p>已用空间。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("UsedLength")]
        public float? UsedLength{ get; set; }

        /// <summary>
        /// <p>碎片空间。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("DataFree")]
        public float? DataFree{ get; set; }

        /// <summary>
        /// <p>行数。</p>
        /// </summary>
        [JsonProperty("TableRows")]
        public long? TableRows{ get; set; }

        /// <summary>
        /// <p>碎片率（%）。</p>
        /// </summary>
        [JsonProperty("FragRatio")]
        public float? FragRatio{ get; set; }

        /// <summary>
        /// <p>物理文件大小。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("PhysicalFileSize")]
        public float? PhysicalFileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "DataLength", this.DataLength);
            this.SetParamSimple(map, prefix + "IndexLength", this.IndexLength);
            this.SetParamSimple(map, prefix + "TotalLength", this.TotalLength);
            this.SetParamSimple(map, prefix + "UsedLength", this.UsedLength);
            this.SetParamSimple(map, prefix + "DataFree", this.DataFree);
            this.SetParamSimple(map, prefix + "TableRows", this.TableRows);
            this.SetParamSimple(map, prefix + "FragRatio", this.FragRatio);
            this.SetParamSimple(map, prefix + "PhysicalFileSize", this.PhysicalFileSize);
        }
    }
}

