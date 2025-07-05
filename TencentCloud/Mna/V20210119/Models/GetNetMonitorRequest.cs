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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetNetMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 统计指标（上行速率："TxRate":bit/s，下行速率："RxRate":bit/s，丢包："Loss":%，时延："RTT":ms）
        /// </summary>
        [JsonProperty("Metrics")]
        public string Metrics{ get; set; }

        /// <summary>
        /// 网关类型。0：公有云网关；1：自有网关。不传默认为0。
        /// </summary>
        [JsonProperty("GatewayType")]
        public long? GatewayType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metrics", this.Metrics);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
        }
    }
}

