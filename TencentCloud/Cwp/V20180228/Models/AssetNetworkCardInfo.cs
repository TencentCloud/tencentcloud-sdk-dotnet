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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetNetworkCardInfo : AbstractModel
    {
        
        /// <summary>
        /// 网卡名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Ipv4对应IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 网关
        /// </summary>
        [JsonProperty("GateWay")]
        public string GateWay{ get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// Ipv6对应IP
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// DNS服务器
        /// </summary>
        [JsonProperty("DnsServer")]
        public string DnsServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "GateWay", this.GateWay);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "DnsServer", this.DnsServer);
        }
    }
}

