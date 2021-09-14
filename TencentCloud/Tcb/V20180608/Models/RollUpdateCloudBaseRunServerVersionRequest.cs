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

    public class RollUpdateCloudBaseRunServerVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 要替换的版本名称，可以为latest
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 枚举（package/repository/image)
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// repository的类型(coding/gitlab/github)
        /// </summary>
        [JsonProperty("RepositoryType")]
        public string RepositoryType{ get; set; }

        /// <summary>
        /// 流量占比
        /// </summary>
        [JsonProperty("FlowRatio")]
        public long? FlowRatio{ get; set; }

        /// <summary>
        /// dockerfile地址
        /// </summary>
        [JsonProperty("DockerfilePath")]
        public string DockerfilePath{ get; set; }

        /// <summary>
        /// 构建目录
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// Cpu的大小，单位：核
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// Mem的大小，单位：G
        /// </summary>
        [JsonProperty("Mem")]
        public string Mem{ get; set; }

        /// <summary>
        /// 最小副本数，最小值：0
        /// </summary>
        [JsonProperty("MinNum")]
        public string MinNum{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxNum")]
        public string MaxNum{ get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略阈值
        /// </summary>
        [JsonProperty("PolicyThreshold")]
        public string PolicyThreshold{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 容器端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// repository地址
        /// </summary>
        [JsonProperty("Repository")]
        public string Repository{ get; set; }

        /// <summary>
        /// 分支
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// 版本备注
        /// </summary>
        [JsonProperty("VersionRemark")]
        public string VersionRemark{ get; set; }

        /// <summary>
        /// 代码包名字
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 代码包版本
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Image的详情
        /// </summary>
        [JsonProperty("ImageInfo")]
        public CloudBaseRunImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// Github等拉取代码的详情
        /// </summary>
        [JsonProperty("CodeDetail")]
        public CloudBaseCodeRepoDetail CodeDetail{ get; set; }

        /// <summary>
        /// 是否回放流量
        /// </summary>
        [JsonProperty("IsRebuild")]
        public bool? IsRebuild{ get; set; }

        /// <summary>
        /// 延迟多长时间开始健康检查（单位s）
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// cfs挂载信息
        /// </summary>
        [JsonProperty("MountVolumeInfo")]
        public CloudBaseRunVolumeMount[] MountVolumeInfo{ get; set; }

        /// <summary>
        /// 是否回滚
        /// </summary>
        [JsonProperty("Rollback")]
        public bool? Rollback{ get; set; }

        /// <summary>
        /// 版本历史名
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 自定义采集路径
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// 是否启用统一域名
        /// </summary>
        [JsonProperty("EnableUnion")]
        public bool? EnableUnion{ get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }

        /// <summary>
        /// 服务路径（只会第一次生效）
        /// </summary>
        [JsonProperty("ServerPath")]
        public string ServerPath{ get; set; }

        /// <summary>
        /// 是否更新Cls
        /// </summary>
        [JsonProperty("IsUpdateCls")]
        public bool? IsUpdateCls{ get; set; }

        /// <summary>
        /// 自动扩缩容策略组
        /// </summary>
        [JsonProperty("PolicyDetail")]
        public HpaPolicy[] PolicyDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "RepositoryType", this.RepositoryType);
            this.SetParamSimple(map, prefix + "FlowRatio", this.FlowRatio);
            this.SetParamSimple(map, prefix + "DockerfilePath", this.DockerfilePath);
            this.SetParamSimple(map, prefix + "BuildDir", this.BuildDir);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyThreshold", this.PolicyThreshold);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "Repository", this.Repository);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamSimple(map, prefix + "VersionRemark", this.VersionRemark);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "CodeDetail.", this.CodeDetail);
            this.SetParamSimple(map, prefix + "IsRebuild", this.IsRebuild);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamArrayObj(map, prefix + "MountVolumeInfo.", this.MountVolumeInfo);
            this.SetParamSimple(map, prefix + "Rollback", this.Rollback);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "CustomLogs", this.CustomLogs);
            this.SetParamSimple(map, prefix + "EnableUnion", this.EnableUnion);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
            this.SetParamSimple(map, prefix + "ServerPath", this.ServerPath);
            this.SetParamSimple(map, prefix + "IsUpdateCls", this.IsUpdateCls);
            this.SetParamArrayObj(map, prefix + "PolicyDetail.", this.PolicyDetail);
        }
    }
}

