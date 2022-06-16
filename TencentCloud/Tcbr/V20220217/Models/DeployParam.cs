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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployParam : AbstractModel
    {
        
        /// <summary>
        /// 部署类型：package/image/repository/pipeline/jar/war
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// 部署类型为image时传入
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 部署类型为package时传入
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 部署类型为package时传入
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 部署备注
        /// </summary>
        [JsonProperty("DeployRemark")]
        public string DeployRemark{ get; set; }

        /// <summary>
        /// 代码仓库信息
        /// </summary>
        [JsonProperty("RepoInfo")]
        public RepositoryInfo RepoInfo{ get; set; }

        /// <summary>
        /// 无Dockerfile时填写
        /// </summary>
        [JsonProperty("BuildPacks")]
        public BuildPacksInfo BuildPacks{ get; set; }

        /// <summary>
        /// 发布类型 GRAY | FULL
        /// </summary>
        [JsonProperty("ReleaseType")]
        public string ReleaseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "DeployRemark", this.DeployRemark);
            this.SetParamObj(map, prefix + "RepoInfo.", this.RepoInfo);
            this.SetParamObj(map, prefix + "BuildPacks.", this.BuildPacks);
            this.SetParamSimple(map, prefix + "ReleaseType", this.ReleaseType);
        }
    }
}

