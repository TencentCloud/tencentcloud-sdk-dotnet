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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProbeMetricDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分析任务类型，支持以下几种类型：<br>AnalyzeTaskType_Network：网络质量<br>AnalyzeTaskType_Browse：页面性能<br>AnalyzeTaskType_Transport：端口性能<br>AnalyzeTaskType_UploadDownload：文件传输<br>AnalyzeTaskType_MediaStream：音视频体验</p>
        /// </summary>
        [JsonProperty("AnalyzeTaskType")]
        public string AnalyzeTaskType{ get; set; }

        /// <summary>
        /// <p>指标类型（counter、gauge以及histogram），指标查询默认传gauge</p>
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// <p>指标详细字段，可以传递传具体的指标也可以对指标进行聚合查询例如：&quot;avg(ping_time)&quot;代表整体时延(ms)；不同的任务类型支持不同的field查询，以及聚合规则，详情可见https://cloud.tencent.com/document/product/248/87584。</p>
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// <p>过滤条件可以传单个过滤条件也可以拼接多个参数</p>
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// <p>聚合时间, 1m、1d、30d 等等</p>
        /// </summary>
        [JsonProperty("GroupBy")]
        public string GroupBy{ get; set; }

        /// <summary>
        /// <p>多条件过滤，支持多个过滤条件组合查询<br>例如：[&quot;&quot;host&quot; = &#39;www.test.com&#39;&quot;, &quot;time &gt;= now()-1h&quot;]</p>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalyzeTaskType", this.AnalyzeTaskType);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "GroupBy", this.GroupBy);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
        }
    }
}

