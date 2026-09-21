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

    public class PostgresSpaceObjectItem : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库名（PostgreSQL 顶层 catalog）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableCatalog")]
        public string TableCatalog{ get; set; }

        /// <summary>
        /// <p>Schema 名（Level=TABLE 时返回）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// <p>表名（Level=TABLE 时返回）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>表本身大小（MB），对应 pg_relation_size。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationSize")]
        public float? RelationSize{ get; set; }

        /// <summary>
        /// <p>表数据大小（MB），含 TOAST 但不含索引，对应 pg_table_size。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableSize")]
        public float? TableSize{ get; set; }

        /// <summary>
        /// <p>索引大小（MB），对应 pg_indexes_size。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexSize")]
        public float? IndexSize{ get; set; }

        /// <summary>
        /// <p>总大小（MB），含数据、索引、TOAST，对应 pg_total_relation_size。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRelationSize")]
        public float? TotalRelationSize{ get; set; }

        /// <summary>
        /// <p>表膨胀率（PostgreSQL 特有指标）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableBloat")]
        public float? TableBloat{ get; set; }

        /// <summary>
        /// <p>表行数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableRows")]
        public long? TableRows{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableCatalog", this.TableCatalog);
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "RelationSize", this.RelationSize);
            this.SetParamSimple(map, prefix + "TableSize", this.TableSize);
            this.SetParamSimple(map, prefix + "IndexSize", this.IndexSize);
            this.SetParamSimple(map, prefix + "TotalRelationSize", this.TotalRelationSize);
            this.SetParamSimple(map, prefix + "TableBloat", this.TableBloat);
            this.SetParamSimple(map, prefix + "TableRows", this.TableRows);
        }
    }
}

