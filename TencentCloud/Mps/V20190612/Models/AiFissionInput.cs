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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiFissionInput : AbstractModel
    {
        
        /// <summary>
        /// <p>视频裂变参考图url</p>
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// <p>视频裂变商品信息参考文案</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamSimple(map, prefix + "Text", this.Text);
        }
    }
}

