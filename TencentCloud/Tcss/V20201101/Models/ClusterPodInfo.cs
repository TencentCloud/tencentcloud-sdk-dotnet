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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterPodInfo : AbstractModel
    {
        
        /// <summary>
        /// Pod名称.
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Pod状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Pod IP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// 节点内网Ip
        /// </summary>
        [JsonProperty("NodeLanIP")]
        public string NodeLanIP{ get; set; }

        /// <summary>
        /// 所属的工作负载名字
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// 所属工作负载类型
        /// </summary>
        [JsonProperty("WorkloadKind")]
        public string WorkloadKind{ get; set; }

        /// <summary>
        /// 所属集群名字
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 所属集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 所属命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 重启次数
        /// </summary>
        [JsonProperty("Restarts")]
        public ulong? Restarts{ get; set; }

        /// <summary>
        /// 关联的service名字
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 关联的service数量
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// 关联的容器名字
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 关联的容器数量
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// CPU占用率
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// 内存占用量
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Pod标签
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 工作负载标签
        /// </summary>
        [JsonProperty("WorkloadLabels")]
        public string WorkloadLabels{ get; set; }

        /// <summary>
        /// 容器Id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机Id
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// NORMAL：普通节点 SUPER：超级节点
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 计费核数
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "NodeLanIP", this.NodeLanIP);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "WorkloadKind", this.WorkloadKind);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Restarts", this.Restarts);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "WorkloadLabels", this.WorkloadLabels);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
        }
    }
}

