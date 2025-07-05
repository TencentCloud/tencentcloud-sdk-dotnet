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

    public class CloudBaseProjectVersion : AbstractModel
    {
        
        /// <summary>
        /// 项目名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// SAM json
        /// </summary>
        [JsonProperty("Sam")]
        public string Sam{ get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [JsonProperty("Source")]
        public CodeSource Source{ get; set; }

        /// <summary>
        /// 创建时间, unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间 ,unix时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 项目状态, 枚举值: 
        ///         "creatingEnv"-创建环境中
        /// 	"createEnvFail"-创建环境失败
        /// 	"building"-构建中
        /// 	"buildFail"-构建失败
        /// 	"deploying"-部署中
        /// 	 "deployFail"-部署失败
        /// 	 "success"-部署成功
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("Parameters")]
        public KVPair[] Parameters{ get; set; }

        /// <summary>
        /// 项目类型, 枚举值:
        /// "framework-oneclick" 控制台一键部署
        /// "framework-local-oneclick" cli本地一键部署
        /// "qci-extension-cicd" 内网coding ci cd
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ci的id
        /// </summary>
        [JsonProperty("CIId")]
        public string CIId{ get; set; }

        /// <summary>
        /// cd的id
        /// </summary>
        [JsonProperty("CDId")]
        public string CDId{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("VersionNum")]
        public long? VersionNum{ get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// rc.json内容
        /// </summary>
        [JsonProperty("RcJson")]
        public string RcJson{ get; set; }

        /// <summary>
        /// 插件配置内容
        /// </summary>
        [JsonProperty("AddonConfig")]
        public string AddonConfig{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 网络配置
        /// </summary>
        [JsonProperty("NetworkConfig")]
        public string NetworkConfig{ get; set; }

        /// <summary>
        /// 扩展id
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [JsonProperty("FailType")]
        public string FailType{ get; set; }

        /// <summary>
        /// 私有仓库地址
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// 是否私有仓库代码变更触发自动部署
        /// </summary>
        [JsonProperty("AutoDeployOnCodeChange")]
        public bool? AutoDeployOnCodeChange{ get; set; }

        /// <summary>
        /// ci部署进度（%）
        /// </summary>
        [JsonProperty("BuildPercent")]
        public long? BuildPercent{ get; set; }

        /// <summary>
        /// Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// BuildFinishTime
        /// </summary>
        [JsonProperty("BuildFinishTime")]
        public string BuildFinishTime{ get; set; }

        /// <summary>
        /// DeployFinishTime
        /// </summary>
        [JsonProperty("DeployFinishTime")]
        public string DeployFinishTime{ get; set; }

        /// <summary>
        /// BuildId
        /// </summary>
        [JsonProperty("BuildId")]
        public string BuildId{ get; set; }

        /// <summary>
        /// SourceUrl
        /// </summary>
        [JsonProperty("SourceUrl")]
        public string SourceUrl{ get; set; }

        /// <summary>
        /// FailReasonShort
        /// </summary>
        [JsonProperty("FailReasonShort")]
        public string FailReasonShort{ get; set; }

        /// <summary>
        /// FirstInitRepo
        /// </summary>
        [JsonProperty("FirstInitRepo")]
        public string FirstInitRepo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sam", this.Sam);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Parameters.", this.Parameters);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CIId", this.CIId);
            this.SetParamSimple(map, prefix + "CDId", this.CDId);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "VersionNum", this.VersionNum);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "RcJson", this.RcJson);
            this.SetParamSimple(map, prefix + "AddonConfig", this.AddonConfig);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NetworkConfig", this.NetworkConfig);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "FailType", this.FailType);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "AutoDeployOnCodeChange", this.AutoDeployOnCodeChange);
            this.SetParamSimple(map, prefix + "BuildPercent", this.BuildPercent);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "BuildFinishTime", this.BuildFinishTime);
            this.SetParamSimple(map, prefix + "DeployFinishTime", this.DeployFinishTime);
            this.SetParamSimple(map, prefix + "BuildId", this.BuildId);
            this.SetParamSimple(map, prefix + "SourceUrl", this.SourceUrl);
            this.SetParamSimple(map, prefix + "FailReasonShort", this.FailReasonShort);
            this.SetParamSimple(map, prefix + "FirstInitRepo", this.FirstInitRepo);
        }
    }
}

