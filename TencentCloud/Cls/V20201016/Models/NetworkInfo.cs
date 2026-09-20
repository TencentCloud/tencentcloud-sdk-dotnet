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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>网络类型。 0：公网，1：内网</p>
        /// </summary>
        [JsonProperty("NetworkType")]
        public ulong? NetworkType{ get; set; }

        /// <summary>
        /// <p>私有网络id</p>
        /// </summary>
        [JsonProperty("VpcID")]
        public string VpcID{ get; set; }

        /// <summary>
        /// <p>私有网络所属用户app id</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>网络服务类型。0：CVM，3：专线网关，11：云联网，1025：CLB</p>
        /// </summary>
        [JsonProperty("VirtualGatewayType")]
        public ulong? VirtualGatewayType{ get; set; }

        /// <summary>
        /// <p>专线网关id或者云联网id</p>
        /// </summary>
        [JsonProperty("VpcGatewayIndex")]
        public string VpcGatewayIndex{ get; set; }

        /// <summary>
        /// <p>私有域名映射地址</p>
        /// </summary>
        [JsonProperty("PrivateDomainNames")]
        public PrivateDomainNames[] PrivateDomainNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "VpcID", this.VpcID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "VirtualGatewayType", this.VirtualGatewayType);
            this.SetParamSimple(map, prefix + "VpcGatewayIndex", this.VpcGatewayIndex);
            this.SetParamArrayObj(map, prefix + "PrivateDomainNames.", this.PrivateDomainNames);
        }
    }
}

