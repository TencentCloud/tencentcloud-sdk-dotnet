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

    public class Project : AbstractModel
    {
        
        /// <summary>
        /// <p>项目 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>项目名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>项目状态。Normal、Ban、Unlink、Process、Pending、Offline</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>站点 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>加速区域。mainland、overseas、global</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>代码来源。Github、Gitee、Coding、Upload、Gitlab、Bitbucket、Cnb</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>创建来源。Template、Custom、CLI、Guest</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>预设域名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetDomain")]
        public string PresetDomain{ get; set; }

        /// <summary>
        /// <p>预设域名状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PresetDomainStatus")]
        public string PresetDomainStatus{ get; set; }

        /// <summary>
        /// <p>项目根目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootDir")]
        public string RootDir{ get; set; }

        /// <summary>
        /// <p>构建产物目录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// <p>构建命令</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuildCmd")]
        public string BuildCmd{ get; set; }

        /// <summary>
        /// <p>安装命令</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstallCmd")]
        public string InstallCmd{ get; set; }

        /// <summary>
        /// <p>框架</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>Node.js 版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodejsVersion")]
        public string NodejsVersion{ get; set; }

        /// <summary>
        /// <p>仓库地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// <p>仓库所有者</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoOwner")]
        public string RepoOwner{ get; set; }

        /// <summary>
        /// <p>仓库名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// <p>生产分支</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoBranch")]
        public string RepoBranch{ get; set; }

        /// <summary>
        /// <p>预览分支</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoPreBranches")]
        public string[] RepoPreBranches{ get; set; }

        /// <summary>
        /// <p>部署地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regions")]
        public Regions Regions{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvVars")]
        public ProjectEnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// <p>自定义域名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomDomains")]
        public CustomDomainItem[] CustomDomains{ get; set; }

        /// <summary>
        /// <p>最近一次部署</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deployment")]
        public ProjectDeployment Deployment{ get; set; }

        /// <summary>
        /// <p>是否 Agent 项目。1 是，0 否</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAgent")]
        public long? IsAgent{ get; set; }

        /// <summary>
        /// <p>Agent 框架。非 Agent 项目为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentFramework")]
        public string AgentFramework{ get; set; }

        /// <summary>
        /// <p>是否命中用户级泛域名。1 是，0 否</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsTld")]
        public long? IsTld{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// <p>构建规格客户契约</p><p>枚举值：</p><ul><li>standard： 4C6G，默认档，所有套餐可用</li><li>enhanced： 8C14G，专业版及以上可用；低配套餐声明时按 standard 处理并提示升级</li></ul><p>默认值：standard</p>
        /// </summary>
        [JsonProperty("BuildMachine")]
        public string BuildMachine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "PresetDomain", this.PresetDomain);
            this.SetParamSimple(map, prefix + "PresetDomainStatus", this.PresetDomainStatus);
            this.SetParamSimple(map, prefix + "RootDir", this.RootDir);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "BuildCmd", this.BuildCmd);
            this.SetParamSimple(map, prefix + "InstallCmd", this.InstallCmd);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "NodejsVersion", this.NodejsVersion);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "RepoOwner", this.RepoOwner);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoBranch", this.RepoBranch);
            this.SetParamArraySimple(map, prefix + "RepoPreBranches.", this.RepoPreBranches);
            this.SetParamObj(map, prefix + "Regions.", this.Regions);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamArrayObj(map, prefix + "CustomDomains.", this.CustomDomains);
            this.SetParamObj(map, prefix + "Deployment.", this.Deployment);
            this.SetParamSimple(map, prefix + "IsAgent", this.IsAgent);
            this.SetParamSimple(map, prefix + "AgentFramework", this.AgentFramework);
            this.SetParamSimple(map, prefix + "IsTld", this.IsTld);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "BuildMachine", this.BuildMachine);
        }
    }
}

