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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePerformanceMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>平台</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>过滤条件</p>
        /// </summary>
        [JsonProperty("Filters")]
        public string Filters{ get; set; }

        /// <summary>
        /// <p>分位值</p>
        /// </summary>
        [JsonProperty("Quantile")]
        public float? Quantile{ get; set; }

        /// <summary>
        /// <p>旅程筛选条件 JSON 字符串，格式与 Filters 相同：[{Key,Op,Values}]。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("JourneyFilters")]
        public string JourneyFilters{ get; set; }

        /// <summary>
        /// <p>是否只看包含挣扎的会话。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("HasStruggle")]
        public bool? HasStruggle{ get; set; }

        /// <summary>
        /// <p>旅程起点页面。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("StartPage")]
        public string StartPage{ get; set; }

        /// <summary>
        /// <p>旅程终点页面。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("EndPage")]
        public string EndPage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Filters", this.Filters);
            this.SetParamSimple(map, prefix + "Quantile", this.Quantile);
            this.SetParamSimple(map, prefix + "JourneyFilters", this.JourneyFilters);
            this.SetParamSimple(map, prefix + "HasStruggle", this.HasStruggle);
            this.SetParamSimple(map, prefix + "StartPage", this.StartPage);
            this.SetParamSimple(map, prefix + "EndPage", this.EndPage);
        }
    }
}

