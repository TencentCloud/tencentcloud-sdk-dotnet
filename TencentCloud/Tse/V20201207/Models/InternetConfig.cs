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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetConfig : AbstractModel
    {
        
        /// <summary>
        /// 公网地址版本，可选："IPV4" | "IPV6" 。不填默认 IPV4 。
        /// </summary>
        [JsonProperty("InternetAddressVersion")]
        public string InternetAddressVersion{ get; set; }

        /// <summary>
        /// 公网付费类型，当前仅可选："BANDWIDTH"。不填默认为 "BANDWIDTH"
        /// </summary>
        [JsonProperty("InternetPayMode")]
        public string InternetPayMode{ get; set; }

        /// <summary>
        /// 公网带宽。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 负载均衡描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 负载均衡的规格类型，支持clb.c2.medium、clb.c3.small、clb.c3.medium、clb.c4.small、clb.c4.medium、clb.c4.large、clb.c4.xlarge，不传为共享型。
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// 负载均衡是否多可用区
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// 主可用区
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// 备可用区
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetAddressVersion", this.InternetAddressVersion);
            this.SetParamSimple(map, prefix + "InternetPayMode", this.InternetPayMode);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
        }
    }
}

