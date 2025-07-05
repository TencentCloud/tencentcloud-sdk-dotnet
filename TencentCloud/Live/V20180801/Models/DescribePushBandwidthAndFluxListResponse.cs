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

    public class DescribePushBandwidthAndFluxListResponse : AbstractModel
    {
        
        /// <summary>
        /// 峰值带宽所在时间点，
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("PeakBandwidthTime")]
        public string PeakBandwidthTime{ get; set; }

        /// <summary>
        /// 峰值带宽，单位是 Mbps。
        /// </summary>
        [JsonProperty("PeakBandwidth")]
        public float? PeakBandwidth{ get; set; }

        /// <summary>
        /// 95峰值带宽所在时间点，
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("P95PeakBandwidthTime")]
        public string P95PeakBandwidthTime{ get; set; }

        /// <summary>
        /// 95峰值带宽，单位是 Mbps。
        /// </summary>
        [JsonProperty("P95PeakBandwidth")]
        public float? P95PeakBandwidth{ get; set; }

        /// <summary>
        /// 总流量，单位是 MB。
        /// </summary>
        [JsonProperty("SumFlux")]
        public float? SumFlux{ get; set; }

        /// <summary>
        /// 明细数据信息。
        /// </summary>
        [JsonProperty("DataInfoList")]
        public BillDataInfo[] DataInfoList{ get; set; }

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
            this.SetParamSimple(map, prefix + "PeakBandwidthTime", this.PeakBandwidthTime);
            this.SetParamSimple(map, prefix + "PeakBandwidth", this.PeakBandwidth);
            this.SetParamSimple(map, prefix + "P95PeakBandwidthTime", this.P95PeakBandwidthTime);
            this.SetParamSimple(map, prefix + "P95PeakBandwidth", this.P95PeakBandwidth);
            this.SetParamSimple(map, prefix + "SumFlux", this.SumFlux);
            this.SetParamArrayObj(map, prefix + "DataInfoList.", this.DataInfoList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

