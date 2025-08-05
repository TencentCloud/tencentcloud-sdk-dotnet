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

    public class DescribeTopL7AnalysisDataRequest : AbstractModel
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
        /// 查询的指标，取值有：
        /// <li> l7Flow_outFlux_country：按国家/地区维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_province：按中国大陆境内省份维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_statusCode：按状态码维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_domain：按域名维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_url：按 URL Path 维度统计 L7 EdgeOne 响应流量指标; </li>
        /// <li> l7Flow_outFlux_resourceType：按资源类型维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_sip：按客户端 IP 维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_referers：按 Referer 维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_ua_device：按设备类型维度统计 L7 EdgeOne 响应流量指标; </li>
        /// <li> l7Flow_outFlux_ua_browser：按浏览器类型维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_ua_os：按操作系统类型维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_outFlux_ua：按 User-Agent 维度统计 L7 EdgeOne 响应流量指标；</li>
        /// <li> l7Flow_request_country：按国家/地区维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_province：按中国大陆境内省份维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_statusCode：按状态码维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_domain：按域名维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_url：按 URL Path 维度统计 L7 访问请求数指标; </li>
        /// <li> l7Flow_request_resourceType：按资源类型维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_sip：按客户端 IP 维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_referer：按 Referer 维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_ua_device：按设备类型维度统计 L7 访问请求数指标; </li>
        /// <li> l7Flow_request_ua_browser：按浏览器类型维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_ua_os：按操作系统类型维度统计 L7 访问请求数指标；</li>
        /// <li> l7Flow_request_ua：按 User-Agent 维度统计 L7 访问请求数指标。</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 站点 ID 集合，此参数必填。最多传入 100 个站点 ID。若需查询腾讯云主账号下所有站点数据，请用 `*` 代替，查询账号级别数据需具备本接口全部站点资源权限。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 查询前多少个 top 数据，最大值为1000。不填默认为10，表示查询 top10 的数据。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 筛选数据时使用的过滤条件，取值参考 [指标分析筛选条件说明](https://cloud.tencent.com/document/product/1552/98219#1aaf1150-55a4-4b4d-b103-3a8317ac7945) 中针对 L7 访问流量、带宽、请求数的可用筛选项。
        /// 如需限定站点或内容标识符，请在 `ZoneIds.N` 参数中另行传入对应的值。
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// 查询时间粒度，该参数无效，待废弃。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

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
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

