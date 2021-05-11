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

    public class CreateAndDeployCloudBaseProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("Source")]
        public CodeSource Source{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 项目类型, 枚举值为: framework-oneclick,qci-extension-cicd
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("Parameters")]
        public KVPair[] Parameters{ get; set; }

        /// <summary>
        /// 环境别名。要以a-z开头，不能包含a-zA-z0-9-以外的字符
        /// </summary>
        [JsonProperty("EnvAlias")]
        public string EnvAlias{ get; set; }

        /// <summary>
        /// rc.json的内容
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
        /// 用户享有的免费额度级别，目前只能为“basic”，不传该字段或该字段为空，标识不享受免费额度。
        /// </summary>
        [JsonProperty("FreeQuota")]
        public string FreeQuota{ get; set; }

        /// <summary>
        /// 是否代码变更触发自动部署
        /// </summary>
        [JsonProperty("AutoDeployOnCodeChange")]
        public bool? AutoDeployOnCodeChange{ get; set; }

        /// <summary>
        /// 私有仓库地址
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Source.", this.Source);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Parameters.", this.Parameters);
            this.SetParamSimple(map, prefix + "EnvAlias", this.EnvAlias);
            this.SetParamSimple(map, prefix + "RcJson", this.RcJson);
            this.SetParamSimple(map, prefix + "AddonConfig", this.AddonConfig);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NetworkConfig", this.NetworkConfig);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "AutoDeployOnCodeChange", this.AutoDeployOnCodeChange);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
        }
    }
}

