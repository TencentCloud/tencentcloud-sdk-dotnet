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

    public class DisableGatewayFlowMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关实例ID，目前我们支持的网关实例类型有，
        /// 专线网关实例ID，形如，`dcg-ltjahce6`；
        /// Nat网关实例ID，形如，`nat-ltjahce6`；
        /// VPN网关实例ID，形如，`vpn-ltjahce6`。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
        }
    }
}

