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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatGatewayFlowMonitorDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 时间点。表示要查询的时刻。聚合粒度为60、300时，会查询最近一个整分钟开始的聚合周期；聚合粒度为3600时，会查询最近一个整点开始的聚合周期；聚合粒度为86400时，会查询最近一个整天开始的聚合周期。形如：`2019-03-24T10:51:23+08:00`。
        /// </summary>
        [JsonProperty("TimePoint")]
        public string TimePoint{ get; set; }

        /// <summary>
        /// NAT网关的ID，形如：`nat-ig8xpno8`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 展示排序靠前的数据。默认值：10，表示默认展示排序前 10 的数据。最大值：100。
        /// </summary>
        [JsonProperty("TopN")]
        public long? TopN{ get; set; }

        /// <summary>
        /// 排序字段。支持：入包量`InPkg`、出包量`OutPkg`、入流量`InTraffic`、出流量`OutTraffic`，标准型nat额外支持 并发连接数`ConcurrentConnectionCount` 、新建连接速率`NewConnectionRate`。默认值`OutTraffic`。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 聚合时间粒度。支持：60、300、3600、86400，即按照1分钟、5分钟、1小时、1天进行聚合查询。
        /// </summary>
        [JsonProperty("AggregationTimeRange")]
        public long? AggregationTimeRange{ get; set; }

        /// <summary>
        /// 是否查询全部指标。默认值：True，表示查询全部指标。
        /// </summary>
        [JsonProperty("AllMetricMode")]
        public bool? AllMetricMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimePoint", this.TimePoint);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "TopN", this.TopN);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "AggregationTimeRange", this.AggregationTimeRange);
            this.SetParamSimple(map, prefix + "AllMetricMode", this.AllMetricMode);
        }
    }
}

