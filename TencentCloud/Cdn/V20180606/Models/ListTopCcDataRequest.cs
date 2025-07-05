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

    public class ListTopCcDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询Top数据的开始时间，格式为：2020-01-01 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询Top数据的结束时间，格式为：2020-01-01 23:59:59
        /// 支持 90 天内数据查询，不传此参数，表示查当天数据
        /// 时间跨度要小于等于7天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 域名，不传此参数，表示查询账号级别数据
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 统计指标：
        /// ip_url : Top IP+URL 默认值
        /// ua :  Top UA
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// cdn表示CDN数据，默认值
        /// ecdn表示ECDN数据
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 域名列表，不传此参数，表示查询账号级别数据
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 执行动作，取值为：intercept/redirect/observe
        /// 分别表示：拦截/重定向/观察
        /// 为空表示查询所有执行动作数据
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// 地域：mainland或overseas，表示国内或海外，不填写默认表示国内
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
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

