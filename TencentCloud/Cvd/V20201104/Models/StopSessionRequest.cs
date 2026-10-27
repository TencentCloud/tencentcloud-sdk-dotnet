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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StopSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>机器所在区域</p>
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// <p>机器hostname</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>IsDisconnect为true，表示断开当前会话<br>IsDisconnect为false，表示注销当前会话</p>
        /// </summary>
        [JsonProperty("IsDisconnect")]
        public bool? IsDisconnect{ get; set; }

        /// <summary>
        /// <p>选填，为多会话预留字段</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "IsDisconnect", this.IsDisconnect);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

