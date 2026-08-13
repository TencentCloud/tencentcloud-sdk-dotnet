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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffChunkItem : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// <p>schema名</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>数据表名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>分块号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChunkId")]
        public long? ChunkId{ get; set; }

        /// <summary>
        /// <p>数据标识符，比如主键信息等</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// <p>不一致类型，可能的取值为：data - 两边数据不一致；srcLack - 源缺失；dstLack - 目标缺失</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiffType")]
        public string DiffType{ get; set; }

        /// <summary>
        /// <p>表结构信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaInfo")]
        public string[] SchemaInfo{ get; set; }

        /// <summary>
        /// <p>源端数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcItem")]
        public string[] SrcItem{ get; set; }

        /// <summary>
        /// <p>目标端数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstItem")]
        public string[] DstItem{ get; set; }

        /// <summary>
        /// <p>完成时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ChunkId", this.ChunkId);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "DiffType", this.DiffType);
            this.SetParamArraySimple(map, prefix + "SchemaInfo.", this.SchemaInfo);
            this.SetParamArraySimple(map, prefix + "SrcItem.", this.SrcItem);
            this.SetParamArraySimple(map, prefix + "DstItem.", this.DstItem);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
        }
    }
}

