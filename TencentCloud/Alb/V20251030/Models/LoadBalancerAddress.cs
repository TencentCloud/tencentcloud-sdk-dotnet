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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancerAddress : AbstractModel
    {
        
        /// <summary>
        /// IPv4 地址列表
        /// </summary>
        [JsonProperty("IPv4Address")]
        public IPAddressInfo[] IPv4Address{ get; set; }

        /// <summary>
        /// IPv6 地址列表
        /// </summary>
        [JsonProperty("IPv6Address")]
        public IPAddressInfo[] IPv6Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "IPv4Address.", this.IPv4Address);
            this.SetParamArrayObj(map, prefix + "IPv6Address.", this.IPv6Address);
        }
    }
}

