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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNetworkInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例内外网ip相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressInfoSet")]
        public AddressInfo[] AddressInfoSet{ get; set; }

        /// <summary>
        /// 网卡ID。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 网卡名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// 主网卡属性。true为主网卡，false为辅助网卡。
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AddressInfoSet.", this.AddressInfoSet);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
        }
    }
}

