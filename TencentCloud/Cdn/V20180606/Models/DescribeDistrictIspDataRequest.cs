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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDistrictIspDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名列表，最多支持20个域名
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 查询起始时间，如：2018-09-04 10:40:00，返回结果大于等于指定时间
        /// 支持近 60 天内的数据查询，每次查询时间区间为 3 小时
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，如：2018-09-04 10:40:00，返回结果小于等于指定时间
        /// 结束时间与起始时间区间最大为 3 小时
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指定查询指标，支持:
        /// bandwidth：带宽，单位为 bps
        /// flux：流量，单位为 byte
        /// request：请求数，单位为 次
        /// statusCode：状态码，返回 0、2xx、3xx、4xx、5xx 汇总数据，单位为 次
        /// 2xx：返回 2xx 状态码汇总及各 2 开头状态码数据，单位为 次
        /// 3xx：返回 3xx 状态码汇总及各 3 开头状态码数据，单位为 次
        /// 4xx：返回 4xx 状态码汇总及各 4 开头状态码数据，单位为 次
        /// 5xx：返回 5xx 状态码汇总及各 5 开头状态码数据，单位为 次
        /// 支持指定具体状态码查询，若未产生过，则返回为空
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 指定省份查询，不填充表示查询所有省份
        /// 省份、国家/地区编码可以查看 [省份编码映射](https://cloud.tencent.com/document/product/228/6316#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8)
        /// </summary>
        [JsonProperty("Districts")]
        public long?[] Districts{ get; set; }

        /// <summary>
        /// 指定运营商查询，不填充表示查询所有运营商
        /// 运营商编码可以查看 [运营商编码映射](https://cloud.tencent.com/document/product/228/6316#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8)
        /// </summary>
        [JsonProperty("Isps")]
        public long?[] Isps{ get; set; }

        /// <summary>
        /// 指定协议查询，不填充表示查询所有协议
        /// all：所有协议
        /// http：指定查询 HTTP 对应指标
        /// https：指定查询 HTTPS 对应指标
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 指定IP协议查询，不填充表示查询所有协议
        /// all：所有协议
        /// ipv4：指定查询 ipv4 对应指标
        /// ipv6：指定查询 ipv6 对应指标
        /// 指定IP协议查询时，不可同时指定省份、运营商查询
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// 时间粒度，支持以下几种模式（默认5min）：
        /// min：1 分钟粒度，支持近 60 天内的数据查询，每次查询时间区间不超过10分钟，可返回 1 分钟粒度明细数据
        /// 5min：5 分钟粒度，支持近 60 天内的数据查询，每次查询时间区间不超过3 小时，可返回 5 分钟粒度明细数据
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArraySimple(map, prefix + "Districts.", this.Districts);
            this.SetParamArraySimple(map, prefix + "Isps.", this.Isps);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

