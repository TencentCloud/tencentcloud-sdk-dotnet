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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewNDRDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>NDR 能力或服务状态标识。</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>NDR 总带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("TotalMbps")]
        public long? TotalMbps{ get; set; }

        /// <summary>
        /// <p>入方向峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("InMaxBps")]
        public long? InMaxBps{ get; set; }

        /// <summary>
        /// <p>出方向峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("OutMaxBps")]
        public long? OutMaxBps{ get; set; }

        /// <summary>
        /// <p>总体峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("MaxFlowBps")]
        public long? MaxFlowBps{ get; set; }

        /// <summary>
        /// <p>当前流量使用率。</p><p>单位：%</p>
        /// </summary>
        [JsonProperty("FlowPercent")]
        public float? FlowPercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalMbps", this.TotalMbps);
            this.SetParamSimple(map, prefix + "InMaxBps", this.InMaxBps);
            this.SetParamSimple(map, prefix + "OutMaxBps", this.OutMaxBps);
            this.SetParamSimple(map, prefix + "MaxFlowBps", this.MaxFlowBps);
            this.SetParamSimple(map, prefix + "FlowPercent", this.FlowPercent);
        }
    }
}

