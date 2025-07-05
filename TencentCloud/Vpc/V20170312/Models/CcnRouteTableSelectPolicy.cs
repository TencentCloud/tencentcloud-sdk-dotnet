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

    public class CcnRouteTableSelectPolicy : AbstractModel
    {
        
        /// <summary>
        /// 实例类型：
        /// 私有网络: `VPC`
        /// 专线网关: `DIRECTCONNECT`
        /// 黑石私有网络: `BMVPC`
        /// EDGE设备: `EDGE`
        /// EDGE隧道: `EDGE_TUNNEL`
        /// EDGE网关: `EDGE_VPNGW`
        /// VPN网关：`VPNGW`
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 源端CIDR。
        /// </summary>
        [JsonProperty("SourceCidrBlock")]
        public string SourceCidrBlock{ get; set; }

        /// <summary>
        /// 路由表ID。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 路由表备注。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SourceCidrBlock", this.SourceCidrBlock);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

