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

    public class DescribeAssetHostDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 容器安全uuid
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机分组
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// agent版本
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// 内核版本
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// docker版本
        /// </summary>
        [JsonProperty("DockerVersion")]
        public string DockerVersion{ get; set; }

        /// <summary>
        /// docker api版本
        /// </summary>
        [JsonProperty("DockerAPIVersion")]
        public string DockerAPIVersion{ get; set; }

        /// <summary>
        /// docker go 版本
        /// </summary>
        [JsonProperty("DockerGoVersion")]
        public string DockerGoVersion{ get; set; }

        /// <summary>
        /// docker 文件系统类型
        /// </summary>
        [JsonProperty("DockerFileSystemDriver")]
        public string DockerFileSystemDriver{ get; set; }

        /// <summary>
        /// docker root 目录
        /// </summary>
        [JsonProperty("DockerRootDir")]
        public string DockerRootDir{ get; set; }

        /// <summary>
        /// 镜像数
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// 容器数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// k8s IP
        /// </summary>
        [JsonProperty("K8sMasterIP")]
        public string K8sMasterIP{ get; set; }

        /// <summary>
        /// k8s version
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// kube proxy
        /// </summary>
        [JsonProperty("KubeProxyVersion")]
        public string KubeProxyVersion{ get; set; }

        /// <summary>
        /// "UNINSTALL"："未安装","OFFLINE"："离线", "ONLINE"："防护中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否Containerd
        /// </summary>
        [JsonProperty("IsContainerd")]
        public bool? IsContainerd{ get; set; }

        /// <summary>
        /// 主机来源;"TENCENTCLOUD":"腾讯云服务器","OTHERCLOUD":"非腾讯云服务器"
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 外网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 主机实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionID")]
        public long? RegionID{ get; set; }

        /// <summary>
        /// 所属项目
        /// </summary>
        [JsonProperty("Project")]
        public ProjectInfo Project{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群接入状态
        /// </summary>
        [JsonProperty("ClusterAccessedStatus")]
        public string ClusterAccessedStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "DockerVersion", this.DockerVersion);
            this.SetParamSimple(map, prefix + "DockerAPIVersion", this.DockerAPIVersion);
            this.SetParamSimple(map, prefix + "DockerGoVersion", this.DockerGoVersion);
            this.SetParamSimple(map, prefix + "DockerFileSystemDriver", this.DockerFileSystemDriver);
            this.SetParamSimple(map, prefix + "DockerRootDir", this.DockerRootDir);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "K8sMasterIP", this.K8sMasterIP);
            this.SetParamSimple(map, prefix + "K8sVersion", this.K8sVersion);
            this.SetParamSimple(map, prefix + "KubeProxyVersion", this.KubeProxyVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsContainerd", this.IsContainerd);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "RegionID", this.RegionID);
            this.SetParamObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterAccessedStatus", this.ClusterAccessedStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

