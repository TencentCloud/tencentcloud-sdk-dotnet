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

    public class SubtitleTemplate : AbstractModel
    {
        
        /// <summary>
        /// 要压制到视频中的字幕文件地址。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 指定要压制到视频中的字幕轨道，如果有指定Path，则Path 优先级更高。Path 和 StreamIndex 至少指定一个。
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// 字体类型，
        /// <li>hei.ttf：黑体</li>
        /// <li>song.ttf：宋体</li>
        /// <li>simkai.ttf：楷体</li>
        /// <li>arial.ttf：仅支持英文</li>
        /// 默认hei.ttf
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 字体大小，格式：Npx，N 为数值，不指定则以字幕文件中为准。
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// 字体颜色，格式：0xRRGGBB，默认值：0xFFFFFF（白色）
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 文字透明度，取值范围：(0, 1]
        /// <li>0：完全透明</li>
        /// <li>1：完全不透明</li>
        /// 默认值：1。
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
        }
    }
}

