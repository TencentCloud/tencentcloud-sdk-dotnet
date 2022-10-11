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

    public class DeployContainerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID，分组唯一标识
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 镜像版本名称,如v1
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 镜像server
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 旧版镜像名，如/tsf/nginx
        /// </summary>
        [JsonProperty("Reponame")]
        public string Reponame{ get; set; }

        /// <summary>
        /// 业务容器最大的 CPU 核数，对应 K8S 的 limit；不填时默认为 request 的 2 倍
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 业务容器最大的内存 MiB 数，对应 K8S 的 limit；不填时默认为 request 的 2 倍
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// jvm参数
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 业务容器分配的 CPU 核数，对应 K8S 的 request，默认0.25
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 业务容器分配的内存 MiB 数，对应 K8S 的 request，默认640 MiB
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 是否不立即启动
        /// </summary>
        [JsonProperty("DoNotStart")]
        public bool? DoNotStart{ get; set; }

        /// <summary>
        /// （优先使用）新版镜像名，如/tsf/nginx
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 更新方式：0:快速更新 1:滚动更新
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 滚动更新必填，更新间隔
        /// </summary>
        [JsonProperty("UpdateIvl")]
        public long? UpdateIvl{ get; set; }

        /// <summary>
        /// agent 容器分配的 CPU 核数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("AgentCpuRequest")]
        public string AgentCpuRequest{ get; set; }

        /// <summary>
        /// agent 容器最大的 CPU 核数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("AgentCpuLimit")]
        public string AgentCpuLimit{ get; set; }

        /// <summary>
        /// agent 容器分配的内存 MiB 数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("AgentMemRequest")]
        public string AgentMemRequest{ get; set; }

        /// <summary>
        /// agent 容器最大的内存 MiB 数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("AgentMemLimit")]
        public string AgentMemLimit{ get; set; }

        /// <summary>
        /// istioproxy 容器分配的 CPU 核数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("IstioCpuRequest")]
        public string IstioCpuRequest{ get; set; }

        /// <summary>
        /// istioproxy 容器最大的 CPU 核数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("IstioCpuLimit")]
        public string IstioCpuLimit{ get; set; }

        /// <summary>
        /// istioproxy 容器分配的内存 MiB 数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("IstioMemRequest")]
        public string IstioMemRequest{ get; set; }

        /// <summary>
        /// istioproxy 容器最大的内存 MiB 数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("IstioMemLimit")]
        public string IstioMemLimit{ get; set; }

        /// <summary>
        /// kubernetes滚动更新策略的MaxSurge参数
        /// </summary>
        [JsonProperty("MaxSurge")]
        public string MaxSurge{ get; set; }

        /// <summary>
        /// kubernetes滚动更新策略的MaxUnavailable参数
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public string MaxUnavailable{ get; set; }

        /// <summary>
        /// 健康检查配置信息，若不指定该参数，则默认不设置健康检查。
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 部署组应用运行的环境变量。若不指定该参数，则默认不设置额外的环境变量。
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 容器部署组的网络设置。
        /// </summary>
        [JsonProperty("ServiceSetting")]
        public ServiceSetting ServiceSetting{ get; set; }

        /// <summary>
        /// 是否部署 agent 容器。若不指定该参数，则默认不部署 agent 容器。
        /// </summary>
        [JsonProperty("DeployAgent")]
        public bool? DeployAgent{ get; set; }

        /// <summary>
        /// 节点调度策略。若不指定改参数，则默认不使用节点调度策略。
        /// </summary>
        [JsonProperty("SchedulingStrategy")]
        public SchedulingStrategy SchedulingStrategy{ get; set; }

        /// <summary>
        /// 是否进行增量部署，默认为false，全量更新
        /// </summary>
        [JsonProperty("IncrementalDeployment")]
        public bool? IncrementalDeployment{ get; set; }

        /// <summary>
        /// tcr或者不填
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 数据卷信息-废弃，请用VolumeInfoList参数
        /// </summary>
        [JsonProperty("VolumeInfos")]
        public VolumeInfo VolumeInfos{ get; set; }

        /// <summary>
        /// 数据卷挂载点信息-废弃，请用VolumeMountInfoList参数
        /// </summary>
        [JsonProperty("VolumeMountInfos")]
        public VolumeMountInfo VolumeMountInfos{ get; set; }

        /// <summary>
        /// 数据卷信息，list
        /// </summary>
        [JsonProperty("VolumeInfoList")]
        public VolumeInfo[] VolumeInfoList{ get; set; }

        /// <summary>
        /// 数据卷挂载点信息，list
        /// </summary>
        [JsonProperty("VolumeMountInfoList")]
        public VolumeMountInfo[] VolumeMountInfoList{ get; set; }

        /// <summary>
        /// 是否清除数据卷信息，默认false
        /// </summary>
        [JsonProperty("VolumeClean")]
        public bool? VolumeClean{ get; set; }

        /// <summary>
        /// javaagent信息: SERVICE_AGENT/OT_AGENT
        /// </summary>
        [JsonProperty("AgentProfileList")]
        public AgentProfile[] AgentProfileList{ get; set; }

        /// <summary>
        /// 预热配置信息
        /// </summary>
        [JsonProperty("WarmupSetting")]
        public WarmupSetting WarmupSetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "Reponame", this.Reponame);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "DoNotStart", this.DoNotStart);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "UpdateIvl", this.UpdateIvl);
            this.SetParamSimple(map, prefix + "AgentCpuRequest", this.AgentCpuRequest);
            this.SetParamSimple(map, prefix + "AgentCpuLimit", this.AgentCpuLimit);
            this.SetParamSimple(map, prefix + "AgentMemRequest", this.AgentMemRequest);
            this.SetParamSimple(map, prefix + "AgentMemLimit", this.AgentMemLimit);
            this.SetParamSimple(map, prefix + "IstioCpuRequest", this.IstioCpuRequest);
            this.SetParamSimple(map, prefix + "IstioCpuLimit", this.IstioCpuLimit);
            this.SetParamSimple(map, prefix + "IstioMemRequest", this.IstioMemRequest);
            this.SetParamSimple(map, prefix + "IstioMemLimit", this.IstioMemLimit);
            this.SetParamSimple(map, prefix + "MaxSurge", this.MaxSurge);
            this.SetParamSimple(map, prefix + "MaxUnavailable", this.MaxUnavailable);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamObj(map, prefix + "ServiceSetting.", this.ServiceSetting);
            this.SetParamSimple(map, prefix + "DeployAgent", this.DeployAgent);
            this.SetParamObj(map, prefix + "SchedulingStrategy.", this.SchedulingStrategy);
            this.SetParamSimple(map, prefix + "IncrementalDeployment", this.IncrementalDeployment);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamObj(map, prefix + "VolumeInfos.", this.VolumeInfos);
            this.SetParamObj(map, prefix + "VolumeMountInfos.", this.VolumeMountInfos);
            this.SetParamArrayObj(map, prefix + "VolumeInfoList.", this.VolumeInfoList);
            this.SetParamArrayObj(map, prefix + "VolumeMountInfoList.", this.VolumeMountInfoList);
            this.SetParamSimple(map, prefix + "VolumeClean", this.VolumeClean);
            this.SetParamArrayObj(map, prefix + "AgentProfileList.", this.AgentProfileList);
            this.SetParamObj(map, prefix + "WarmupSetting.", this.WarmupSetting);
        }
    }
}

