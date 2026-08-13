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

    public class DifferenceItem : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库名</p>
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// <p>schema</p>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>表名</p>
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// <p>分块号</p>
        /// </summary>
        [JsonProperty("Chunk")]
        public long? Chunk{ get; set; }

        /// <summary>
        /// <p>源库数值</p>
        /// </summary>
        [JsonProperty("SrcItem")]
        public string SrcItem{ get; set; }

        /// <summary>
        /// <p>目标库数值</p>
        /// </summary>
        [JsonProperty("DstItem")]
        public string DstItem{ get; set; }

        /// <summary>
        /// <p>索引名称</p>
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>索引下边界</p>
        /// </summary>
        [JsonProperty("LowerBoundary")]
        public string LowerBoundary{ get; set; }

        /// <summary>
        /// <p>索引上边界</p>
        /// </summary>
        [JsonProperty("UpperBoundary")]
        public string UpperBoundary{ get; set; }

        /// <summary>
        /// <p>对比消耗时间,单位为 ms</p>
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// <p>完成时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Chunk", this.Chunk);
            this.SetParamSimple(map, prefix + "SrcItem", this.SrcItem);
            this.SetParamSimple(map, prefix + "DstItem", this.DstItem);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "LowerBoundary", this.LowerBoundary);
            this.SetParamSimple(map, prefix + "UpperBoundary", this.UpperBoundary);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
        }
    }
}

