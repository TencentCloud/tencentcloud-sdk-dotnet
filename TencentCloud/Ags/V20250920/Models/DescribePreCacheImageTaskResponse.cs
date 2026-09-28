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

    public class DescribePreCacheImageTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像 Digest</p>
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// <p>镜像仓库类型：<code>enterprise</code>、<code>personal</code>。</p>
        /// </summary>
        [JsonProperty("ImageRegistryType")]
        public string ImageRegistryType{ get; set; }

        /// <summary>
        /// <p>镜像预热状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>镜像预热状态描述</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>镜像预热创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>镜像预热ID</p>
        /// </summary>
        [JsonProperty("PreCacheImageId")]
        public string PreCacheImageId{ get; set; }

        /// <summary>
        /// <p>镜像预热资源的来源类型，取值为 EXPLICIT、AUTO</p><p>枚举值：</p><ul><li>EXPLICIT： 手动创建</li><li>AUTO： 自动创建</li><li>TCR_AUTO： TCR自动预热</li></ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>镜像预热存储大小</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("CachedImageSizeBytes")]
        public long? CachedImageSizeBytes{ get; set; }

        /// <summary>
        /// <p>该预热镜像最近一次被沙箱实例使用时间</p>
        /// </summary>
        [JsonProperty("LastUsedTime")]
        public string LastUsedTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "ImageDigest", this.ImageDigest);
            this.SetParamSimple(map, prefix + "ImageRegistryType", this.ImageRegistryType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PreCacheImageId", this.PreCacheImageId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "CachedImageSizeBytes", this.CachedImageSizeBytes);
            this.SetParamSimple(map, prefix + "LastUsedTime", this.LastUsedTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

