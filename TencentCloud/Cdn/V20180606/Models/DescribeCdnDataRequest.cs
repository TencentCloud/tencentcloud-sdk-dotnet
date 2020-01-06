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

    public class DescribeCdnDataRequest : AbstractModel
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
        /// flux：流量，单位为 byte
        /// bandwidth：带宽，单位为 bps
        /// request：请求数，单位为 次
        /// fluxHitRate：流量命中率，单位为 %
        /// statusCode：状态码，返回 2xx、3xx、4xx、5xx 汇总数据，单位为 个
        /// 2xx：返回 2xx 状态码汇总及各 2 开头状态码数据，单位为 个
        /// 3xx：返回 3xx 状态码汇总及各 3 开头状态码数据，单位为 个
        /// 4xx：返回 4xx 状态码汇总及各 4 开头状态码数据，单位为 个
        /// 5xx：返回 5xx 状态码汇总及各 5 开头状态码数据，单位为 个
        /// 支持指定具体状态码查询，若未产生过，则返回为空
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 指定查询域名列表
        /// 最多可一次性查询 30 个加速域名明细
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
        /// 多域名查询时，默认（false)返回多个域名的汇总数据
        /// 可按需指定为 true，返回每一个 Domain 的明细数据（statusCode 指标暂不支持）
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// 查询中国境内CDN数据时，指定运营商查询，不填充表示查询所有运营商
        /// 运营商编码可以查看 [运营商编码映射](https://cloud.tencent.com/document/product/228/6316#.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84)
        /// 指定运营商查询时，不可同时指定省份、IP协议查询
        /// </summary>
        [JsonProperty("Isp")]
        public long? Isp{ get; set; }

        /// <summary>
        /// 查询中国境内CDN数据时，指定省份查询，不填充表示查询所有省份
        /// 查询中国境外CDN数据时，指定国家/地区查询，不填充表示查询所有国家/地区
        /// 省份、国家/地区编码可以查看 [省份编码映射](https://cloud.tencent.com/document/product/228/6316#.E7.9C.81.E4.BB.BD.E6.98.A0.E5.B0.84)
        /// 指定（中国境内）省份查询时，不可同时指定运营商、IP协议查询
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// 指定协议查询，不填充表示查询所有协议
        /// all：所有协议
        /// http：指定查询 HTTP 对应指标
        /// https：指定查询 HTTPS 对应指标
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 指定数据源查询，白名单功能
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

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
        /// 指定服务地域查询，不填充表示查询中国境内CDN数据
        /// mainland：指定查询中国境内 CDN 数据
        /// overseas：指定查询中国境外 CDN 数据
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 查询中国境外CDN数据时，可指定地区类型查询，不填充表示查询服务地区数据（仅在 Area 为 overseas 时可用）
        /// server：指定查询服务地区（腾讯云 CDN 节点服务器所在地区）数据
        /// client：指定查询客户端地区（用户请求终端所在地区）数据
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }


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
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AreaType", this.AreaType);
        }
    }
}

