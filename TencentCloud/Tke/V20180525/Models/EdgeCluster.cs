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

    public class EdgeCluster : AbstractModel
    {
        
        /// <summary>
        /// 集群Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Vpc Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 集群pod cidr
        /// </summary>
        [JsonProperty("PodCIDR")]
        public string PodCIDR{ get; set; }

        /// <summary>
        /// 集群 service cidr
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// k8s 版本号
        /// </summary>
        [JsonProperty("K8SVersion")]
        public string K8SVersion{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 集群描述信息
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 边缘集群版本
        /// </summary>
        [JsonProperty("EdgeClusterVersion")]
        public string EdgeClusterVersion{ get; set; }

        /// <summary>
        /// 节点最大Pod数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public long? MaxNodePodNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "PodCIDR", this.PodCIDR);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamSimple(map, prefix + "K8SVersion", this.K8SVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "EdgeClusterVersion", this.EdgeClusterVersion);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
        }
    }
}

