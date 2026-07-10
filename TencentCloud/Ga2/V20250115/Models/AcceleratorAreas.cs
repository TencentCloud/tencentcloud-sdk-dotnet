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

    public class AcceleratorAreas : AbstractModel
    {
        
        /// <summary>
        /// <p>加速地域。</p>
        /// </summary>
        [JsonProperty("AccelerateRegion")]
        public string AccelerateRegion{ get; set; }

        /// <summary>
        /// <p>带宽。</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>支持&#39;BGP&#39;, &#39;QUALITY_BGP&#39;, &#39;STATIC_IP&#39;，默认BGP。</p><p>枚举值：</p><ul><li>BGP： BGP</li><li>STATIC_IP： 三网</li><li>QUALITY_BGP： 精品BGP</li></ul>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>仅支持IPv4，默认是IPv4。</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// <p>加速地域ID。</p>
        /// </summary>
        [JsonProperty("AcceleratorAreaId")]
        public string AcceleratorAreaId{ get; set; }

        /// <summary>
        /// <p>IP。</p>
        /// </summary>
        [JsonProperty("IpAddress")]
        public string[] IpAddress{ get; set; }

        /// <summary>
        /// <p>IP信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpAddressInfoSet")]
        public IpAddressInfoSet[] IpAddressInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccelerateRegion", this.AccelerateRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "IspType", this.IspType);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "AcceleratorAreaId", this.AcceleratorAreaId);
            this.SetParamArraySimple(map, prefix + "IpAddress.", this.IpAddress);
            this.SetParamArrayObj(map, prefix + "IpAddressInfoSet.", this.IpAddressInfoSet);
        }
    }
}

