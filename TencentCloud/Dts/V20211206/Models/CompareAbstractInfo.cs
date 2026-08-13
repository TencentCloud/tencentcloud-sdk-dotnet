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

    public class CompareAbstractInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>校验配置参数</p>
        /// </summary>
        [JsonProperty("Options")]
        public CompareOptions Options{ get; set; }

        /// <summary>
        /// <p>一致性校验对比对象</p>
        /// </summary>
        [JsonProperty("Objects")]
        public CompareObject Objects{ get; set; }

        /// <summary>
        /// <p>对比结论: same,different</p>
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// <p>任务状态: success,failed</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>总的表数量</p>
        /// </summary>
        [JsonProperty("TotalTables")]
        public ulong? TotalTables{ get; set; }

        /// <summary>
        /// <p>已校验的表数量</p>
        /// </summary>
        [JsonProperty("CheckedTables")]
        public ulong? CheckedTables{ get; set; }

        /// <summary>
        /// <p>不一致的表数量</p>
        /// </summary>
        [JsonProperty("DifferentTables")]
        public ulong? DifferentTables{ get; set; }

        /// <summary>
        /// <p>跳过校验的表数量</p>
        /// </summary>
        [JsonProperty("SkippedTables")]
        public ulong? SkippedTables{ get; set; }

        /// <summary>
        /// <p>预估表总数</p>
        /// </summary>
        [JsonProperty("NearlyTableCount")]
        public ulong? NearlyTableCount{ get; set; }

        /// <summary>
        /// <p>不一致的数据行数量</p>
        /// </summary>
        [JsonProperty("DifferentRows")]
        public ulong? DifferentRows{ get; set; }

        /// <summary>
        /// <p>源库行数，当对比类型为<strong>行数对比</strong>时此项有意义</p>
        /// </summary>
        [JsonProperty("SrcSampleRows")]
        public ulong? SrcSampleRows{ get; set; }

        /// <summary>
        /// <p>目标库行数，当对比类型为<strong>行数对比</strong>时此项有意义</p>
        /// </summary>
        [JsonProperty("DstSampleRows")]
        public ulong? DstSampleRows{ get; set; }

        /// <summary>
        /// <p>开始时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// <p>结束时间。当 <code>DateTimeISOFormat=true</code> 时返回 RFC 3339 格式（如 <code>2026-04-23T20:21:35+08:00</code>），否则返回 <code>yyyy-mm-dd hh:mm:ss</code>（北京时间）</p>
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Options.", this.Options);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamSimple(map, prefix + "Conclusion", this.Conclusion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalTables", this.TotalTables);
            this.SetParamSimple(map, prefix + "CheckedTables", this.CheckedTables);
            this.SetParamSimple(map, prefix + "DifferentTables", this.DifferentTables);
            this.SetParamSimple(map, prefix + "SkippedTables", this.SkippedTables);
            this.SetParamSimple(map, prefix + "NearlyTableCount", this.NearlyTableCount);
            this.SetParamSimple(map, prefix + "DifferentRows", this.DifferentRows);
            this.SetParamSimple(map, prefix + "SrcSampleRows", this.SrcSampleRows);
            this.SetParamSimple(map, prefix + "DstSampleRows", this.DstSampleRows);
            this.SetParamSimple(map, prefix + "StartedAt", this.StartedAt);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
        }
    }
}

