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

    public class DescribeTkeClusterImportInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>分区名称。</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>EMR 集群 ID。</p>
        /// </summary>
        [JsonProperty("EmrClusterId")]
        public string EmrClusterId{ get; set; }

        /// <summary>
        /// <p>COS Bucket 名称。</p>
        /// </summary>
        [JsonProperty("CosBucketId")]
        public string CosBucketId{ get; set; }

        /// <summary>
        /// <p>Prometheus 托管实例 ID。</p>
        /// </summary>
        [JsonProperty("PrometheusInstanceId")]
        public string PrometheusInstanceId{ get; set; }

        /// <summary>
        /// <p>Prometheus 托管实例名称；查询失败或未命中返回空字符串。</p>
        /// </summary>
        [JsonProperty("PrometheusInstanceName")]
        public string PrometheusInstanceName{ get; set; }

        /// <summary>
        /// <p>负载均衡实例 ID。</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>负载均衡实例名称；查询失败或未命中返回空字符串。</p>
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// <p>容器日志 CLS 日志主题 ID。</p>
        /// </summary>
        [JsonProperty("ContainerLogTopicId")]
        public string ContainerLogTopicId{ get; set; }

        /// <summary>
        /// <p>容器日志 CLS 日志主题名称；查询失败或未命中返回空字符串。</p>
        /// </summary>
        [JsonProperty("ContainerLogTopicName")]
        public string ContainerLogTopicName{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "EmrClusterId", this.EmrClusterId);
            this.SetParamSimple(map, prefix + "CosBucketId", this.CosBucketId);
            this.SetParamSimple(map, prefix + "PrometheusInstanceId", this.PrometheusInstanceId);
            this.SetParamSimple(map, prefix + "PrometheusInstanceName", this.PrometheusInstanceName);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "ContainerLogTopicId", this.ContainerLogTopicId);
            this.SetParamSimple(map, prefix + "ContainerLogTopicName", this.ContainerLogTopicName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

