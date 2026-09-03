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

    public class ImportTkeClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源池对应的分区名称。</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>EMR 集群 ID（注意：不是 TKE 集群 ID）。</p>
        /// </summary>
        [JsonProperty("EmrClusterId")]
        public string EmrClusterId{ get; set; }

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
        /// <p>容器日志 CLS 日志主题 ID。</p>
        /// </summary>
        [JsonProperty("ContainerLogTopicId")]
        public string ContainerLogTopicId{ get; set; }

        /// <summary>
        /// <p>节点标签键值对（Key-Value 列表），用于将资源池调度限定到具备对应标签的 EMR-TKE 节点。</p>
        /// </summary>
        [JsonProperty("NodeLabels")]
        public KVPair[] NodeLabels{ get; set; }

        /// <summary>
        /// <p>资源池对应的默认分区描述，透传给下游 ResourceManager 用于分区创建。</p>
        /// </summary>
        [JsonProperty("PartitionDescription")]
        public string PartitionDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "EmrClusterId", this.EmrClusterId);
            this.SetParamSimple(map, prefix + "CosBucketId", this.CosBucketId);
            this.SetParamSimple(map, prefix + "PrometheusInstanceId", this.PrometheusInstanceId);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ContainerLogTopicId", this.ContainerLogTopicId);
            this.SetParamArrayObj(map, prefix + "NodeLabels.", this.NodeLabels);
            this.SetParamSimple(map, prefix + "PartitionDescription", this.PartitionDescription);
        }
    }
}

