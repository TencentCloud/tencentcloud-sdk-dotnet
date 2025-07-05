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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudRunServiceSimpleVersionSnapshot : AbstractModel
    {
        
        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 版本备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// cpu规格
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 内存规格
        /// </summary>
        [JsonProperty("Mem")]
        public float? Mem{ get; set; }

        /// <summary>
        /// 最小副本数
        /// </summary>
        [JsonProperty("MinNum")]
        public long? MinNum{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxNum")]
        public long? MaxNum{ get; set; }

        /// <summary>
        /// 镜像url
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 扩容策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略阈值
        /// </summary>
        [JsonProperty("PolicyThreshold")]
        public long? PolicyThreshold{ get; set; }

        /// <summary>
        /// 环境参数
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 容器端口
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 更新类型
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// dockerfile路径
        /// </summary>
        [JsonProperty("DockerfilePath")]
        public string DockerfilePath{ get; set; }

        /// <summary>
        /// 构建路径
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// repo类型
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonProperty("Repo")]
        public string Repo{ get; set; }

        /// <summary>
        /// 分支
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// package名字
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// package版本
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 自定义log路径
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// 延时健康检查时间
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// snapshot名
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 镜像信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public CloudBaseRunImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 代码仓库信息
        /// </summary>
        [JsonProperty("CodeDetail")]
        public CloudBaseCodeRepoDetail CodeDetail{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyThreshold", this.PolicyThreshold);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "DockerfilePath", this.DockerfilePath);
            this.SetParamSimple(map, prefix + "BuildDir", this.BuildDir);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "Repo", this.Repo);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "CustomLogs", this.CustomLogs);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "CodeDetail.", this.CodeDetail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

