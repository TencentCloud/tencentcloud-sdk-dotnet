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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageMaterial : AbstractModel
    {
        
        /// <summary>
        /// 图片高度，单位：px。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 图片宽度，单位：px。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 素材媒体文件的展示 URL 地址。
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }

        /// <summary>
        /// 图片大小，单位：字节。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 素材媒体文件的原始 URL 地址。
        /// </summary>
        [JsonProperty("OriginalUrl")]
        public string OriginalUrl{ get; set; }

        /// <summary>
        /// 云点播媒资 FileId。
        /// </summary>
        [JsonProperty("VodFileId")]
        public string VodFileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "OriginalUrl", this.OriginalUrl);
            this.SetParamSimple(map, prefix + "VodFileId", this.VodFileId);
        }
    }
}

