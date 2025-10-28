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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTimingL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。查询时间范围（`EndTime` - `StartTime`）需小于等于 31 天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指标列表，取值有:
        /// <li>l7Flow_outFlux: L7 EdgeOne 响应流量，单位：Byte；</li>
        /// <li>l7Flow_inFlux: L7 客户端请求流量，单位：Byte；</li>
        /// <li>l7Flow_flux: L7 访问总流量（EdgeOne 响应+客户端请求），单位：Byte；</li>
        /// <li>l7Flow_outBandwidth: L7 EdgeOne 响应带宽，单位：bps；</li>
        /// <li>l7Flow_inBandwidth：L7 客户端请求带宽，单位：bps；</li>
        /// <li>l7Flow_bandwidth：L7 访问总带宽（EdgeOne 响应+客户端请求），单位：bps；</li>
        /// <li>l7Flow_request: L7 访问请求数，单位：次；</li>
        /// <li> l7Flow_avgResponseTime: L7 访问平均响应耗时，单位：ms；</li>
        /// <li> l7Flow_avgFirstByteResponseTime: L7 访问平均首字节响应耗时，单位：ms。</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 站点 ID 集合，此参数将于2024年05月30日后由可选改为必填，详见公告：[【腾讯云 EdgeOne】云 API 变更通知](https://cloud.tencent.com/document/product/1552/104902)。最多传入 100 个站点 ID。若需查询腾讯云主账号下所有站点数据，请用 `*` 代替，查询账号级别数据需具备本接口全部站点资源权限。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 查询时间粒度，取值有：
        /// <li>min: 1分钟；</li>
        /// <li>5min: 5分钟；</li>
        /// <li>hour: 1小时；</li>
        /// <li>day: 1天。</li>不填将根据开始时间跟结束时间的间距自动推算粒度，具体为：2 小时范围内以 min 粒度查询，2 天范围内以 5min 粒度查询，7 天范围内以 hour 粒度查询，超过 7 天以 day 粒度查询。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 筛选数据时使用的过滤条件，取值参考 [指标分析筛选条件说明](https://cloud.tencent.com/document/product/1552/98219#1aaf1150-55a4-4b4d-b103-3a8317ac7945) 中针对 L7 访问流量、带宽、请求数的可用筛选项。
        /// 如需限定站点或内容标识符，请在 `ZoneIds.N` 参数中另行传入对应的值。
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// 数据归属地区。该参数已废弃。请在 `Filters.country` 中按客户端地域过滤数据。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

