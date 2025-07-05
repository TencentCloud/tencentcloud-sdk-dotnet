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

    public class GroupContainerInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像版本名称
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 容器名字
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 镜像名
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 仓库类型,tcr，address，personal，默认personal
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// tcr仓库信息
        /// </summary>
        [JsonProperty("TcrRepoInfo")]
        public TcrRepoInfo TcrRepoInfo{ get; set; }

        /// <summary>
        /// 镜像server
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 凭证名字
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// jvm 参数
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 容器最大的 CPU 核数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 容器分配的 CPU 核数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 容器分配的内存 MiB 数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 容器最大的内存 MiB 数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// 健康检查配置信息
        /// </summary>
        [JsonProperty("HealthCheckSettings")]
        public HealthCheckSettings HealthCheckSettings{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 环境变量,作为入参时不用填
        /// </summary>
        [JsonProperty("UserEnvs")]
        public Env[] UserEnvs{ get; set; }

        /// <summary>
        /// 数据卷挂载点信息
        /// </summary>
        [JsonProperty("VolumeMountInfoList")]
        public VolumeMountInfo[] VolumeMountInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamObj(map, prefix + "TcrRepoInfo.", this.TcrRepoInfo);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamObj(map, prefix + "HealthCheckSettings.", this.HealthCheckSettings);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "UserEnvs.", this.UserEnvs);
            this.SetParamArrayObj(map, prefix + "VolumeMountInfoList.", this.VolumeMountInfoList);
        }
    }
}

