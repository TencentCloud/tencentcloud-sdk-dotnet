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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackgroundImageConfig : AbstractModel
    {
        
        /// <summary>
        /// 横图(pc)
        /// </summary>
        [JsonProperty("LandscapeImageUrl")]
        public string LandscapeImageUrl{ get; set; }

        /// <summary>
        /// 原始图
        /// </summary>
        [JsonProperty("OriginalImageUrl")]
        public string OriginalImageUrl{ get; set; }

        /// <summary>
        /// 长图(手机)
        /// </summary>
        [JsonProperty("PortraitImageUrl")]
        public string PortraitImageUrl{ get; set; }

        /// <summary>
        /// 主题色
        /// </summary>
        [JsonProperty("ThemeColor")]
        public string ThemeColor{ get; set; }

        /// <summary>
        /// 亮度值
        /// </summary>
        [JsonProperty("Brightness")]
        public long? Brightness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LandscapeImageUrl", this.LandscapeImageUrl);
            this.SetParamSimple(map, prefix + "OriginalImageUrl", this.OriginalImageUrl);
            this.SetParamSimple(map, prefix + "PortraitImageUrl", this.PortraitImageUrl);
            this.SetParamSimple(map, prefix + "ThemeColor", this.ThemeColor);
            this.SetParamSimple(map, prefix + "Brightness", this.Brightness);
        }
    }
}

