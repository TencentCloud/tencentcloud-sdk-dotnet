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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudBaseRunServerVersionResponse : AbstractModel
    {
        
        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Dockefile的路径
        /// </summary>
        [JsonProperty("DockerfilePath")]
        public string DockerfilePath{ get; set; }

        /// <summary>
        /// DockerBuild的目录
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// 请使用CPUSize
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 请使用MemSize
        /// </summary>
        [JsonProperty("Mem")]
        public float? Mem{ get; set; }

        /// <summary>
        /// 副本最小值
        /// </summary>
        [JsonProperty("MinNum")]
        public long? MinNum{ get; set; }

        /// <summary>
        /// 副本最大值
        /// </summary>
        [JsonProperty("MaxNum")]
        public long? MaxNum{ get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略阈值
        /// </summary>
        [JsonProperty("PolicyThreshold")]
        public float? PolicyThreshold{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 版本的IP
        /// </summary>
        [JsonProperty("VersionIP")]
        public string VersionIP{ get; set; }

        /// <summary>
        /// 版本的端口号
        /// </summary>
        [JsonProperty("VersionPort")]
        public long? VersionPort{ get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 代码包的名字
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 代码版本的名字
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 枚举（package/repository/image)
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// Repo的类型(gitlab/github/coding)
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Repo")]
        public string Repo{ get; set; }

        /// <summary>
        /// 分支
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// 服务名字
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 是否对于外网开放
        /// </summary>
        [JsonProperty("IsPublic")]
        public bool? IsPublic{ get; set; }

        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 日志采集路径
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// 监听端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// 延迟多长时间开始健康检查（单位s）
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// CPU 大小
        /// </summary>
        [JsonProperty("CpuSize")]
        public float? CpuSize{ get; set; }

        /// <summary>
        /// MEM 大小
        /// </summary>
        [JsonProperty("MemSize")]
        public float? MemSize{ get; set; }

        /// <summary>
        /// 是否有Dockerfile：0-default has, 1-has, 2-has not
        /// </summary>
        [JsonProperty("HasDockerfile")]
        public long? HasDockerfile{ get; set; }

        /// <summary>
        /// 基础镜像
        /// </summary>
        [JsonProperty("BaseImage")]
        public string BaseImage{ get; set; }

        /// <summary>
        /// 容器启动入口命令
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string EntryPoint{ get; set; }

        /// <summary>
        /// 仓库语言
        /// </summary>
        [JsonProperty("RepoLanguage")]
        public string RepoLanguage{ get; set; }

        /// <summary>
        /// 自动扩缩容策略组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyDetail")]
        public HpaPolicy[] PolicyDetail{ get; set; }

        /// <summary>
        /// Tke集群信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TkeClusterInfo")]
        public TkeClusterInfo TkeClusterInfo{ get; set; }

        /// <summary>
        /// 版本工作负载类型；deployment/deamonset
        /// </summary>
        [JsonProperty("TkeWorkloadType")]
        public string TkeWorkloadType{ get; set; }

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
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DockerfilePath", this.DockerfilePath);
            this.SetParamSimple(map, prefix + "BuildDir", this.BuildDir);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyThreshold", this.PolicyThreshold);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "VersionIP", this.VersionIP);
            this.SetParamSimple(map, prefix + "VersionPort", this.VersionPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "Repo", this.Repo);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "CustomLogs", this.CustomLogs);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "HasDockerfile", this.HasDockerfile);
            this.SetParamSimple(map, prefix + "BaseImage", this.BaseImage);
            this.SetParamSimple(map, prefix + "EntryPoint", this.EntryPoint);
            this.SetParamSimple(map, prefix + "RepoLanguage", this.RepoLanguage);
            this.SetParamArrayObj(map, prefix + "PolicyDetail.", this.PolicyDetail);
            this.SetParamObj(map, prefix + "TkeClusterInfo.", this.TkeClusterInfo);
            this.SetParamSimple(map, prefix + "TkeWorkloadType", this.TkeWorkloadType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

