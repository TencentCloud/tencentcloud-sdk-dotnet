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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInfoV2 : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像类型</p><p>枚举值：</p><ul><li>official： 官方镜像</li><li>custom： 自定义镜像</li><li>imageUrl： 镜像地址</li></ul>
        /// </summary>
        [JsonProperty("ImageMode")]
        public string ImageMode{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>是否是存量镜像</p>
        /// </summary>
        [JsonProperty("LegacyCCR")]
        public bool? LegacyCCR{ get; set; }

        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("FullImageUrl")]
        public string FullImageUrl{ get; set; }

        /// <summary>
        /// <p>版本</p>
        /// </summary>
        [JsonProperty("MainVersion")]
        public string MainVersion{ get; set; }

        /// <summary>
        /// <p>镜像地址域名</p>
        /// </summary>
        [JsonProperty("RegistryUrl")]
        public string RegistryUrl{ get; set; }

        /// <summary>
        /// <p>镜像命名空间</p>
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// <p>镜像仓库名</p>
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// <p>镜像版本标签</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>镜像拉取密钥</p>
        /// </summary>
        [JsonProperty("ImagePullSecret")]
        public ImagePullSecret ImagePullSecret{ get; set; }

        /// <summary>
        /// <p>镜像拉取策略</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageMode", this.ImageMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "LegacyCCR", this.LegacyCCR);
            this.SetParamSimple(map, prefix + "FullImageUrl", this.FullImageUrl);
            this.SetParamSimple(map, prefix + "MainVersion", this.MainVersion);
            this.SetParamSimple(map, prefix + "RegistryUrl", this.RegistryUrl);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "ImagePullSecret.", this.ImagePullSecret);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
        }
    }
}

