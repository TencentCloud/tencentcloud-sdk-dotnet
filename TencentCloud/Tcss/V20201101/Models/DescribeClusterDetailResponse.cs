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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名字
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 当前集群扫描任务的进度，100表示扫描完成.
        /// </summary>
        [JsonProperty("ScanTaskProgress")]
        public long? ScanTaskProgress{ get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 运行时组件
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// 集群节点数
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// 集群状态 (Running 运行中 Creating 创建中 Abnormal 异常 )
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 集群运行子状态
        /// </summary>
        [JsonProperty("ClusterSubStatus")]
        public string ClusterSubStatus{ get; set; }

        /// <summary>
        /// 集群类型：为托管集群MANAGED_CLUSTER、独立集群INDEPENDENT_CLUSTER
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 严重风险检查项的数量
        /// </summary>
        [JsonProperty("SeriousRiskCount")]
        public ulong? SeriousRiskCount{ get; set; }

        /// <summary>
        /// 高风险检查项的数量
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public ulong? HighRiskCount{ get; set; }

        /// <summary>
        /// 中风险检查项的数量
        /// </summary>
        [JsonProperty("MiddleRiskCount")]
        public ulong? MiddleRiskCount{ get; set; }

        /// <summary>
        /// 提示风险检查项的数量
        /// </summary>
        [JsonProperty("HintRiskCount")]
        public ulong? HintRiskCount{ get; set; }

        /// <summary>
        /// 检查任务的状态
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 防御容器状态
        /// </summary>
        [JsonProperty("DefenderStatus")]
        public string DefenderStatus{ get; set; }

        /// <summary>
        /// 扫描任务创建时间
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// 网络类型.PublicNetwork为公网类型,VPCNetwork为VPC网络
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// API Server地址
        /// </summary>
        [JsonProperty("ApiServerAddress")]
        public string ApiServerAddress{ get; set; }

        /// <summary>
        /// 节点数
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// 命名空间数
        /// </summary>
        [JsonProperty("NamespaceCount")]
        public ulong? NamespaceCount{ get; set; }

        /// <summary>
        /// 工作负载数
        /// </summary>
        [JsonProperty("WorkloadCount")]
        public ulong? WorkloadCount{ get; set; }

        /// <summary>
        /// Pod数量
        /// </summary>
        [JsonProperty("PodCount")]
        public ulong? PodCount{ get; set; }

        /// <summary>
        /// Service数量
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// Ingress数量
        /// </summary>
        [JsonProperty("IngressCount")]
        public ulong? IngressCount{ get; set; }

        /// <summary>
        /// 主节点的ip列表
        /// </summary>
        [JsonProperty("MasterIps")]
        public string MasterIps{ get; set; }

        /// <summary>
        /// 所有者名称
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

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
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ScanTaskProgress", this.ScanTaskProgress);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterSubStatus", this.ClusterSubStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SeriousRiskCount", this.SeriousRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MiddleRiskCount", this.MiddleRiskCount);
            this.SetParamSimple(map, prefix + "HintRiskCount", this.HintRiskCount);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "DefenderStatus", this.DefenderStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ApiServerAddress", this.ApiServerAddress);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "NamespaceCount", this.NamespaceCount);
            this.SetParamSimple(map, prefix + "WorkloadCount", this.WorkloadCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "IngressCount", this.IngressCount);
            this.SetParamSimple(map, prefix + "MasterIps", this.MasterIps);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

