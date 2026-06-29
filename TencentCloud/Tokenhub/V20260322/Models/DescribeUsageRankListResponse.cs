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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsageRankListResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>回填请求的统计维度。</p>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// <p>回填请求的指标族：tokens / search 。</p>
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// <p>本次响应中 Stats / Series / PageStats / TotalStats 实际包含的 metric key 列表，按MetricType 区分：tokens=[Total,Input,Output,Cache]、search=[SearchRequestCount,SearchCount]</p>
        /// </summary>
        [JsonProperty("MetricKeys")]
        public string[] MetricKeys{ get; set; }

        /// <summary>
        /// <p>视图（数据来源）</p>
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// <p>回填请求的统计粒度（秒）。ShowAll=true 时为 0。</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>回填请求的起始时间。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>回填请求的结束时间。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>全量对象数。</p>
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// <p>回填请求的翻页起点。ShowAll=true 时为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>页大小，恒为 10。ShowAll=true 时为 Total。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Series 数组对应的时间戳序列（Unix 秒）。ShowAll=true 时为空数组。</p>
        /// </summary>
        [JsonProperty("Timestamps")]
        public long?[] Timestamps{ get; set; }

        /// <summary>
        /// <p>对象排行列表，按<code>MetricKeys[0]</code>降序排序。ShowAll=false 时为当前页 10 个对象（含 Series）；ShowAll=true 时为全量对象（不含 Series，用于 CSV 导出）。</p>
        /// </summary>
        [JsonProperty("TopList")]
        public UsageRankItem[] TopList{ get; set; }

        /// <summary>
        /// <p>分页统计结果</p>
        /// </summary>
        [JsonProperty("PageStats")]
        public UsageStats PageStats{ get; set; }

        /// <summary>
        /// <p>总统计结果</p>
        /// </summary>
        [JsonProperty("TotalStats")]
        public UsageStats TotalStats{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamArraySimple(map, prefix + "MetricKeys.", this.MetricKeys);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Timestamps.", this.Timestamps);
            this.SetParamArrayObj(map, prefix + "TopList.", this.TopList);
            this.SetParamObj(map, prefix + "PageStats.", this.PageStats);
            this.SetParamObj(map, prefix + "TotalStats.", this.TotalStats);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

