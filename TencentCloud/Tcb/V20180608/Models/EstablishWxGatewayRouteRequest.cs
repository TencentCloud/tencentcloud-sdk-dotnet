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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EstablishWxGatewayRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关id
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("GatewayRouteName")]
        public string GatewayRouteName{ get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("GatewayRouteAddr")]
        public string GatewayRouteAddr{ get; set; }

        /// <summary>
        /// 协议类型 http/https
        /// </summary>
        [JsonProperty("GatewayRouteProtocol")]
        public string GatewayRouteProtocol{ get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonProperty("GatewayRouteDesc")]
        public string GatewayRouteDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayRouteName", this.GatewayRouteName);
            this.SetParamSimple(map, prefix + "GatewayRouteAddr", this.GatewayRouteAddr);
            this.SetParamSimple(map, prefix + "GatewayRouteProtocol", this.GatewayRouteProtocol);
            this.SetParamSimple(map, prefix + "GatewayRouteDesc", this.GatewayRouteDesc);
        }
    }
}

