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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceNetworkCardBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>MAC地址</p>
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// <p>网卡名称</p>
        /// </summary>
        [JsonProperty("NetworkCardName")]
        public string NetworkCardName{ get; set; }

        /// <summary>
        /// <p>网卡类型</p><p>枚举值：</p><ul><li>1： 物理网卡</li><li>2： 虚拟网卡</li></ul>
        /// </summary>
        [JsonProperty("NetworkCardType")]
        public long? NetworkCardType{ get; set; }

        /// <summary>
        /// <p>网卡状态</p><p>枚举值：</p><ul><li>1： 启用中</li><li>2： 未启用</li></ul>
        /// </summary>
        [JsonProperty("NetworkCardStatus")]
        public long? NetworkCardStatus{ get; set; }

        /// <summary>
        /// <p>IPv4地址</p>
        /// </summary>
        [JsonProperty("Ipv4Address")]
        public string Ipv4Address{ get; set; }

        /// <summary>
        /// <p>IPv6地址</p>
        /// </summary>
        [JsonProperty("Ipv6Address")]
        public string Ipv6Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "NetworkCardName", this.NetworkCardName);
            this.SetParamSimple(map, prefix + "NetworkCardType", this.NetworkCardType);
            this.SetParamSimple(map, prefix + "NetworkCardStatus", this.NetworkCardStatus);
            this.SetParamSimple(map, prefix + "Ipv4Address", this.Ipv4Address);
            this.SetParamSimple(map, prefix + "Ipv6Address", this.Ipv6Address);
        }
    }
}

