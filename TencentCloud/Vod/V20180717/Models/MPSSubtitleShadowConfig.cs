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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSSubtitleShadowConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>文字阴影配置开关，0关闭，1开启，默认0</p>
        /// </summary>
        [JsonProperty("SubtitleShadowConfigSwitch")]
        public long? SubtitleShadowConfigSwitch{ get; set; }

        /// <summary>
        /// <p>阴影宽度，默认单位像素，底层默认值为0，无阴影</p>
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public float? ShadowWidth{ get; set; }

        /// <summary>
        /// <p>阴影宽度单位， 0 像素，1百分比，默认为0，像素</p>
        /// </summary>
        [JsonProperty("ShadowWidthUnit")]
        public long? ShadowWidthUnit{ get; set; }

        /// <summary>
        /// <p>阴影颜色。6位16进制RGB。不填默认黑色（有设置阴影的情况下）</p>
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// <p>阴影透明度。(0，1] 正浮点数。不填默认1，完全不透明（有设置阴影的情况下）</p>
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleShadowConfigSwitch", this.SubtitleShadowConfigSwitch);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowWidthUnit", this.ShadowWidthUnit);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
        }
    }
}

