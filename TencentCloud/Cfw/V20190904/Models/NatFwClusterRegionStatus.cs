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

    public class NatFwClusterRegionStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>NAT网关ID</p>
        /// </summary>
        [JsonProperty("NatInsId")]
        public string NatInsId{ get; set; }

        /// <summary>
        /// <p>云联网ID</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>地域，如 ap-guangzhou</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>地域集群状态，取值：<br>NotDeployed-未部署集群，<br>Deployed-已部署集群但未创建引流网络，<br>DeployedCustomOnly-已部署集群但内网段被覆盖，无法自动选择引流网段，需自定义设置引流网段<br>Auto-已创建引流网络(自动分配CIDR)，<br>Custom-已创建引流网络(自定义CIDR)</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>引流网络 CIDR，仅当 Status 为 Auto 或 Custom 时有值</p>
        /// </summary>
        [JsonProperty("Cidr")]
        public string Cidr{ get; set; }

        /// <summary>
        /// <p>引流路由方法，0-多路由表模式，1-策略路由模式</p>
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatInsId", this.NatInsId);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cidr", this.Cidr);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
        }
    }
}

