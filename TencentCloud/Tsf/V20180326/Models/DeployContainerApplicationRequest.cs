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

    public class DeployContainerApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 可观测配置
        /// </summary>
        [JsonProperty("ObservabilityConfig")]
        public ContainerGroupObservabilityConfig ObservabilityConfig{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 部署组ID，分组唯一标识
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 业务容器的环境变量参数
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 业务容器的挂载信息
        /// </summary>
        [JsonProperty("VolumeMountInfoList")]
        public VolumeMountInfo[] VolumeMountInfoList{ get; set; }

        /// <summary>
        /// 业务主容器生命周期钩子列表
        /// </summary>
        [JsonProperty("LifeCycleHookList")]
        public LifeCycleHook[] LifeCycleHookList{ get; set; }

        /// <summary>
        /// 附属容器列表
        /// </summary>
        [JsonProperty("AdditionalContainerList")]
        public ContainerInfo[] AdditionalContainerList{ get; set; }

        /// <summary>
        /// 容器卷信息
        /// </summary>
        [JsonProperty("VolumeInfoList")]
        public VolumeInfo[] VolumeInfoList{ get; set; }

        /// <summary>
        /// Service访问配置列表
        /// </summary>
        [JsonProperty("ServiceSettingList")]
        public ServiceSetting[] ServiceSettingList{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 部署组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 容器类型
        /// </summary>
        [JsonProperty("ContainerKind")]
        public string ContainerKind{ get; set; }

        /// <summary>
        /// 业务容器的 镜像Server ccr.ccs.tencentyun.com
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 业务容器的镜像名
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// TCR仓库信息
        /// </summary>
        [JsonProperty("TcrRepoInfo")]
        public TcrRepoInfo TcrRepoInfo{ get; set; }

        /// <summary>
        /// 容器访问凭证名称
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 业务容器的镜像版本号
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 健康检查
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 业务容器的 cpu  request
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 业务容器的 cpu limit
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 业务容器的 mem request
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 业务容器的 mem limit
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// 业务容器的 jvm 参数
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 是否为初始化容器 业务主容器不能为初始化容
        /// </summary>
        [JsonProperty("InitContainerEnable")]
        public bool? InitContainerEnable{ get; set; }

        /// <summary>
        /// 业务主容器是否为特权容器
        /// </summary>
        [JsonProperty("PrivilegeContainerEnable")]
        public bool? PrivilegeContainerEnable{ get; set; }

        /// <summary>
        /// 业务主容器运行命令(转base64)
        /// </summary>
        [JsonProperty("RunCommand")]
        public string RunCommand{ get; set; }

        /// <summary>
        /// 业务主容器运行参数(转base64)
        /// </summary>
        [JsonProperty("RunArg")]
        public string RunArg{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 调度策略
        /// </summary>
        [JsonProperty("SchedulingStrategy")]
        public SchedulingStrategy SchedulingStrategy{ get; set; }

        /// <summary>
        /// 重启策略
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }

        /// <summary>
        /// 服务治理配置
        /// </summary>
        [JsonProperty("ServiceSpecEncode")]
        public string ServiceSpecEncode{ get; set; }

        /// <summary>
        /// istio容器的 mem Request
        /// </summary>
        [JsonProperty("IstioMemRequest")]
        public string IstioMemRequest{ get; set; }

        /// <summary>
        ///  istio容器的 cpu Request
        /// </summary>
        [JsonProperty("IstioCpuRequest")]
        public string IstioCpuRequest{ get; set; }

        /// <summary>
        /// istio容器的 mem Limit
        /// </summary>
        [JsonProperty("IstioMemLimit")]
        public string IstioMemLimit{ get; set; }

        /// <summary>
        /// istio容器的 cpu Limit
        /// </summary>
        [JsonProperty("IstioCpuLimit")]
        public string IstioCpuLimit{ get; set; }

        /// <summary>
        /// 服务治理配置
        /// </summary>
        [JsonProperty("ServiceGovernanceConfig")]
        public ContainerGroupServiceGovernanceConfig ServiceGovernanceConfig{ get; set; }

        /// <summary>
        /// agent容器的 mem Request
        /// </summary>
        [JsonProperty("AgentMemRequest")]
        public string AgentMemRequest{ get; set; }

        /// <summary>
        /// agent容器的 cpu Request
        /// </summary>
        [JsonProperty("AgentCpuRequest")]
        public string AgentCpuRequest{ get; set; }

        /// <summary>
        /// agent容器的 mem Limit
        /// </summary>
        [JsonProperty("AgentMemLimit")]
        public string AgentMemLimit{ get; set; }

        /// <summary>
        /// agent容器的 cpu Limit
        /// </summary>
        [JsonProperty("AgentCpuLimit")]
        public string AgentCpuLimit{ get; set; }

        /// <summary>
        /// 发布策略(0表示快速更新，1表示滚动更新。默认值为0)
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 更新间隔,单位秒
        /// </summary>
        [JsonProperty("UpdateIvl")]
        public long? UpdateIvl{ get; set; }

        /// <summary>
        /// 对应更新策略和策略配置参数
        /// </summary>
        [JsonProperty("MaxSurge")]
        public string MaxSurge{ get; set; }

        /// <summary>
        /// 对应更新策略和策略配置参数
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public string MaxUnavailable{ get; set; }

        /// <summary>
        /// 预热参数配置
        /// </summary>
        [JsonProperty("WarmupSetting")]
        public WarmupSetting WarmupSetting{ get; set; }

        /// <summary>
        /// 配置模版ID
        /// </summary>
        [JsonProperty("ConfigTemplateId")]
        public string ConfigTemplateId{ get; set; }

        /// <summary>
        /// 配置模版Version
        /// </summary>
        [JsonProperty("ConfigTemplateVersion")]
        public long? ConfigTemplateVersion{ get; set; }

        /// <summary>
        /// 是否清除数据卷信息
        /// </summary>
        [JsonProperty("VolumeClean")]
        public bool? VolumeClean{ get; set; }

        /// <summary>
        /// 命名空间Id
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 是否部署agent容器
        /// </summary>
        [JsonProperty("DeployAgent")]
        public bool? DeployAgent{ get; set; }

        /// <summary>
        /// javaagent信息: SERVICE_AGENT/OT_AGENT
        /// </summary>
        [JsonProperty("AgentProfileList")]
        public AgentProfile[] AgentProfileList{ get; set; }

        /// <summary>
        /// 是否清除Service信息
        /// </summary>
        [JsonProperty("ServiceClean")]
        public bool? ServiceClean{ get; set; }

        /// <summary>
        /// 是否清除Env信息
        /// </summary>
        [JsonProperty("EnvClean")]
        public bool? EnvClean{ get; set; }

        /// <summary>
        /// 本次部署的描述信息
        /// </summary>
        [JsonProperty("DeployDesc")]
        public string DeployDesc{ get; set; }

        /// <summary>
        /// k8s命名空间名称
        /// </summary>
        [JsonProperty("K8sNamespaceName")]
        public string K8sNamespaceName{ get; set; }

        /// <summary>
        /// 是否启用静态IP
        /// </summary>
        [JsonProperty("StaticIpEnabled")]
        public bool? StaticIpEnabled{ get; set; }

        /// <summary>
        /// 启动策略[OrderedReady/Parallel]
        /// </summary>
        [JsonProperty("PodManagementPolicyType")]
        public string PodManagementPolicyType{ get; set; }

        /// <summary>
        /// 滚动更新分区序号
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamObj(map, prefix + "ObservabilityConfig.", this.ObservabilityConfig);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "VolumeMountInfoList.", this.VolumeMountInfoList);
            this.SetParamArrayObj(map, prefix + "LifeCycleHookList.", this.LifeCycleHookList);
            this.SetParamArrayObj(map, prefix + "AdditionalContainerList.", this.AdditionalContainerList);
            this.SetParamArrayObj(map, prefix + "VolumeInfoList.", this.VolumeInfoList);
            this.SetParamArrayObj(map, prefix + "ServiceSettingList.", this.ServiceSettingList);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ContainerKind", this.ContainerKind);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamObj(map, prefix + "TcrRepoInfo.", this.TcrRepoInfo);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "InitContainerEnable", this.InitContainerEnable);
            this.SetParamSimple(map, prefix + "PrivilegeContainerEnable", this.PrivilegeContainerEnable);
            this.SetParamSimple(map, prefix + "RunCommand", this.RunCommand);
            this.SetParamSimple(map, prefix + "RunArg", this.RunArg);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamObj(map, prefix + "SchedulingStrategy.", this.SchedulingStrategy);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
            this.SetParamSimple(map, prefix + "ServiceSpecEncode", this.ServiceSpecEncode);
            this.SetParamSimple(map, prefix + "IstioMemRequest", this.IstioMemRequest);
            this.SetParamSimple(map, prefix + "IstioCpuRequest", this.IstioCpuRequest);
            this.SetParamSimple(map, prefix + "IstioMemLimit", this.IstioMemLimit);
            this.SetParamSimple(map, prefix + "IstioCpuLimit", this.IstioCpuLimit);
            this.SetParamObj(map, prefix + "ServiceGovernanceConfig.", this.ServiceGovernanceConfig);
            this.SetParamSimple(map, prefix + "AgentMemRequest", this.AgentMemRequest);
            this.SetParamSimple(map, prefix + "AgentCpuRequest", this.AgentCpuRequest);
            this.SetParamSimple(map, prefix + "AgentMemLimit", this.AgentMemLimit);
            this.SetParamSimple(map, prefix + "AgentCpuLimit", this.AgentCpuLimit);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "UpdateIvl", this.UpdateIvl);
            this.SetParamSimple(map, prefix + "MaxSurge", this.MaxSurge);
            this.SetParamSimple(map, prefix + "MaxUnavailable", this.MaxUnavailable);
            this.SetParamObj(map, prefix + "WarmupSetting.", this.WarmupSetting);
            this.SetParamSimple(map, prefix + "ConfigTemplateId", this.ConfigTemplateId);
            this.SetParamSimple(map, prefix + "ConfigTemplateVersion", this.ConfigTemplateVersion);
            this.SetParamSimple(map, prefix + "VolumeClean", this.VolumeClean);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "DeployAgent", this.DeployAgent);
            this.SetParamArrayObj(map, prefix + "AgentProfileList.", this.AgentProfileList);
            this.SetParamSimple(map, prefix + "ServiceClean", this.ServiceClean);
            this.SetParamSimple(map, prefix + "EnvClean", this.EnvClean);
            this.SetParamSimple(map, prefix + "DeployDesc", this.DeployDesc);
            this.SetParamSimple(map, prefix + "K8sNamespaceName", this.K8sNamespaceName);
            this.SetParamSimple(map, prefix + "StaticIpEnabled", this.StaticIpEnabled);
            this.SetParamSimple(map, prefix + "PodManagementPolicyType", this.PodManagementPolicyType);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
        }
    }
}

