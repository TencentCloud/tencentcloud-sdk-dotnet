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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeMediaConfig : AbstractModel
    {
        
        /// <summary>
        /// 合成目标视频信息。
        /// </summary>
        [JsonProperty("TargetInfo")]
        public ComposeTargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// 合成目标视频的画布信息。
        /// </summary>
        [JsonProperty("Canvas")]
        public ComposeCanvas Canvas{ get; set; }

        /// <summary>
        /// 全局样式，和轨道 Tracks 配合使用，用于定于样式，如字幕样式。
        /// </summary>
        [JsonProperty("Styles")]
        public ComposeStyles[] Styles{ get; set; }

        /// <summary>
        /// 用于描述合成视频的轨道列表，包括：视频、音频、图片、文字等元素组成的多个轨道信息。关于轨道和时间：
        /// <ul><li>轨道时间轴即为目标视频时间轴。</li><li>时间轴上相同时间点的不同轨道上的元素会重叠：</li><ul><li>视频、图片、文字：按轨道顺序进行图像的叠加，轨道顺序靠前的在上面。</li><li>音频 ：进行混音。</li></ul></ul>注意：同一轨道中各个元素（除字幕元素外）的轨道时间不能重叠。
        /// </summary>
        [JsonProperty("Tracks")]
        public ComposeMediaTrack[] Tracks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamObj(map, prefix + "Canvas.", this.Canvas);
            this.SetParamArrayObj(map, prefix + "Styles.", this.Styles);
            this.SetParamArrayObj(map, prefix + "Tracks.", this.Tracks);
        }
    }
}

