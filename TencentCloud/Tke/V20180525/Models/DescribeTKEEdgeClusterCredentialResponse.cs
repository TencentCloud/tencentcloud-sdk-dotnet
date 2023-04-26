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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTKEEdgeClusterCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群的接入地址信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Addresses")]
        public IPAddress[] Addresses{ get; set; }

        /// <summary>
        /// 集群的认证信息
        /// </summary>
        [JsonProperty("Credential")]
        public ClusterCredential Credential{ get; set; }

        /// <summary>
        /// 集群的公网访问信息
        /// </summary>
        [JsonProperty("PublicLB")]
        public EdgeClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// 集群的内网访问信息
        /// </summary>
        [JsonProperty("InternalLB")]
        public EdgeClusterInternalLB InternalLB{ get; set; }

        /// <summary>
        /// 集群的CoreDns部署信息
        /// </summary>
        [JsonProperty("CoreDns")]
        public string CoreDns{ get; set; }

        /// <summary>
        /// 集群的健康检查多地域部署信息
        /// </summary>
        [JsonProperty("HealthRegion")]
        public string HealthRegion{ get; set; }

        /// <summary>
        /// 集群的健康检查部署信息
        /// </summary>
        [JsonProperty("Health")]
        public string Health{ get; set; }

        /// <summary>
        /// 是否部署GridDaemon以支持headless service
        /// </summary>
        [JsonProperty("GridDaemon")]
        public string GridDaemon{ get; set; }

        /// <summary>
        /// 公网访问kins集群
        /// </summary>
        [JsonProperty("UnitCluster")]
        public string UnitCluster{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Addresses.", this.Addresses);
            this.SetParamObj(map, prefix + "Credential.", this.Credential);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamObj(map, prefix + "InternalLB.", this.InternalLB);
            this.SetParamSimple(map, prefix + "CoreDns", this.CoreDns);
            this.SetParamSimple(map, prefix + "HealthRegion", this.HealthRegion);
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "GridDaemon", this.GridDaemon);
            this.SetParamSimple(map, prefix + "UnitCluster", this.UnitCluster);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

