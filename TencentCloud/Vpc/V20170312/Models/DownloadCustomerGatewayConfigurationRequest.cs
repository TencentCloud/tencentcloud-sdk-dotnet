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

    public class DownloadCustomerGatewayConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// VPN网关实例ID。
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// VPN通道实例ID。形如：vpnx-f49l6u0z。
        /// </summary>
        [JsonProperty("VpnConnectionId")]
        public string VpnConnectionId{ get; set; }

        /// <summary>
        /// 对端网关厂商信息对象，可通过DescribeCustomerGatewayVendors获取。
        /// </summary>
        [JsonProperty("CustomerGatewayVendor")]
        public CustomerGatewayVendor CustomerGatewayVendor{ get; set; }

        /// <summary>
        /// 通道接入设备物理接口名称。
        /// </summary>
        [JsonProperty("InterfaceName")]
        public string InterfaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "VpnConnectionId", this.VpnConnectionId);
            this.SetParamObj(map, prefix + "CustomerGatewayVendor.", this.CustomerGatewayVendor);
            this.SetParamSimple(map, prefix + "InterfaceName", this.InterfaceName);
        }
    }
}

