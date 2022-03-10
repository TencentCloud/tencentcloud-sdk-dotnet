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

    public class ImageCache : AbstractModel
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
        /// 镜像缓存大小。单位：GiB
        /// </summary>
        [JsonProperty("ImageCacheSize")]
        public ulong? ImageCacheSize{ get; set; }

        /// <summary>
        /// 镜像缓存包含的镜像列表
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpireDateTime")]
        public string ExpireDateTime{ get; set; }

        /// <summary>
        /// 镜像缓存事件信息
        /// </summary>
        [JsonProperty("Events")]
        public ImageCacheEvent[] Events{ get; set; }

        /// <summary>
        /// 最新一次匹配到镜像缓存的时间
        /// </summary>
        [JsonProperty("LastMatchedTime")]
        public string LastMatchedTime{ get; set; }

        /// <summary>
        /// 镜像缓存对应的快照Id
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// 镜像缓存状态，可能取值：
        /// Pending：创建中
        /// Ready：创建完成
        /// Failed：创建失败
        /// Updating：更新中
        /// UpdateFailed：更新失败
        /// 只有状态为Ready时，才能正常使用镜像缓存
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageCacheId", this.ImageCacheId);
            this.SetParamSimple(map, prefix + "ImageCacheName", this.ImageCacheName);
            this.SetParamSimple(map, prefix + "ImageCacheSize", this.ImageCacheSize);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "ExpireDateTime", this.ExpireDateTime);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamSimple(map, prefix + "LastMatchedTime", this.LastMatchedTime);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

