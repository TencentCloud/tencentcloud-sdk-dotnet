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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingWatermark : AbstractModel
    {
        
        /// <summary>
        /// 水印类型，可选值：
        /// <li>Image：图像水印；</li>
        /// <li>Text：文字水印。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 图像水印信息，当 Type=Image 时必选。
        /// </summary>
        [JsonProperty("Image")]
        public MediaCuttingWatermarkImage Image{ get; set; }

        /// <summary>
        /// 文字水印信息，当 Type=Text 时必选。
        /// </summary>
        [JsonProperty("Text")]
        public MediaCuttingWatermarkText Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "Text.", this.Text);
        }
    }
}

