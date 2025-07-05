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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHistogramRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("FromTime")]
        public string FromTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("ToTime")]
        public string ToTime{ get; set; }

        /// <summary>
        /// 聚类字段，ip为ip聚合，art为响应耗时聚合，url为url聚合，local为ip转化的城市聚合,qps为每秒请求数峰值的聚合，up为上行带宽峰值聚合，down为下行带峰值聚合
        /// </summary>
        [JsonProperty("QueryField")]
        public string QueryField{ get; set; }

        /// <summary>
        /// 条件，access为访问日志，attack为攻击日志
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 兼容Host，逐步淘汰Host字段
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 只有两个值有效，sparta-waf，clb-waf，不传则不过滤
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// WAF实例ID，不传则不过滤
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 域名过滤，不传则不过滤，用于替代Host字段，逐步淘汰Host
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
            this.SetParamSimple(map, prefix + "QueryField", this.QueryField);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

