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

    public class MongoCollectionDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>集合命名空间，格式为 db.collection。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollStats")]
        public string CollStats{ get; set; }

        /// <summary>
        /// <p>集合逻辑大小（字节，未压缩）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectionSize")]
        public long? CollectionSize{ get; set; }

        /// <summary>
        /// <p>集合已分配但未使用的空间（字节）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataFree")]
        public long? DataFree{ get; set; }

        /// <summary>
        /// <p>空间利用率（百分比字符串）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpaceRatio")]
        public string SpaceRatio{ get; set; }

        /// <summary>
        /// <p>碎片率（百分比字符串）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FragRatio")]
        public string FragRatio{ get; set; }

        /// <summary>
        /// <p>集合数据大小（字节）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>所有索引占用大小（字节）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalIndexSize")]
        public long? TotalIndexSize{ get; set; }

        /// <summary>
        /// <p>平均文档大小（字节）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgObjSize")]
        public long? AvgObjSize{ get; set; }

        /// <summary>
        /// <p>集合实际占用存储大小（字节，压缩后）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// <p>文档数量。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>压缩率（百分比字符串）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompressionRatio")]
        public string CompressionRatio{ get; set; }

        /// <summary>
        /// <p>可复用文件空间（字节）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileReuseBytes")]
        public long? FileReuseBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CollStats", this.CollStats);
            this.SetParamSimple(map, prefix + "CollectionSize", this.CollectionSize);
            this.SetParamSimple(map, prefix + "DataFree", this.DataFree);
            this.SetParamSimple(map, prefix + "SpaceRatio", this.SpaceRatio);
            this.SetParamSimple(map, prefix + "FragRatio", this.FragRatio);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "TotalIndexSize", this.TotalIndexSize);
            this.SetParamSimple(map, prefix + "AvgObjSize", this.AvgObjSize);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "CompressionRatio", this.CompressionRatio);
            this.SetParamSimple(map, prefix + "FileReuseBytes", this.FileReuseBytes);
        }
    }
}

