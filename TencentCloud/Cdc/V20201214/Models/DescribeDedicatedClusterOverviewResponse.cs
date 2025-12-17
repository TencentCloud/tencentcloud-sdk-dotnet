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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDedicatedClusterOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 云服务器数量
        /// </summary>
        [JsonProperty("CvmCount")]
        public ulong? CvmCount{ get; set; }

        /// <summary>
        /// 宿主机数量
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// vpn通道状态
        /// </summary>
        [JsonProperty("VpnConnectionState")]
        public string VpnConnectionState{ get; set; }

        /// <summary>
        /// vpn网关监控数据
        /// </summary>
        [JsonProperty("VpngwBandwidthData")]
        public VpngwBandwidthData VpngwBandwidthData{ get; set; }

        /// <summary>
        /// 本地网关信息
        /// </summary>
        [JsonProperty("LocalNetInfo")]
        public LocalNetInfo LocalNetInfo{ get; set; }

        /// <summary>
        /// vpn网关通道监控数据
        /// </summary>
        [JsonProperty("VpnConnectionBandwidthData")]
        public VpngwBandwidthData[] VpnConnectionBandwidthData{ get; set; }

        /// <summary>
        /// 宿主机资源概览信息
        /// </summary>
        [JsonProperty("HostDetailInfo")]
        public HostDetailInfo[] HostDetailInfo{ get; set; }

        /// <summary>
        /// 热备宿主机数量
        /// </summary>
        [JsonProperty("HostStandbyCount")]
        public ulong? HostStandbyCount{ get; set; }

        /// <summary>
        /// 普通宿主机数量
        /// </summary>
        [JsonProperty("HostNormalCount")]
        public ulong? HostNormalCount{ get; set; }

        /// <summary>
        /// 异常宿主机数量
        /// </summary>
        [JsonProperty("HostAbnormalCount")]
        public ulong? HostAbnormalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "CvmCount", this.CvmCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "VpnConnectionState", this.VpnConnectionState);
            this.SetParamObj(map, prefix + "VpngwBandwidthData.", this.VpngwBandwidthData);
            this.SetParamObj(map, prefix + "LocalNetInfo.", this.LocalNetInfo);
            this.SetParamArrayObj(map, prefix + "VpnConnectionBandwidthData.", this.VpnConnectionBandwidthData);
            this.SetParamArrayObj(map, prefix + "HostDetailInfo.", this.HostDetailInfo);
            this.SetParamSimple(map, prefix + "HostStandbyCount", this.HostStandbyCount);
            this.SetParamSimple(map, prefix + "HostNormalCount", this.HostNormalCount);
            this.SetParamSimple(map, prefix + "HostAbnormalCount", this.HostAbnormalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

