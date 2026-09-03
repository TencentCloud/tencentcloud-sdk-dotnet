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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportExternalClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源池对应的分区名称。</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>集群类型。TKE：直接导入裸 TKE 集群，ClusterId 填 TKE 集群 ID（如 cls-xxxxxxxx）；EMR：通过 EMR 集群导入，ClusterId 填 EMR 集群 ID（如 emr-xxxxxxxx）。</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>集群 ID。ClusterType=TKE 时填 TKE 集群 ID（如 cls-xxxxxxxx）；ClusterType=EMR 时填 EMR 集群 ID（如 emr-xxxxxxxx）。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>COS Bucket 名称（含 AppId 后缀），例如 my-bucket-1250000000。</p>
        /// </summary>
        [JsonProperty("CosBucketId")]
        public string CosBucketId{ get; set; }

        /// <summary>
        /// <p>Prometheus 托管实例 ID，例如 prom-xxxxxxxx。</p>
        /// </summary>
        [JsonProperty("PrometheusInstanceId")]
        public string PrometheusInstanceId{ get; set; }

        /// <summary>
        /// <p>负载均衡实例 ID，例如 lb-xxxxxxxx。</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>节点标签键值对（Key-Value 列表），用于将资源池调度限定到具备对应标签的节点。</p>
        /// </summary>
        [JsonProperty("NodeLabels")]
        public KVPair[] NodeLabels{ get; set; }

        /// <summary>
        /// <p>资源池对应的默认分区描述，透传给下游 ResourceManager 用于分区创建。</p>
        /// </summary>
        [JsonProperty("PartitionDescription")]
        public string PartitionDescription{ get; set; }

        /// <summary>
        /// <p>目标账号 AppId（跨账号导入时填写，不填则使用当前账号）。TargetAppId 和 TargetUin 必须同时填写或同时不填。</p>
        /// </summary>
        [JsonProperty("TargetAppId")]
        public long? TargetAppId{ get; set; }

        /// <summary>
        /// <p>目标账号 UIN（跨账号导入时填写，不填则使用当前账号）。TargetAppId 和 TargetUin 必须同时填写或同时不填。</p>
        /// </summary>
        [JsonProperty("TargetUin")]
        public string TargetUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "CosBucketId", this.CosBucketId);
            this.SetParamSimple(map, prefix + "PrometheusInstanceId", this.PrometheusInstanceId);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArrayObj(map, prefix + "NodeLabels.", this.NodeLabels);
            this.SetParamSimple(map, prefix + "PartitionDescription", this.PartitionDescription);
            this.SetParamSimple(map, prefix + "TargetAppId", this.TargetAppId);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
        }
    }
}

