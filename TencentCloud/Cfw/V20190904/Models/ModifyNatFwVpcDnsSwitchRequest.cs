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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNatFwVpcDnsSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// nat 防火墙 id
        /// </summary>
        [JsonProperty("NatFwInsId")]
        public string NatFwInsId{ get; set; }

        /// <summary>
        /// DNS 开关切换列表
        /// </summary>
        [JsonProperty("DnsVpcSwitchLst")]
        public DnsVpcSwitch[] DnsVpcSwitchLst{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatFwInsId", this.NatFwInsId);
            this.SetParamArrayObj(map, prefix + "DnsVpcSwitchLst.", this.DnsVpcSwitchLst);
        }
    }
}

