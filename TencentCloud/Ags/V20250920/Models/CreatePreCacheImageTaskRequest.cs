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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePreCacheImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像仓库类型：<code>enterprise</code>、<code>personal</code>、<code>custom</code></p><p>枚举值：</p><ul><li>enterprise： tcr 企业容器镜像服务</li><li>personal： ccr 个人容器镜像服务</li></ul>
        /// </summary>
        [JsonProperty("ImageRegistryType")]
        public string ImageRegistryType{ get; set; }

        /// <summary>
        /// <p>预热超时时长</p>
        /// </summary>
        [JsonProperty("TimeoutMinutes")]
        public long? TimeoutMinutes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImageRegistryType", this.ImageRegistryType);
            this.SetParamSimple(map, prefix + "TimeoutMinutes", this.TimeoutMinutes);
        }
    }
}

