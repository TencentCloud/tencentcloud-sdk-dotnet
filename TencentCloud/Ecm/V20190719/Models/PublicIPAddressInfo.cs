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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublicIPAddressInfo : AbstractModel
    {
        
        /// <summary>
        /// 计费模式。
        /// </summary>
        [JsonProperty("ChargeMode")]
        public string ChargeMode{ get; set; }

        /// <summary>
        /// 实例的公网ip。
        /// </summary>
        [JsonProperty("PublicIPAddress")]
        public string PublicIPAddress{ get; set; }

        /// <summary>
        /// 实例的公网ip所属的运营商。
        /// </summary>
        [JsonProperty("ISP")]
        public ISP ISP{ get; set; }

        /// <summary>
        /// 实例的最大出带宽上限，单位为Mbps。
        /// </summary>
        [JsonProperty("MaxBandwidthOut")]
        public long? MaxBandwidthOut{ get; set; }

        /// <summary>
        /// 实例的最大入带宽上限，单位为Mbps。
        /// </summary>
        [JsonProperty("MaxBandwidthIn")]
        public long? MaxBandwidthIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChargeMode", this.ChargeMode);
            this.SetParamSimple(map, prefix + "PublicIPAddress", this.PublicIPAddress);
            this.SetParamObj(map, prefix + "ISP.", this.ISP);
            this.SetParamSimple(map, prefix + "MaxBandwidthOut", this.MaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MaxBandwidthIn", this.MaxBandwidthIn);
        }
    }
}

