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

    public class ListTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始日期，如：2018-09-09 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束日期，如：2018-09-10 00:00:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序对象，支持以下几种形式：
        /// Url：访问 URL 排序，带参数统计，支持的 Filter 为 flux、request
        /// Path：访问 URL 排序，不带参数统计，支持的 Filter 为 flux、request（白名单功能）
        /// District：省份排序，支持的 Filter 为 flux、request
        /// Isp：运营商排序，支持的 Filter 为 flux、request
        /// Host：域名访问数据排序，支持的 Filter 为：flux, request, bandwidth, fluxHitRate, 2XX, 3XX, 4XX, 5XX，具体状态码统计
        /// originHost：域名回源数据排序，支持的 Filter 为 flux， request，bandwidth，origin_2XX，origin_3XX，oringin_4XX，origin_5XX，具体回源状态码统计
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 排序使用的指标名称：
        /// flux：Metric 为 host 时指代访问流量，originHost 时指代回源流量
        /// bandwidth：Metric 为 host 时指代访问带宽，originHost 时指代回源带宽
        /// request：Metric 为 host 时指代访问请求数，originHost 时指代回源请求数
        /// fluxHitRate：平均流量命中率
        /// 2XX：访问 2XX 状态码
        /// 3XX：访问 3XX 状态码
        /// 4XX：访问 4XX 状态码
        /// 5XX：访问 5XX 状态码
        /// origin_2XX：回源 2XX 状态码
        /// origin_3XX：回源 3XX 状态码
        /// origin_4XX：回源 4XX 状态码
        /// origin_5XX：回源 5XX 状态码
        /// statusCode：指定访问状态码统计，在 Code 参数中填充指定状态码
        /// OriginStatusCode：指定回源状态码统计，在 Code 参数中填充指定状态码
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

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
        /// 多域名查询时，默认（false)返回所有域名汇总排序结果
        /// Metric 为 Url、Path、District、Isp，Filter 为 flux、reqeust 时，可设置为 true，返回每一个 Domain 的排序数据
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// Filter 为 statusCode、OriginStatusCode 时，填充指定状态码查询排序结果
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Code", this.Code);
        }
    }
}

