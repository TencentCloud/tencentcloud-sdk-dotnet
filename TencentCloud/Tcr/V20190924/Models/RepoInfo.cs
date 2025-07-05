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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepoInfo : AbstractModel
    {
        
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }

        /// <summary>
        /// Tag数量
        /// </summary>
        [JsonProperty("TagCount")]
        public long? TagCount{ get; set; }

        /// <summary>
        /// 是否为公开
        /// </summary>
        [JsonProperty("Public")]
        public long? Public{ get; set; }

        /// <summary>
        /// 是否为用户收藏
        /// </summary>
        [JsonProperty("IsUserFavor")]
        public bool? IsUserFavor{ get; set; }

        /// <summary>
        /// 是否为腾讯云官方仓库
        /// </summary>
        [JsonProperty("IsQcloudOfficial")]
        public bool? IsQcloudOfficial{ get; set; }

        /// <summary>
        /// 被收藏的个数
        /// </summary>
        [JsonProperty("FavorCount")]
        public long? FavorCount{ get; set; }

        /// <summary>
        /// 拉取的数量
        /// </summary>
        [JsonProperty("PullCount")]
        public long? PullCount{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 仓库创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 仓库更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "TagCount", this.TagCount);
            this.SetParamSimple(map, prefix + "Public", this.Public);
            this.SetParamSimple(map, prefix + "IsUserFavor", this.IsUserFavor);
            this.SetParamSimple(map, prefix + "IsQcloudOfficial", this.IsQcloudOfficial);
            this.SetParamSimple(map, prefix + "FavorCount", this.FavorCount);
            this.SetParamSimple(map, prefix + "PullCount", this.PullCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

