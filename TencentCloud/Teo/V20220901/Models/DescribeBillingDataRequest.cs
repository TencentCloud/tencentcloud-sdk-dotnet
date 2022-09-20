/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 时间粒度, 支持指定以下几种粒度：
        /// <ul>
        /// <li>min：1分钟粒度；</li>
        /// <li>5min：5分钟粒度；</li>
        /// <li>hour：1小时粒度；</li>
        /// <li>day：天粒度；</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 指标名,支持:
        /// <ul>
        /// <li>acc_flux: 内容加速流量用量；</li>
        /// <li>quic_request: QUIC 请求数用量；</li>
        /// <li>sec_flux: 安全流量用量；</li>
        /// <li>sec_request_clean: 安全干净流量请求数；</li>
        /// </ul>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 筛选条件. 支持:
        /// <ul>
        /// <li>zone: 站点级数据；</li>
        /// <li>plan: 套餐级数据；</li>
        /// <li>service: l4 / l7分别筛选四七层数据；</li>
        /// <li>tagKey: 标签Key；</li>
        /// <li>tagValue: 标签Value。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Filters")]
        public BillingDataFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

