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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContainerGroupDeploy : AbstractModel
    {
        
        /// <summary>
        /// 部署组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

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
        /// 业务容器初始分配的 CPU 核数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 业务容器最大分配的 CPU 核数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 业务容器初始分配的内存 MiB 数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 业务容器最大分配的内存 MiB 数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// 0:公网 1:集群内访问 2：NodePort
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 端口映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolPorts")]
        public ProtocolPort[] ProtocolPorts{ get; set; }

        /// <summary>
        /// 更新方式：0:快速更新 1:滚动更新
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// jvm参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 子网id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// agent容器初始分配的 CPU 核数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentCpuRequest")]
        public string AgentCpuRequest{ get; set; }

        /// <summary>
        /// agent容器最大分配的 CPU 核数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentCpuLimit")]
        public string AgentCpuLimit{ get; set; }

        /// <summary>
        /// agent容器初始分配的内存 MiB 数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentMemRequest")]
        public string AgentMemRequest{ get; set; }

        /// <summary>
        /// agent容器最大分配的内存 MiB 数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentMemLimit")]
        public string AgentMemLimit{ get; set; }

        /// <summary>
        /// istioproxy容器初始分配的 CPU 核数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IstioCpuRequest")]
        public string IstioCpuRequest{ get; set; }

        /// <summary>
        /// istioproxy容器最大分配的 CPU 核数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IstioCpuLimit")]
        public string IstioCpuLimit{ get; set; }

        /// <summary>
        /// istioproxy容器初始分配的内存 MiB 数，对应 K8S request
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IstioMemRequest")]
        public string IstioMemRequest{ get; set; }

        /// <summary>
        /// istioproxy容器最大分配的内存 MiB 数，对应 K8S limit
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IstioMemLimit")]
        public string IstioMemLimit{ get; set; }

        /// <summary>
        /// 部署组的环境变量数组，这里没有展示 tsf 使用的环境变量，只展示了用户设置的环境变量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 健康检查配置信息，若不指定该参数，则默认不设置健康检查。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 是否部署Agent容器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployAgent")]
        public bool? DeployAgent{ get; set; }

        /// <summary>
        /// 部署组备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 是否创建 k8s service
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisableService")]
        public bool? DisableService{ get; set; }

        /// <summary>
        /// service 是否为 headless 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadlessService")]
        public bool? HeadlessService{ get; set; }

        /// <summary>
        /// TcrRepoInfo值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcrRepoInfo")]
        public TcrRepoInfo TcrRepoInfo{ get; set; }

        /// <summary>
        /// 数据卷信息，list
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeInfos")]
        public VolumeInfo[] VolumeInfos{ get; set; }

        /// <summary>
        /// 数据卷挂载信息，list
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeMountInfos")]
        public VolumeMountInfo[] VolumeMountInfos{ get; set; }

        /// <summary>
        /// KubeInjectEnable值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KubeInjectEnable")]
        public bool? KubeInjectEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "Reponame", this.Reponame);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "ProtocolPorts.", this.ProtocolPorts);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "UpdateIvl", this.UpdateIvl);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "AgentCpuRequest", this.AgentCpuRequest);
            this.SetParamSimple(map, prefix + "AgentCpuLimit", this.AgentCpuLimit);
            this.SetParamSimple(map, prefix + "AgentMemRequest", this.AgentMemRequest);
            this.SetParamSimple(map, prefix + "AgentMemLimit", this.AgentMemLimit);
            this.SetParamSimple(map, prefix + "IstioCpuRequest", this.IstioCpuRequest);
            this.SetParamSimple(map, prefix + "IstioCpuLimit", this.IstioCpuLimit);
            this.SetParamSimple(map, prefix + "IstioMemRequest", this.IstioMemRequest);
            this.SetParamSimple(map, prefix + "IstioMemLimit", this.IstioMemLimit);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamSimple(map, prefix + "DeployAgent", this.DeployAgent);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "DisableService", this.DisableService);
            this.SetParamSimple(map, prefix + "HeadlessService", this.HeadlessService);
            this.SetParamObj(map, prefix + "TcrRepoInfo.", this.TcrRepoInfo);
            this.SetParamArrayObj(map, prefix + "VolumeInfos.", this.VolumeInfos);
            this.SetParamArrayObj(map, prefix + "VolumeMountInfos.", this.VolumeMountInfos);
            this.SetParamSimple(map, prefix + "KubeInjectEnable", this.KubeInjectEnable);
        }
    }
}

