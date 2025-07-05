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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckProxyCreateRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道的接入(加速)区域。取值可通过接口DescribeAccessRegionsByDestRegion获取到
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// 通道的源站区域。取值可通过接口DescribeDestRegions获取到
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// 通道带宽上限，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 通道并发量上限，表示同时在线的连接数，单位：万。
        /// </summary>
        [JsonProperty("Concurrent")]
        public ulong? Concurrent{ get; set; }

        /// <summary>
        /// 如果在通道组下创建通道，需要填写通道组的ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// IP版本，可取值：IPv4、IPv6，默认值IPv4
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// 网络类型，可取值：normal、cn2，默认值normal
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 通道套餐类型。Thunder表示标准通道组，Accelerator表示游戏加速器通道，CrossBorder表示跨境通道。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 该字段已废弃，当IPAddressVersion为IPv4时，所创建的通道默认支持Http3.0；当为IPv6，默认不支持Http3.0。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
        }
    }
}

