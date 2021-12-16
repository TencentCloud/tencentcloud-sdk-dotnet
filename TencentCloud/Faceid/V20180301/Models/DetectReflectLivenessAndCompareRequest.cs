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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectReflectLivenessAndCompareRequest : AbstractModel
    {
        
        /// <summary>
        /// SDK生成的数据包活体数据包的资源地址。
        /// </summary>
        [JsonProperty("LiveDataUrl")]
        public string LiveDataUrl{ get; set; }

        /// <summary>
        /// SDK生成的数据包活体数据包的资源Md5。
        /// </summary>
        [JsonProperty("LiveDataMd5")]
        public string LiveDataMd5{ get; set; }

        /// <summary>
        /// 用于比对的目标图片的资源地址。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 用于比对的目标图片的资源Md5。
        /// </summary>
        [JsonProperty("ImageMd5")]
        public string ImageMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LiveDataUrl", this.LiveDataUrl);
            this.SetParamSimple(map, prefix + "LiveDataMd5", this.LiveDataMd5);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageMd5", this.ImageMd5);
        }
    }
}

