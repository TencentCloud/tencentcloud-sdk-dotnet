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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamPackageOutputStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询起始时间，RFC3339 格式，如 2026-08-24T00:00:00+08:00</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间，RFC3339 格式，如 2026-08-24T00:00:00+08:00；必须晚于 StartTime</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>频道ID列表，不传则查全部频道</p>
        /// </summary>
        [JsonProperty("ChannelIds")]
        public string[] ChannelIds{ get; set; }

        /// <summary>
        /// <p>频道类型过滤，枚举值：LiveChannel</p>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// <p>维度，false(默认): summary 汇总模式；true: detail 明细模式（按时间拆分），当为false时粒度不生效</p>
        /// </summary>
        [JsonProperty("Dimension")]
        public bool? Dimension{ get; set; }

        /// <summary>
        /// <p>时间粒度（分钟），支持5（默认）/ 60 / 1440</p>
        /// </summary>
        [JsonProperty("Granularity")]
        public long? Granularity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "ChannelIds.", this.ChannelIds);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
        }
    }
}

