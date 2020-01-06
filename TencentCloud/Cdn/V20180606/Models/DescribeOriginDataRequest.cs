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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOriginDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间，如：2018-09-04 10:40:00，返回结果大于等于指定时间
        /// 根据指定时间粒度不同，会进行向前归整，如 2018-09-04 10:40:00 在按 1 小时的时间粒度查询时，返回的第一个数据对应时间点为 2018-09-04 10:00:00
        /// 起始时间与结束时间间隔小于等于 90 天
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，如：2018-09-04 10:40:00，返回结果小于等于指定时间
        /// 根据指定时间粒度不同，会进行向前归整，如 2018-09-04 10:40:00 在按 1 小时的时间粒度查询时，返回的最后一个数据对应时间点为 2018-09-04 10:00:00
        /// 起始时间与结束时间间隔小于等于 90 天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指定查询指标，支持的类型有：
        /// flux：回源流量，单位为 byte
        /// bandwidth：回源带宽，单位为 bps
        /// request：回源请求数，单位为 次
        /// failRequest：回源失败请求数，单位为 次
        /// failRate：回源失败率，单位为 %
        /// statusCode：回源状态码，返回 2xx、3xx、4xx、5xx 汇总数据，单位为 个
        /// 2xx：返回 2xx 回源状态码汇总及各 2 开头回源状态码数据，单位为 个
        /// 3xx：返回 3xx 回源状态码汇总及各 3 开头回源状态码数据，单位为 个
        /// 4xx：返回 4xx 回源状态码汇总及各 4 开头回源状态码数据，单位为 个
        /// 5xx：返回 5xx 回源状态码汇总及各 5 开头回源状态码数据，单位为 个
        /// 支持指定具体状态码查询，若未产生过，则返回为空
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 指定查询域名列表，最多可一次性查询 30 个加速域名明细
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 指定要查询的项目 ID，[前往查看项目 ID](https://console.cloud.tencent.com/project)
        /// 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// 时间粒度，支持以下几种模式：
        /// min：1 分钟粒度，指定查询区间 24 小时内（含 24 小时），可返回 1 分钟粒度明细数据（指定查询服务地域为中国境外时不支持 1 分钟粒度）
        /// 5min：5 分钟粒度，指定查询区间 31 天内（含 31 天），可返回 5 分钟粒度明细数据
        /// hour：1 小时粒度，指定查询区间 31 天内（含 31 天），可返回 1 小时粒度明细数据
        /// day：天粒度，指定查询区间大于 31 天，可返回天粒度明细数据
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Domains 传入多个时，默认（false)返回多个域名的汇总数据
        /// 可按需指定为 true，返回每一个 Domain 的明细数据（statusCode 指标暂不支持）
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// 指定服务地域查询，不填充表示查询中国境内 CDN 数据
        /// mainland：指定查询中国境内 CDN 数据
        /// overseas：指定查询中国境外 CDN 数据
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

