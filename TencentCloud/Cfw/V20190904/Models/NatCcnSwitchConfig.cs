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

    public class NatCcnSwitchConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>NAT防火墙实例ID</p>
        /// </summary>
        [JsonProperty("NatInsId")]
        public string NatInsId{ get; set; }

        /// <summary>
        /// <p>云联网实例ID</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>开关接入模式，1:自动接入，2:手动接入</p>
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// <p>引流路由方法，0:多路由表，1:策略路由。自动接入模式仅支持策略路由(1)；手动接入模式支持多路由表(0)和策略路由(1)</p>
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }

        /// <summary>
        /// <p>接入的实例列表</p>
        /// </summary>
        [JsonProperty("AccessInstanceList")]
        public AccessInstanceInfo[] AccessInstanceList{ get; set; }

        /// <summary>
        /// <p>引流VPC的CIDR网段</p>
        /// </summary>
        [JsonProperty("LeadVpcCidr")]
        public string LeadVpcCidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatInsId", this.NatInsId);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
            this.SetParamArrayObj(map, prefix + "AccessInstanceList.", this.AccessInstanceList);
            this.SetParamSimple(map, prefix + "LeadVpcCidr", this.LeadVpcCidr);
        }
    }
}

