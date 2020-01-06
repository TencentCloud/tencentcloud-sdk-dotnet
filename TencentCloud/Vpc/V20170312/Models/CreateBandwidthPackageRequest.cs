/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateBandwidthPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 带宽包类型，包括'BGP'，'SINGLEISP'，'ANYCAST'
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 带宽包计费类型，包括‘TOP5_POSTPAID_BY_MONTH’，‘PERCENT95_POSTPAID_BY_MONTH’
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 带宽包名字
        /// </summary>
        [JsonProperty("BandwidthPackageName")]
        public string BandwidthPackageName{ get; set; }

        /// <summary>
        /// 带宽包数量(非上移账户只能填1)
        /// </summary>
        [JsonProperty("BandwidthPackageCount")]
        public ulong? BandwidthPackageCount{ get; set; }

        /// <summary>
        /// 带宽包限速大小。单位：Mbps，-1表示不限速。
        /// </summary>
        [JsonProperty("InternetMaxBandwidth")]
        public long? InternetMaxBandwidth{ get; set; }

        /// <summary>
        /// 需要关联的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 带宽包协议类型。当前支持'ipv4'和'ipv6'协议带宽包，默认值是'ipv4'。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageName", this.BandwidthPackageName);
            this.SetParamSimple(map, prefix + "BandwidthPackageCount", this.BandwidthPackageCount);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidth", this.InternetMaxBandwidth);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

