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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PoolInfo : AbstractModel
    {
        
        /// <summary>
        /// 唯一id
        /// </summary>
        [JsonProperty("PoolUid")]
        public long? PoolUid{ get; set; }

        /// <summary>
        /// 是否支持ipv6
        /// </summary>
        [JsonProperty("Ipv6Enable")]
        public long? Ipv6Enable{ get; set; }

        /// <summary>
        /// 剩余可用app
        /// </summary>
        [JsonProperty("AvailableAppCount")]
        public long? AvailableAppCount{ get; set; }

        /// <summary>
        /// svr机器列表
        /// </summary>
        [JsonProperty("ServerList")]
        public ServerMachineInfo[] ServerList{ get; set; }

        /// <summary>
        /// proxy机器列表
        /// </summary>
        [JsonProperty("ProxyList")]
        public ProxyMachineInfo[] ProxyList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PoolUid", this.PoolUid);
            this.SetParamSimple(map, prefix + "Ipv6Enable", this.Ipv6Enable);
            this.SetParamSimple(map, prefix + "AvailableAppCount", this.AvailableAppCount);
            this.SetParamArrayObj(map, prefix + "ServerList.", this.ServerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
        }
    }
}

