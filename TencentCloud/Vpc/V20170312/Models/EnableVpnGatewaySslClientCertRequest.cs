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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableVpnGatewaySslClientCertRequest : AbstractModel
    {
        
        /// <summary>
        /// SSL-VPN-CLIENT 实例ID。不可和SslVpnClientIds同时使用。
        /// </summary>
        [JsonProperty("SslVpnClientId")]
        public string SslVpnClientId{ get; set; }

        /// <summary>
        /// SSL-VPN-CLIENT 实例ID列表。批量启用时使用。不可和SslVpnClientId同时使用。
        /// </summary>
        [JsonProperty("SslVpnClientIds")]
        public string[] SslVpnClientIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SslVpnClientId", this.SslVpnClientId);
            this.SetParamArraySimple(map, prefix + "SslVpnClientIds.", this.SslVpnClientIds);
        }
    }
}

