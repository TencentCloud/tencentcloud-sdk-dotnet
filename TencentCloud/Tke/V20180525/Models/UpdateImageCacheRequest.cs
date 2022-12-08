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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateImageCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像缓存Id
        /// </summary>
        [JsonProperty("ImageCacheId")]
        public string ImageCacheId{ get; set; }

        /// <summary>
        /// 镜像缓存名称
        /// </summary>
        [JsonProperty("ImageCacheName")]
        public string ImageCacheName{ get; set; }

        /// <summary>
        /// 镜像仓库凭证数组
        /// </summary>
        [JsonProperty("ImageRegistryCredentials")]
        public ImageRegistryCredential[] ImageRegistryCredentials{ get; set; }

        /// <summary>
        /// 用于制作镜像缓存的容器镜像列表
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 镜像缓存的大小。默认为20 GiB。取值范围参考[云硬盘类型](https://cloud.tencent.com/document/product/362/2353)中的高性能云盘类型的大小限制。
        /// </summary>
        [JsonProperty("ImageCacheSize")]
        public ulong? ImageCacheSize{ get; set; }

        /// <summary>
        /// 镜像缓存保留时间天数，过期将会自动清理，默认为0，永不过期。
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// 安全组Id
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageCacheId", this.ImageCacheId);
            this.SetParamSimple(map, prefix + "ImageCacheName", this.ImageCacheName);
            this.SetParamArrayObj(map, prefix + "ImageRegistryCredentials.", this.ImageRegistryCredentials);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ImageCacheSize", this.ImageCacheSize);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

