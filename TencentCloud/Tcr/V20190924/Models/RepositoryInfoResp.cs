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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepositoryInfoResp : AbstractModel
    {
        
        /// <summary>
        /// 镜像仓库名字
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 镜像仓库类型
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// 镜像仓库服务地址
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 镜像仓库描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否为公有镜像
        /// </summary>
        [JsonProperty("Public")]
        public long? Public{ get; set; }

        /// <summary>
        /// 下载次数
        /// </summary>
        [JsonProperty("PullCount")]
        public long? PullCount{ get; set; }

        /// <summary>
        /// 收藏次数
        /// </summary>
        [JsonProperty("FavorCount")]
        public long? FavorCount{ get; set; }

        /// <summary>
        /// 是否为用户收藏
        /// </summary>
        [JsonProperty("IsUserFavor")]
        public bool? IsUserFavor{ get; set; }

        /// <summary>
        /// 是否为腾讯云官方镜像
        /// </summary>
        [JsonProperty("IsQcloudOfficial")]
        public bool? IsQcloudOfficial{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Public", this.Public);
            this.SetParamSimple(map, prefix + "PullCount", this.PullCount);
            this.SetParamSimple(map, prefix + "FavorCount", this.FavorCount);
            this.SetParamSimple(map, prefix + "IsUserFavor", this.IsUserFavor);
            this.SetParamSimple(map, prefix + "IsQcloudOfficial", this.IsQcloudOfficial);
        }
    }
}

