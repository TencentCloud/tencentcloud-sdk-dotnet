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

    public class CompareTableResult : AbstractModel
    {
        
        /// <summary>
        /// <p>库名</p>
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// <p>schema名</p>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>表名</p>
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// <p>校验结果</p>
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// <p>校验状态。仅全量阶段有意义</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>校验进度。仅全量阶段有意义</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// <p>不一致行数</p>
        /// </summary>
        [JsonProperty("RowCount")]
        public long? RowCount{ get; set; }

        /// <summary>
        /// <p>该表开始校验的时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// <p>该表校验结束的时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }

        /// <summary>
        /// <p>预计该表校验结束的时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("ExpectedAt")]
        public string ExpectedAt{ get; set; }

        /// <summary>
        /// <p>源端行数，如果是行数校验此值有意义</p>
        /// </summary>
        [JsonProperty("SrcItem")]
        public string SrcItem{ get; set; }

        /// <summary>
        /// <p>目标端行数，如果是行数校验此值有意义</p>
        /// </summary>
        [JsonProperty("DstItem")]
        public string DstItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Conclusion", this.Conclusion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "StartedAt", this.StartedAt);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
            this.SetParamSimple(map, prefix + "ExpectedAt", this.ExpectedAt);
            this.SetParamSimple(map, prefix + "SrcItem", this.SrcItem);
            this.SetParamSimple(map, prefix + "DstItem", this.DstItem);
        }
    }
}

