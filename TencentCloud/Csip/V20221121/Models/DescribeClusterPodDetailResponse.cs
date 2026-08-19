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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterPodDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Pod 唯一 ID</p>
        /// </summary>
        [JsonProperty("UniqueID")]
        public string UniqueID{ get; set; }

        /// <summary>
        /// <p>主账号 AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Pod 名称</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>Pod IP 地址</p>
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// <p>Pod 运行状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>Pod Labels 列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public AssetTag[] Labels{ get; set; }

        /// <summary>
        /// <p>Pod 启动时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>启动时间（秒）</p>
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// <p>Pod 重启次数</p>
        /// </summary>
        [JsonProperty("RestartCount")]
        public ulong? RestartCount{ get; set; }

        /// <summary>
        /// <p>所属集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>所属集群 ID</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>所属集群类型</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>所属集群运行状态</p>
        /// </summary>
        [JsonProperty("ClusterRunStatus")]
        public string ClusterRunStatus{ get; set; }

        /// <summary>
        /// <p>所属命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>所在节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>所在节点 ID</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>所属 Workload 名称</p>
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// <p>所属 Workload 类型</p>
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// <p>严重风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>严重告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>节点内网 IP</p>
        /// </summary>
        [JsonProperty("NodeInternalIP")]
        public string NodeInternalIP{ get; set; }

        /// <summary>
        /// <p>节点外网 IP</p>
        /// </summary>
        [JsonProperty("NodeExternalIP")]
        public string NodeExternalIP{ get; set; }

        /// <summary>
        /// <p>关联容器数量</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>关联服务数量</p>
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// <p>地域中文名</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>地域英文名</p>
        /// </summary>
        [JsonProperty("RegionNameEn")]
        public string RegionNameEn{ get; set; }

        /// <summary>
        /// <p>告警数量</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "UniqueID", this.UniqueID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterRunStatus", this.ClusterRunStatus);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NodeInternalIP", this.NodeInternalIP);
            this.SetParamSimple(map, prefix + "NodeExternalIP", this.NodeExternalIP);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

