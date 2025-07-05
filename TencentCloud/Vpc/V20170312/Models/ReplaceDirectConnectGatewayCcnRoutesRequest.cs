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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceDirectConnectGatewayCcnRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// 专线网关ID，形如：dcg-prpqlmg1
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// 需要连通的IDC网段列表
        /// </summary>
        [JsonProperty("Routes")]
        public DirectConnectGatewayCcnRoute[] Routes{ get; set; }

        /// <summary>
        /// 地址类型，支持：IPv4、IPv6。默认IPv4。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamArrayObj(map, prefix + "Routes.", this.Routes);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
        }
    }
}

