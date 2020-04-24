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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoMaterial : AbstractModel
    {
        
        /// <summary>
        /// 素材元信息。
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// 雪碧图信息。
        /// </summary>
        [JsonProperty("ImageSpriteInfo")]
        public MediaImageSpriteInfo ImageSpriteInfo{ get; set; }

        /// <summary>
        /// 素材媒体文件的 URL 地址
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }

        /// <summary>
        /// 素材媒体文件的封面图片地址。
        /// </summary>
        [JsonProperty("CoverUrl")]
        public string CoverUrl{ get; set; }

        /// <summary>
        /// 媒体文件分辨率。取值为：LD/SD/HD/FHD/2K/4K。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamObj(map, prefix + "ImageSpriteInfo.", this.ImageSpriteInfo);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
            this.SetParamSimple(map, prefix + "CoverUrl", this.CoverUrl);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

