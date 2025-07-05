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

    public class BgpConfig : AbstractModel
    {
        
        /// <summary>
        /// BGP隧道网段。
        /// </summary>
        [JsonProperty("TunnelCidr")]
        public string TunnelCidr{ get; set; }

        /// <summary>
        /// 云端BGP地址。必须从BGP隧道网段内分配。
        /// </summary>
        [JsonProperty("LocalBgpIp")]
        public string LocalBgpIp{ get; set; }

        /// <summary>
        /// 用户端BGP地址。必须从BGP隧道网段内分配。
        /// </summary>
        [JsonProperty("RemoteBgpIp")]
        public string RemoteBgpIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TunnelCidr", this.TunnelCidr);
            this.SetParamSimple(map, prefix + "LocalBgpIp", this.LocalBgpIp);
            this.SetParamSimple(map, prefix + "RemoteBgpIp", this.RemoteBgpIp);
        }
    }
}

