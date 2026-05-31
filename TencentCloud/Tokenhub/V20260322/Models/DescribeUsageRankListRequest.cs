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

    public class DescribeUsageRankListRequest : AbstractModel
    {
        
        /// <summary>
        /// 统计维度。取值：apikey（按 APIKey 统计）、endpoint（按接入点统计）、model（按模型统计）。
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 起始时间（闭区间），RFC3339 格式。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间（开区间），RFC3339 格式。与 StartTime 的跨度最大 90 天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指标族切换字段。本期支持 tokens（累计 Token 用量，statistics=sum）；传其他值将返回 InvalidParameter。空字符串或不传时默认 tokens。接口预留 MetricType 字段以支持后续指标族扩展。
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// 维度过滤值。空字符串表示查询全部对象，非空时仅查询指定单个对象（如指定 APIKey ID）。最大 256 字符。
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 统计粒度（秒）。取值：60、300、3600、86400。必须不小于跨度对应下限：跨度 ≤ 1 天 → 60；1 ~ 5 天 → 300；5 ~ 10 天 → 3600；> 10 天 → 86400。仅 ShowAll=false 时使用。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 翻页起点，从 0 起，默认 0。ShowAll=true 时忽略。页大小固定为 10。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 是否返回全量结果。
        /// - false（默认）：按 Offset 分页返回 TopList（每页 10 条），每个对象包含
        ///   Series 时序点用于绘制曲线。
        /// - true：忽略 Offset，返回全量对象列表，不返回 Series（CSV 导出场景）。
        /// </summary>
        [JsonProperty("ShowAll")]
        public bool? ShowAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ShowAll", this.ShowAll);
        }
    }
}

