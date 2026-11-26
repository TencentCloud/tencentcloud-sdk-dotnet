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
        /// <p>镜像地址。仅支持 repository:tag、repository@sha256:&lt;64 位摘要&gt; 或 repository:tag@sha256:&lt;64 位摘要&gt;。</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像仓库类型：<code>enterprise</code>、<code>personal</code>、<code>custom</code></p><p>枚举值：</p><ul><li>enterprise： tcr 企业容器镜像服务</li><li>personal： ccr 个人容器镜像服务</li></ul>
        /// </summary>
        [JsonProperty("ImageRegistryType")]
        public string ImageRegistryType{ get; set; }

        /// <summary>
        /// <p>镜像预热类型</p><p>枚举值：</p><ul><li>image： 镜像预热</li><li>image_volume： 镜像卷预热</li></ul><p>默认值：image</p>
        /// </summary>
        [JsonProperty("PreCacheType")]
        public string PreCacheType{ get; set; }

        /// <summary>
        /// <p>闲置清理时间</p><p>枚举值：</p><ul><li>inherit： 继承账号配置的自动清理策略</li><li>0： 永不自动清理</li><li>正整数加 m/h/d： 空闲相应时间后自动清理</li></ul><p>默认值：inherit</p>
        /// </summary>
        [JsonProperty("IdleTTL")]
        public string IdleTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImageRegistryType", this.ImageRegistryType);
            this.SetParamSimple(map, prefix + "PreCacheType", this.PreCacheType);
            this.SetParamSimple(map, prefix + "IdleTTL", this.IdleTTL);
        }
    }
}

