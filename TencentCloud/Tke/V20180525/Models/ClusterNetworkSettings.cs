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

    public class ClusterNetworkSettings : AbstractModel
    {
        
        /// <summary>
        /// 用于分配集群容器和服务 IP 的 CIDR，不得与 VPC CIDR 冲突，也不得与同 VPC 内其他集群 CIDR 冲突
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 是否忽略 ClusterCIDR 冲突错误, 默认不忽略
        /// </summary>
        [JsonProperty("IgnoreClusterCIDRConflict")]
        public bool? IgnoreClusterCIDRConflict{ get; set; }

        /// <summary>
        /// 集群中每个Node上最大的Pod数量(默认为256)
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public ulong? MaxNodePodNum{ get; set; }

        /// <summary>
        /// 集群最大的service数量(默认为256)
        /// </summary>
        [JsonProperty("MaxClusterServiceNum")]
        public ulong? MaxClusterServiceNum{ get; set; }

        /// <summary>
        /// 是否启用IPVS(默认不开启)
        /// </summary>
        [JsonProperty("Ipvs")]
        public bool? Ipvs{ get; set; }

        /// <summary>
        /// 集群的VPCID（如果创建空集群，为必传值，否则自动设置为和集群的节点保持一致）
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网络插件是否启用CNI(默认开启)
        /// </summary>
        [JsonProperty("Cni")]
        public bool? Cni{ get; set; }

        /// <summary>
        /// service的网络模式，当前参数只适用于ipvs+bpf模式
        /// </summary>
        [JsonProperty("KubeProxyMode")]
        public string KubeProxyMode{ get; set; }

        /// <summary>
        /// 用于分配service的IP range，不得与 VPC CIDR 冲突，也不得与同 VPC 内其他集群 CIDR 冲突
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// 集群关联的容器子网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// 是否忽略 ServiceCIDR 冲突错误, 仅在 VPC-CNI 模式生效，默认不忽略
        /// </summary>
        [JsonProperty("IgnoreServiceCIDRConflict")]
        public bool? IgnoreServiceCIDRConflict{ get; set; }

        /// <summary>
        /// 集群VPC-CNI模式是否为非双栈集群，默认false，非双栈。
        /// </summary>
        [JsonProperty("IsDualStack")]
        public bool? IsDualStack{ get; set; }

        /// <summary>
        /// 用于分配service的IP range，由系统自动分配
        /// </summary>
        [JsonProperty("Ipv6ServiceCIDR")]
        public string Ipv6ServiceCIDR{ get; set; }

        /// <summary>
        /// 集群Cilium Mode配置
        /// - clusterIP
        /// </summary>
        [JsonProperty("CiliumMode")]
        public string CiliumMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "IgnoreClusterCIDRConflict", this.IgnoreClusterCIDRConflict);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamSimple(map, prefix + "MaxClusterServiceNum", this.MaxClusterServiceNum);
            this.SetParamSimple(map, prefix + "Ipvs", this.Ipvs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Cni", this.Cni);
            this.SetParamSimple(map, prefix + "KubeProxyMode", this.KubeProxyMode);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "IgnoreServiceCIDRConflict", this.IgnoreServiceCIDRConflict);
            this.SetParamSimple(map, prefix + "IsDualStack", this.IsDualStack);
            this.SetParamSimple(map, prefix + "Ipv6ServiceCIDR", this.Ipv6ServiceCIDR);
            this.SetParamSimple(map, prefix + "CiliumMode", this.CiliumMode);
        }
    }
}

