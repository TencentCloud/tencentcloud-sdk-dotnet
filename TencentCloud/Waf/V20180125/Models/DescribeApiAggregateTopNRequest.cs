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

    public class DescribeApiAggregateTopNRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 需要的Top数，默认5， 最大值100
        /// </summary>
        [JsonProperty("TopN")]
        public ulong? TopN{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTs")]
        public ulong? StartTs{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTs")]
        public ulong? EndTs{ get; set; }

        /// <summary>
        /// 需要查询TOP的维度名
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("Filters")]
        public BotDataFilter[] Filters{ get; set; }

        /// <summary>
        /// 是否查询全域名的三个特殊图标
        /// </summary>
        [JsonProperty("GlobalFlag")]
        public bool? GlobalFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "TopN", this.TopN);
            this.SetParamSimple(map, prefix + "StartTs", this.StartTs);
            this.SetParamSimple(map, prefix + "EndTs", this.EndTs);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "GlobalFlag", this.GlobalFlag);
        }
    }
}

