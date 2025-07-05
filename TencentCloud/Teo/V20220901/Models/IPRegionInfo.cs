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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// IP 地址，IPV4 或 IPV6。
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// IP 是否属于 EdgeOne 节点，取值有：
        /// <li>yes：该 IP 属于 EdgeOne 节点；</li>
        /// <li>no：该 IP 不属于 EdgeOne 节点。</li>
        /// </summary>
        [JsonProperty("IsEdgeOneIP")]
        public string IsEdgeOneIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "IsEdgeOneIP", this.IsEdgeOneIP);
        }
    }
}

