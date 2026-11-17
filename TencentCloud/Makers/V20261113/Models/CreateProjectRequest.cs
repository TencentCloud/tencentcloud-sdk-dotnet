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

namespace TencentCloud.Makers.V20261113.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Makers 站点 ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>项目名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>创建来源。Template、Custom、CLI、Guest</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>代码来源。Upload、Github、Gitee、Gitlab、Coding</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>接入方标识</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>加速区域。mainland、overseas、global</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Node.js 版本。14.21.3、16.20.2、18.20.4、20.18.0、22.11.0、22.17.1、22.21.1、24.5.0、24.11.0、24.18.0</p>
        /// </summary>
        [JsonProperty("NodeJsVersion")]
        public string NodeJsVersion{ get; set; }

        /// <summary>
        /// <p>项目根目录</p>
        /// </summary>
        [JsonProperty("RootDir")]
        public string RootDir{ get; set; }

        /// <summary>
        /// <p>构建产物目录</p>
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// <p>构建命令</p>
        /// </summary>
        [JsonProperty("BuildCmd")]
        public string BuildCmd{ get; set; }

        /// <summary>
        /// <p>安装命令</p>
        /// </summary>
        [JsonProperty("InstallCmd")]
        public string InstallCmd{ get; set; }

        /// <summary>
        /// <p>框架</p>
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>模板 ID</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>仓库地址</p>
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// <p>仓库所有者</p>
        /// </summary>
        [JsonProperty("RepoOwner")]
        public string RepoOwner{ get; set; }

        /// <summary>
        /// <p>仓库名称</p>
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// <p>生产分支</p>
        /// </summary>
        [JsonProperty("RepoBranch")]
        public string RepoBranch{ get; set; }

        /// <summary>
        /// <p>初始环境变量</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public EnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// <p>Coding 命名空间。Provider 为 Coding 时使用</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Coding 项目 ID。Provider 为 Coding 时使用</p>
        /// </summary>
        [JsonProperty("CodingProjectId")]
        public long? CodingProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "NodeJsVersion", this.NodeJsVersion);
            this.SetParamSimple(map, prefix + "RootDir", this.RootDir);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "BuildCmd", this.BuildCmd);
            this.SetParamSimple(map, prefix + "InstallCmd", this.InstallCmd);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "RepoOwner", this.RepoOwner);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoBranch", this.RepoBranch);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CodingProjectId", this.CodingProjectId);
        }
    }
}

