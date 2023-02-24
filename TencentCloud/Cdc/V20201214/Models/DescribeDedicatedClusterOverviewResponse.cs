/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpnConnectionState")]
        public string VpnConnectionState{ get; set; }

        /// <summary>
        /// vpn网关监控数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpngwBandwidthData")]
        public VpngwBandwidthData VpngwBandwidthData{ get; set; }

        /// <summary>
        /// 本地网关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalNetInfo")]
        public LocalNetInfo LocalNetInfo{ get; set; }

        /// <summary>
        /// vpn网关通道监控数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpnConnectionBandwidthData")]
        public VpngwBandwidthData[] VpnConnectionBandwidthData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

