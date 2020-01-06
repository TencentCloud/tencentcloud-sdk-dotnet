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

    public class ClusterCIDRSettings : AbstractModel
    {
        
        /// <summary>
        /// 用于分配集群容器和服务 IP 的 CIDR，不得与 VPC CIDR 冲突，也不得与同 VPC 内其他集群 CIDR 冲突。且网段范围必须在内网网段内，例如:10.1.0.0/14, 192.168.0.1/18,172.16.0.0/16。
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 是否忽略 ClusterCIDR 冲突错误, 默认不忽略
        /// </summary>
        [JsonProperty("IgnoreClusterCIDRConflict")]
        public bool? IgnoreClusterCIDRConflict{ get; set; }

        /// <summary>
        /// 集群中每个Node上最大的Pod数量。取值范围4～256。不为2的幂值时会向上取最接近的2的幂值。
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public ulong? MaxNodePodNum{ get; set; }

        /// <summary>
        /// 集群最大的service数量。取值范围32～32768，不为2的幂值时会向上取最接近的2的幂值。
        /// </summary>
        [JsonProperty("MaxClusterServiceNum")]
        public ulong? MaxClusterServiceNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "IgnoreClusterCIDRConflict", this.IgnoreClusterCIDRConflict);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamSimple(map, prefix + "MaxClusterServiceNum", this.MaxClusterServiceNum);
        }
    }
}

