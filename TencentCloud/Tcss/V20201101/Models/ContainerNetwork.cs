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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerNetwork : AbstractModel
    {
        
        /// <summary>
        /// endpoint id
        /// </summary>
        [JsonProperty("EndpointID")]
        public string EndpointID{ get; set; }

        /// <summary>
        /// 模式:bridge
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 网络名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("NetworkID")]
        public string NetworkID{ get; set; }

        /// <summary>
        /// 网关
        /// </summary>
        [JsonProperty("Gateway")]
        public string Gateway{ get; set; }

        /// <summary>
        /// IPV4地址
        /// </summary>
        [JsonProperty("Ipv4")]
        public string Ipv4{ get; set; }

        /// <summary>
        /// IPV6地址
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// MAC 地址
        /// </summary>
        [JsonProperty("MAC")]
        public string MAC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointID", this.EndpointID);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NetworkID", this.NetworkID);
            this.SetParamSimple(map, prefix + "Gateway", this.Gateway);
            this.SetParamSimple(map, prefix + "Ipv4", this.Ipv4);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "MAC", this.MAC);
        }
    }
}

