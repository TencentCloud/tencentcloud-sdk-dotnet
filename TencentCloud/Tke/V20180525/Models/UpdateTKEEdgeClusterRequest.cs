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

    public class UpdateTKEEdgeClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 边缘计算集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 边缘计算集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 边缘计算集群描述信息
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 边缘计算集群的pod cidr
        /// </summary>
        [JsonProperty("PodCIDR")]
        public string PodCIDR{ get; set; }

        /// <summary>
        /// 边缘计算集群的service cidr
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// 边缘计算集群公网访问LB信息
        /// </summary>
        [JsonProperty("PublicLB")]
        public EdgeClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// 边缘计算集群内网访问LB信息
        /// </summary>
        [JsonProperty("InternalLB")]
        public EdgeClusterInternalLB InternalLB{ get; set; }

        /// <summary>
        /// 边缘计算集群的CoreDns部署信息
        /// </summary>
        [JsonProperty("CoreDns")]
        public string CoreDns{ get; set; }

        /// <summary>
        /// 边缘计算集群的健康检查多地域部署信息
        /// </summary>
        [JsonProperty("HealthRegion")]
        public string HealthRegion{ get; set; }

        /// <summary>
        /// 边缘计算集群的健康检查部署信息
        /// </summary>
        [JsonProperty("Health")]
        public string Health{ get; set; }

        /// <summary>
        /// 边缘计算集群的GridDaemon部署信息
        /// </summary>
        [JsonProperty("GridDaemon")]
        public string GridDaemon{ get; set; }

        /// <summary>
        /// 边缘集群开启自动升配
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public bool? AutoUpgradeClusterLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "PodCIDR", this.PodCIDR);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamObj(map, prefix + "InternalLB.", this.InternalLB);
            this.SetParamSimple(map, prefix + "CoreDns", this.CoreDns);
            this.SetParamSimple(map, prefix + "HealthRegion", this.HealthRegion);
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "GridDaemon", this.GridDaemon);
            this.SetParamSimple(map, prefix + "AutoUpgradeClusterLevel", this.AutoUpgradeClusterLevel);
        }
    }
}

