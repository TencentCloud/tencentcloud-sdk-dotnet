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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBlockingTrendResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>使用的粒度名称，取值：SECONDS / MINUTES / FIVE_MINUTES / TEN_MINUTES / FIFTEEN_MINUTES / THIRTY_MINUTES / HOUR。时间窗口 ≤ 1 分钟时自动采用 SECONDS（1 秒）粒度。</p>
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }

        /// <summary>
        /// <p>粒度对应的毫秒值（SECONDS=1000，MINUTES=60000，... HOUR=3600000）。</p>
        /// </summary>
        [JsonProperty("GranularityMs")]
        public long? GranularityMs{ get; set; }

        /// <summary>
        /// <p>阻塞趋势时序点列表（按 ReportTime 升序，稠密时序：窗口内每个 bucket 都返回一个点，无数据 bucket 补零）。</p>
        /// </summary>
        [JsonProperty("DataPoints")]
        public BlockingTrendPoint[] DataPoints{ get; set; }

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
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "GranularityMs", this.GranularityMs);
            this.SetParamArrayObj(map, prefix + "DataPoints.", this.DataPoints);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

