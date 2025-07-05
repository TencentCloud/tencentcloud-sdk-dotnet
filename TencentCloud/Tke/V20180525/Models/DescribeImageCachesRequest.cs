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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageCachesRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像缓存Id数组
        /// </summary>
        [JsonProperty("ImageCacheIds")]
        public string[] ImageCacheIds{ get; set; }

        /// <summary>
        /// 镜像缓存名称数组
        /// </summary>
        [JsonProperty("ImageCacheNames")]
        public string[] ImageCacheNames{ get; set; }

        /// <summary>
        /// 限定此次返回资源的数量。如果不设定，默认返回20，最大不能超过50
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量,默认0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件，可选条件：
        /// (1)实例名称
        /// KeyName: image-cache-name
        /// 类型：String
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageCacheIds.", this.ImageCacheIds);
            this.SetParamArraySimple(map, prefix + "ImageCacheNames.", this.ImageCacheNames);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

