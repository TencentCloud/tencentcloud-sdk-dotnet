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
        /// 站点 ID 集合，此参数必填。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// 指标列表，取值有：
        /// <li>acc_flux: 内容加速流量，单位为 Byte；</li>
        /// <li>smt_flux: 智能加速流量，单位为 Byte；</li>
        /// <li>l4_flux: 四层加速流量，单位为 Byte；</li>
        /// <li>sec_flux: 独立防护流量，单位为 Byte；</li>
        /// <li>zxctg_flux: 中国大陆网络优化流量，单位为 Byte；</li>
        /// <li>acc_bandwidth: 内容加速带宽，单位为 bps；</li>
        /// <li>smt_bandwidth: 智能加速带宽，单位为 bps；</li>
        /// <li>l4_bandwidth: 四层加速带宽，单位为 bps；</li>
        /// <li>sec_bandwidth: 独立防护带宽，单位为 bps；</li>
        /// <li>zxctg_bandwidth: 中国大陆网络优化带宽，单位为 bps；</li>
        /// <li>sec_request_clean: HTTP/HTTPS 请求，单位为次；</li>
        /// <li>smt_request_clean: 智能加速请求，单位为次；</li>
        /// <li>quic_request: QUIC 请求，单位为次；</li>
        /// <li>bot_request_clean: Bot 请求，单位为次；</li>
        /// <li>cls_count: 实时日志推送条数，单位为条；</li>
        /// <li>ddos_bandwidth: 弹性 DDoS 防护带宽，单位为 bps。</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 查询时间粒度，取值有：
        /// <li>5min：5 分钟粒度；</li>
        /// <li>hour：1 小时粒度；</li>
        /// <li>day：1 天粒度。</li>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 过滤条件，详细的过滤条件取值如下：
        /// <li>host：按照域名进行过滤。示例值：test.example.com。<br></li>
        /// <li>proxy-id：按照四层代理实例 ID 进行过滤。示例值：sid-2rugn89bkla9。<br></li>
        /// <li>region-id：按照计费大区进行过滤。可选项如下：<br>  CH：中国大陆境内<br>  AF：非洲<br>  AS1：亚太一区<br>  AS2：亚太二区<br>  AS3：亚太三区<br>  EU：欧洲<br>  MidEast：中东<br>  NA：北美<br>  SA：南美</li>
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
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

