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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTDEMEventSearchSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>各分类窗口计数，Key 为分类 id</p>
        /// </summary>
        [JsonProperty("CategoryCounts")]
        public IntKeyValue[] CategoryCounts{ get; set; }

        /// <summary>
        /// <p>当前分类窗口条数</p>
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// <p>访问用户（设备）</p>
        /// </summary>
        [JsonProperty("Visitors")]
        public long? Visitors{ get; set; }

        /// <summary>
        /// <p>业务用户</p>
        /// </summary>
        [JsonProperty("Users")]
        public long? Users{ get; set; }

        /// <summary>
        /// <p>实际分桶秒数</p>
        /// </summary>
        [JsonProperty("IntervalSec")]
        public long? IntervalSec{ get; set; }

        /// <summary>
        /// <p>分桶趋势</p>
        /// </summary>
        [JsonProperty("Series")]
        public EventSearchSeriesPoint[] Series{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CategoryCounts.", this.CategoryCounts);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Visitors", this.Visitors);
            this.SetParamSimple(map, prefix + "Users", this.Users);
            this.SetParamSimple(map, prefix + "IntervalSec", this.IntervalSec);
            this.SetParamArrayObj(map, prefix + "Series.", this.Series);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

