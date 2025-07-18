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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAndroidInstanceImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像 ID 列表
        /// </summary>
        [JsonProperty("AndroidInstanceImageIds")]
        public string[] AndroidInstanceImageIds{ get; set; }

        /// <summary>
        /// 镜像可用区列表
        /// </summary>
        [JsonProperty("AndroidInstanceImageZones")]
        public string[] AndroidInstanceImageZones{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制量，默认为20，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 字段过滤器。Filter 的 Name 有以下值：
        /// ImageName：镜像名称
        /// ImageState：镜像状态
        /// AndroidVersion：安卓版本
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AndroidInstanceImageIds.", this.AndroidInstanceImageIds);
            this.SetParamArraySimple(map, prefix + "AndroidInstanceImageZones.", this.AndroidInstanceImageZones);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

