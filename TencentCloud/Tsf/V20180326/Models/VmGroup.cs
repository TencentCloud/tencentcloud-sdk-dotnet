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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VmGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>部署组ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>部署组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>部署组状态</p>
        /// </summary>
        [JsonProperty("GroupStatus")]
        public string GroupStatus{ get; set; }

        /// <summary>
        /// <p>程序包ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// <p>程序包名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// <p>程序包版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>命名空间ID</p>
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// <p>命名空间名称</p>
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>应用名称</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>部署组机器数目</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>部署组运行中机器数目</p>
        /// </summary>
        [JsonProperty("RunInstanceCount")]
        public long? RunInstanceCount{ get; set; }

        /// <summary>
        /// <p>部署组启动参数信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupParameters")]
        public string StartupParameters{ get; set; }

        /// <summary>
        /// <p>部署组创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>部署组更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>部署组停止机器数目</p>
        /// </summary>
        [JsonProperty("OffInstanceCount")]
        public long? OffInstanceCount{ get; set; }

        /// <summary>
        /// <p>部署组描述信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupDesc")]
        public string GroupDesc{ get; set; }

        /// <summary>
        /// <p>微服务类型</p>
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// <p>应用类型</p>
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// <p>部署组资源类型</p>
        /// </summary>
        [JsonProperty("GroupResourceType")]
        public string GroupResourceType{ get; set; }

        /// <summary>
        /// <p>部署组更新时间戳</p>
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public long? UpdatedTime{ get; set; }

        /// <summary>
        /// <p>部署应用描述信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployDesc")]
        public string DeployDesc{ get; set; }

        /// <summary>
        /// <p>滚动发布的更新方式</p>
        /// </summary>
        [JsonProperty("UpdateType")]
        public ulong? UpdateType{ get; set; }

        /// <summary>
        /// <p>发布是否启用beta批次</p>
        /// </summary>
        [JsonProperty("DeployBetaEnable")]
        public bool? DeployBetaEnable{ get; set; }

        /// <summary>
        /// <p>滚动发布的批次比例列表</p>
        /// </summary>
        [JsonProperty("DeployBatch")]
        public float?[] DeployBatch{ get; set; }

        /// <summary>
        /// <p>滚动发布的批次执行方式</p>
        /// </summary>
        [JsonProperty("DeployExeMode")]
        public string DeployExeMode{ get; set; }

        /// <summary>
        /// <p>滚动发布的每个批次的等待时间</p>
        /// </summary>
        [JsonProperty("DeployWaitTime")]
        public ulong? DeployWaitTime{ get; set; }

        /// <summary>
        /// <p>是否开启了健康检查</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>健康检查配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// <p>程序包类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// <p>启动脚本 base64编码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartScript")]
        public string StartScript{ get; set; }

        /// <summary>
        /// <p>停止脚本 base64编码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StopScript")]
        public string StopScript{ get; set; }

        /// <summary>
        /// <p>部署组备注</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>javaagent信息</p>
        /// </summary>
        [JsonProperty("AgentProfileList")]
        public AgentProfile[] AgentProfileList{ get; set; }

        /// <summary>
        /// <p>预热属性配置</p>
        /// </summary>
        [JsonProperty("WarmupSetting")]
        public WarmupSetting WarmupSetting{ get; set; }

        /// <summary>
        /// <p>Envoy网关配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayConfig")]
        public GatewayConfig GatewayConfig{ get; set; }

        /// <summary>
        /// <p>批次是否开启健康检查</p>
        /// </summary>
        [JsonProperty("EnableBatchHealthCheck")]
        public bool? EnableBatchHealthCheck{ get; set; }

        /// <summary>
        /// <p>是否开启cgroup控制内存cpu</p>
        /// </summary>
        [JsonProperty("FilebeatCgroupEnable")]
        public bool? FilebeatCgroupEnable{ get; set; }

        /// <summary>
        /// <p>filebeat使用cpu上限</p>
        /// </summary>
        [JsonProperty("FilebeatMaxCpu")]
        public float? FilebeatMaxCpu{ get; set; }

        /// <summary>
        /// <p>filebeat使用内存上限</p>
        /// </summary>
        [JsonProperty("FilebeatMaxMem")]
        public long? FilebeatMaxMem{ get; set; }

        /// <summary>
        /// <p>仓库ID</p>
        /// </summary>
        [JsonProperty("RepositoryId")]
        public string RepositoryId{ get; set; }

        /// <summary>
        /// <p>仓库名称</p>
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }

        /// <summary>
        /// <p>仓库类型</p>
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// <p>是否自动重启</p>
        /// </summary>
        [JsonProperty("LivenessAutoRestart")]
        public bool? LivenessAutoRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RunInstanceCount", this.RunInstanceCount);
            this.SetParamSimple(map, prefix + "StartupParameters", this.StartupParameters);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OffInstanceCount", this.OffInstanceCount);
            this.SetParamSimple(map, prefix + "GroupDesc", this.GroupDesc);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "GroupResourceType", this.GroupResourceType);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "DeployDesc", this.DeployDesc);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "DeployBetaEnable", this.DeployBetaEnable);
            this.SetParamArraySimple(map, prefix + "DeployBatch.", this.DeployBatch);
            this.SetParamSimple(map, prefix + "DeployExeMode", this.DeployExeMode);
            this.SetParamSimple(map, prefix + "DeployWaitTime", this.DeployWaitTime);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "StartScript", this.StartScript);
            this.SetParamSimple(map, prefix + "StopScript", this.StopScript);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamArrayObj(map, prefix + "AgentProfileList.", this.AgentProfileList);
            this.SetParamObj(map, prefix + "WarmupSetting.", this.WarmupSetting);
            this.SetParamObj(map, prefix + "GatewayConfig.", this.GatewayConfig);
            this.SetParamSimple(map, prefix + "EnableBatchHealthCheck", this.EnableBatchHealthCheck);
            this.SetParamSimple(map, prefix + "FilebeatCgroupEnable", this.FilebeatCgroupEnable);
            this.SetParamSimple(map, prefix + "FilebeatMaxCpu", this.FilebeatMaxCpu);
            this.SetParamSimple(map, prefix + "FilebeatMaxMem", this.FilebeatMaxMem);
            this.SetParamSimple(map, prefix + "RepositoryId", this.RepositoryId);
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "LivenessAutoRestart", this.LivenessAutoRestart);
        }
    }
}

