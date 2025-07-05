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

    public class DescribeTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始日期：yyyy-MM-dd HH:mm:ss
        /// 仅支持按天粒度的数据查询，取入参中的天信息作为起始日期
        /// 返回大于等于起始日期当天 00:00:00 点产生的数据，如 StartTime为2018-09-04 10:40:00，返回数据的起始时间为2018-09-04 00:00:00
        /// 仅支持 90 天内数据查询
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束日期：yyyy-MM-dd HH:mm:ss
        /// 仅支持按天粒度的数据查询，取入参中的天信息作为结束日期
        /// 返回小于等于结束日期当天 23:59:59 产生的数据，如EndTime为2018-09-05 22:40:00，返回数据的结束时间为2018-09-05 23:59:59
        /// EndTime 需要大于等于 StartTime
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序对象，支持以下几种形式：
        /// ip、ua_device、ua_browser、ua_os、referer
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 排序使用的指标名称：
        /// flux：Metric 为 host 时指代访问流量
        /// request：Metric 为 host 时指代访问请求数
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 指定查询域名列表，最多可一次性查询 30 个加速域名明细
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// 是否详细显示每个域名的的具体数值
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
        /// 指定查询的产品数据，目前仅可使用cdn
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

