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

    public class BgpConfigAndAsn : AbstractModel
    {
        
        /// <summary>
        /// BGP通道CIDR
        /// </summary>
        [JsonProperty("TunnelCidr")]
        public string TunnelCidr{ get; set; }

        /// <summary>
        /// 本端BGP IP
        /// </summary>
        [JsonProperty("LocalBgpIp")]
        public string LocalBgpIp{ get; set; }

        /// <summary>
        /// 对端BGP IP
        /// </summary>
        [JsonProperty("RemoteBgpIp")]
        public string RemoteBgpIp{ get; set; }

        /// <summary>
        /// 本端BGP ASN号
        /// </summary>
        [JsonProperty("LocalBgpAsn")]
        public string LocalBgpAsn{ get; set; }

        /// <summary>
        /// 对端BGP ASN号
        /// </summary>
        [JsonProperty("RemoteBgpAsn")]
        public string RemoteBgpAsn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TunnelCidr", this.TunnelCidr);
            this.SetParamSimple(map, prefix + "LocalBgpIp", this.LocalBgpIp);
            this.SetParamSimple(map, prefix + "RemoteBgpIp", this.RemoteBgpIp);
            this.SetParamSimple(map, prefix + "LocalBgpAsn", this.LocalBgpAsn);
            this.SetParamSimple(map, prefix + "RemoteBgpAsn", this.RemoteBgpAsn);
        }
    }
}

