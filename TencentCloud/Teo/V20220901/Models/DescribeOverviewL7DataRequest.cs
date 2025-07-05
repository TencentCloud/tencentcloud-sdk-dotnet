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

    public class DescribeOverviewL7DataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询的指标，取值有：
        /// <li>l7Flow_outFlux: Edegone响应流量；</li>
        /// <li>l7Flow_inFlux: Edgeone请求流量；</li>
        /// <li>l7Flow_outBandwidth: Edegone响应带宽；</li>
        /// <li>l7Flow_inBandwidth: Edegone请求带宽；</li>
        /// <li>l7Flow_hit_outFlux: 缓存命中流量；</li>
        /// <li>l7Flow_request: 访问请求数；</li>
        /// <li>l7Flow_flux: 访问请求上行+下行流量；</li>
        /// <li>l7Flow_bandwidth：访问请求上行+下行带宽。</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 站点 ID 集合，此参数必填。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 查询的域名集合，此参数已经废弃。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 查询的协议类型，取值有：
        /// <li>http: http协议；</li>
        /// <li>https: https协议；</li>
        /// <li>http2: http2协议；</li>
        /// <li>all:  所有协议。</li>不填默认为all，此参数暂未生效。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 查询时间粒度，取值有：
        /// <li>min：1分钟；</li>
        /// <li>5min：5分钟；</li>
        /// <li>hour：1小时；</li>
        /// <li>day：1天。</li>不填将根据开始时间跟结束时间的间距自动推算粒度，具体为：1小时范围内以min粒度查询，2天范围内以5min粒度查询，7天范围内以hour粒度查询，超过7天以day粒度查询。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 过滤条件，详细的过滤条件Key值如下：
        /// <li>socket<br>   按照【<strong>HTTP协议类型</strong>】进行过滤。<br>   对应的Value可选项如下：<br>   HTTP：HTTP 协议；<br>   HTTPS：HTTPS协议；<br>   QUIC：QUIC协议。</li>
        /// <li>domain<br>   按照【<strong>域名</strong>】进行过滤。</li>
        /// <li>tagKey<br>   按照【<strong>标签Key</strong>】进行过滤。</li>
        /// <li>tagValue<br>   按照【<strong>标签Value</strong>】进行过滤。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// 数据归属地区，取值有：
        /// <li>overseas：全球（除中国大陆地区）数据；</li>
        /// <li>mainland：中国大陆地区数据；</li>
        /// <li>global：全球数据。</li>不填默认取值为global。
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
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

