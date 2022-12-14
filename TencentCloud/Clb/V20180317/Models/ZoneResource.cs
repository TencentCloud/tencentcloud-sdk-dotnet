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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResource : AbstractModel
    {
        
        /// <summary>
        /// 主可用区，如"ap-guangzhou-1"。
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// 资源列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceSet")]
        public Resource[] ResourceSet{ get; set; }

        /// <summary>
        /// 备可用区，如"ap-guangzhou-2"，单可用区时，备可用区为null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// IP版本，如IPv4，IPv6，IPv6_Nat。
        /// </summary>
        [JsonProperty("IPVersion")]
        public string IPVersion{ get; set; }

        /// <summary>
        /// 可用区所属地域，如：ap-guangzhou
        /// </summary>
        [JsonProperty("ZoneRegion")]
        public string ZoneRegion{ get; set; }

        /// <summary>
        /// 可用区是否是LocalZone可用区，如：false
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// 可用区资源的类型，SHARED表示共享资源，EXCLUSIVE表示独占资源。
        /// </summary>
        [JsonProperty("ZoneResourceType")]
        public string ZoneResourceType{ get; set; }

        /// <summary>
        /// 可用区是否是EdgeZone可用区，如：false
        /// </summary>
        [JsonProperty("EdgeZone")]
        public bool? EdgeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "ResourceSet.", this.ResourceSet);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "IPVersion", this.IPVersion);
            this.SetParamSimple(map, prefix + "ZoneRegion", this.ZoneRegion);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "ZoneResourceType", this.ZoneResourceType);
            this.SetParamSimple(map, prefix + "EdgeZone", this.EdgeZone);
        }
    }
}

