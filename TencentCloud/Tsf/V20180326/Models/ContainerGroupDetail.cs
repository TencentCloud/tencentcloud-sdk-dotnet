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

    public class ContainerGroupDetail : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 实例总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 已启动实例总数
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 镜像server
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 镜像名，如/tsf/nginx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reponame")]
        public string Reponame{ get; set; }

        /// <summary>
        /// 镜像版本名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 负载均衡ip
        /// </summary>
        [JsonProperty("LbIp")]
        public string LbIp{ get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// Service ip
        /// </summary>
        [JsonProperty("ClusterIp")]
        public string ClusterIp{ get; set; }

        /// <summary>
        /// NodePort端口，只有公网和NodePort访问方式才有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePort")]
        public long? NodePort{ get; set; }

        /// <summary>
        /// 最大分配的 CPU 核数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 最大分配的内存 MiB 数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// 0:公网 1:集群内访问 2：NodePort
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public ulong? AccessType{ get; set; }

        /// <summary>
        /// 更新方式：0:快速更新 1:滚动更新
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 更新间隔,单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateIvl")]
        public long? UpdateIvl{ get; set; }

        /// <summary>
        /// 端口数组对象
        /// </summary>
        [JsonProperty("ProtocolPorts")]
        public ProtocolPort[] ProtocolPorts{ get; set; }

        /// <summary>
        /// 环境变量数组对象
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// pod错误信息描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 部署组状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// 初始分配的 CPU 核数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 初始分配的内存 MiB 数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 子网id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 部署组资源类型
        /// </summary>
        [JsonProperty("GroupResourceType")]
        public string GroupResourceType{ get; set; }

        /// <summary>
        /// 部署组实例个数
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 部署组更新时间戳
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public long? UpdatedTime{ get; set; }

        /// <summary>
        /// kubernetes滚动更新策略的MaxSurge参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxSurge")]
        public string MaxSurge{ get; set; }

        /// <summary>
        /// kubernetes滚动更新策略的MaxUnavailable参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public string MaxUnavailable{ get; set; }

        /// <summary>
        /// 部署组健康检查设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 允许PlainYamlDeploy
        /// </summary>
        [JsonProperty("AllowPlainYamlDeploy")]
        public bool? AllowPlainYamlDeploy{ get; set; }

        /// <summary>
        /// 是否不等于ServiceConfig
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNotEqualServiceConfig")]
        public bool? IsNotEqualServiceConfig{ get; set; }

        /// <summary>
        /// 仓库名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "Reponame", this.Reponame);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "LbIp", this.LbIp);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "ClusterIp", this.ClusterIp);
            this.SetParamSimple(map, prefix + "NodePort", this.NodePort);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "UpdateIvl", this.UpdateIvl);
            this.SetParamArrayObj(map, prefix + "ProtocolPorts.", this.ProtocolPorts);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "GroupResourceType", this.GroupResourceType);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "MaxSurge", this.MaxSurge);
            this.SetParamSimple(map, prefix + "MaxUnavailable", this.MaxUnavailable);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamSimple(map, prefix + "AllowPlainYamlDeploy", this.AllowPlainYamlDeploy);
            this.SetParamSimple(map, prefix + "IsNotEqualServiceConfig", this.IsNotEqualServiceConfig);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}

