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

    public class CcnRegionBandwidthLimit : AbstractModel
    {
        
        /// <summary>
        /// 地域，例如：ap-guangzhou
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 出带宽上限，单位：Mbps
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public ulong? BandwidthLimit{ get; set; }

        /// <summary>
        /// 是否黑石地域，默认`false`。
        /// </summary>
        [JsonProperty("IsBm")]
        public bool? IsBm{ get; set; }

        /// <summary>
        /// 目的地域，例如：ap-shanghai
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// 目的地域是否为黑石地域，默认`false`。
        /// </summary>
        [JsonProperty("DstIsBm")]
        public bool? DstIsBm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "IsBm", this.IsBm);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamSimple(map, prefix + "DstIsBm", this.DstIsBm);
        }
    }
}

