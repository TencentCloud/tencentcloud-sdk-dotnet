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
        /// 库名
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// schema名
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 校验结果
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// 校验状态。仅全量阶段有意义
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 校验进度。仅全量阶段有意义
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 不一致行数
        /// </summary>
        [JsonProperty("RowCount")]
        public long? RowCount{ get; set; }

        /// <summary>
        /// 该表开始校验的时间
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// 该表校验结束的时间
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }

        /// <summary>
        /// 预计该表校验结束的时间
        /// </summary>
        [JsonProperty("ExpectedAt")]
        public string ExpectedAt{ get; set; }

        /// <summary>
        /// 源端行数，如果是行数校验此值有意义
        /// </summary>
        [JsonProperty("SrcItem")]
        public string SrcItem{ get; set; }

        /// <summary>
        /// 目标端行数，如果是行数校验此值有意义
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

