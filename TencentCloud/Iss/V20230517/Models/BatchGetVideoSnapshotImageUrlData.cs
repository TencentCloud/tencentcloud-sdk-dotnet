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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchGetVideoSnapshotImageUrlData : AbstractModel
    {
        
        /// <summary>
        /// <p>图片Url信息</p>
        /// </summary>
        [JsonProperty("Images")]
        public ImageUrlInfo[] Images{ get; set; }

        /// <summary>
        /// <p>图片Url有效期</p><p>单位：秒</p><p>默认值：600</p>
        /// </summary>
        [JsonProperty("ImageUrlExpires")]
        public long? ImageUrlExpires{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ImageUrlExpires", this.ImageUrlExpires);
        }
    }
}

