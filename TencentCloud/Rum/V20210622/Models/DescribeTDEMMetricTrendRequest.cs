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

    public class DescribeTDEMMetricTrendRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID（必填）</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>开始时间 Unix 毫秒（必填）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间 Unix 毫秒（必填）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>粒度：5m（默认）/ 1h / 1d；跨度大时服务端可加粗</p>
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }

        /// <summary>
        /// <p>顶层事件类型；单查必填，批量用 Queries 时可不填</p>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// <p>子类型；未知返回 0</p>
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// <p>筛选条件 JSON 字符串：[{Key,Op,Values}]，走分析立方白名单</p>
        /// </summary>
        [JsonProperty("Filters")]
        public string Filters{ get; set; }

        /// <summary>
        /// <p>指标名列表，如 count / rate；单查必填</p>
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// <p>分位/均值必填，如 lcp / duration</p>
        /// </summary>
        [JsonProperty("MeasurementKey")]
        public string MeasurementKey{ get; set; }

        /// <summary>
        /// <p>批量查询，上限 32</p>
        /// </summary>
        [JsonProperty("Queries")]
        public MetricQueryItem[] Queries{ get; set; }

        /// <summary>
        /// <p>对比窗开始 Unix 毫秒（仅 Trend 批量，须与 CompareEndTime 成对）</p>
        /// </summary>
        [JsonProperty("CompareStartTime")]
        public long? CompareStartTime{ get; set; }

        /// <summary>
        /// <p>对比窗结束 Unix 毫秒（仅 Trend 批量）</p>
        /// </summary>
        [JsonProperty("CompareEndTime")]
        public long? CompareEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "Filters", this.Filters);
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "MeasurementKey", this.MeasurementKey);
            this.SetParamArrayObj(map, prefix + "Queries.", this.Queries);
            this.SetParamSimple(map, prefix + "CompareStartTime", this.CompareStartTime);
            this.SetParamSimple(map, prefix + "CompareEndTime", this.CompareEndTime);
        }
    }
}

