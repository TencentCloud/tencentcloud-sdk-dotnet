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

    public class CloudBaseRunImageInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像仓库名称
        /// </summary>
        [JsonProperty("RepositoryName")]
        public string RepositoryName{ get; set; }

        /// <summary>
        /// 是否公有
        /// </summary>
        [JsonProperty("IsPublic")]
        public bool? IsPublic{ get; set; }

        /// <summary>
        /// 镜像tag名称
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 镜像server
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// 镜像拉取地址
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepositoryName", this.RepositoryName);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

