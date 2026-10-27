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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAccelerateAreasInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>加速地域</p>
        /// </summary>
        [JsonProperty("AccelerateRegion")]
        public string AccelerateRegion{ get; set; }

        /// <summary>
        /// <p>带宽</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>公网质量类型</p><p>枚举值：</p><ul><li>BGP： BGP</li><li>QUALITY_BGP： 精品BGP</li><li>STATIC_IP： 三网</li></ul>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>IP 地址协议</p><p>枚举值：</p><ul><li>IPv4： IPv4</li></ul>
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccelerateRegion", this.AccelerateRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "IspType", this.IspType);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

