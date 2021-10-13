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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEcdnStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间，如：2019-12-13 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，如：2019-12-13 23:59:59
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指定查询指标，支持的类型有：
        /// flux：流量，单位为 byte
        /// bandwidth：带宽，单位为 bps
        /// request：请求数，单位为 次
        /// 2xx：返回 2xx 状态码汇总或者 2 开头状态码数据，单位为 个
        /// 3xx：返回 3xx 状态码汇总或者 3 开头状态码数据，单位为 个
        /// 4xx：返回 4xx 状态码汇总或者 4 开头状态码数据，单位为 个
        /// 5xx：返回 5xx 状态码汇总或者 5 开头状态码数据，单位为 个
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// 时间粒度，支持以下几种模式：
        /// 1 天	 1，5，15，30，60，120，240，1440 
        /// 2 ~ 3 天	15，30，60，120，240，1440
        /// 4 ~ 7 天	30，60，120，240，1440
        /// 8 ~ 31 天	 60，120，240，1440
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 指定查询域名列表
        /// 
        /// 最多可一次性查询30个加速域名。
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 指定要查询的项目 ID，[前往查看项目 ID](https://console.cloud.tencent.com/project)
        /// 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主
        /// </summary>
        [JsonProperty("Projects")]
        public long?[] Projects{ get; set; }

        /// <summary>
        /// 统计区域:
        /// mainland: 境内
        /// oversea: 境外
        /// global: 全部
        /// 默认 global
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
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "Projects.", this.Projects);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

