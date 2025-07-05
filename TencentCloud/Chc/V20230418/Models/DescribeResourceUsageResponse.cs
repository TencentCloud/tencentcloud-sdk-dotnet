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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceUsageResponse : AbstractModel
    {
        
        /// <summary>
        /// 托管服务器数量
        /// </summary>
        [JsonProperty("HostingServerCount")]
        public ulong? HostingServerCount{ get; set; }

        /// <summary>
        /// 租用服务器数量
        /// </summary>
        [JsonProperty("RentServerCount")]
        public ulong? RentServerCount{ get; set; }

        /// <summary>
        /// 网络设备数量
        /// </summary>
        [JsonProperty("NetDeviceCount")]
        public ulong? NetDeviceCount{ get; set; }

        /// <summary>
        /// 机架总数
        /// </summary>
        [JsonProperty("RackTotalCount")]
        public ulong? RackTotalCount{ get; set; }

        /// <summary>
        /// 开电机架总数
        /// </summary>
        [JsonProperty("RackPowerOnCount")]
        public ulong? RackPowerOnCount{ get; set; }

        /// <summary>
        /// 机位使用数量
        /// </summary>
        [JsonProperty("PositionUsedCount")]
        public ulong? PositionUsedCount{ get; set; }

        /// <summary>
        /// 机位总数
        /// </summary>
        [JsonProperty("PositionTotalCount")]
        public ulong? PositionTotalCount{ get; set; }

        /// <summary>
        /// 机架开电率，保留一位小数
        /// </summary>
        [JsonProperty("RackPowerOnRate")]
        public string RackPowerOnRate{ get; set; }

        /// <summary>
        /// 机位使用率，
        /// </summary>
        [JsonProperty("PositionUsedRate")]
        public string PositionUsedRate{ get; set; }

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
            this.SetParamSimple(map, prefix + "HostingServerCount", this.HostingServerCount);
            this.SetParamSimple(map, prefix + "RentServerCount", this.RentServerCount);
            this.SetParamSimple(map, prefix + "NetDeviceCount", this.NetDeviceCount);
            this.SetParamSimple(map, prefix + "RackTotalCount", this.RackTotalCount);
            this.SetParamSimple(map, prefix + "RackPowerOnCount", this.RackPowerOnCount);
            this.SetParamSimple(map, prefix + "PositionUsedCount", this.PositionUsedCount);
            this.SetParamSimple(map, prefix + "PositionTotalCount", this.PositionTotalCount);
            this.SetParamSimple(map, prefix + "RackPowerOnRate", this.RackPowerOnRate);
            this.SetParamSimple(map, prefix + "PositionUsedRate", this.PositionUsedRate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

