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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoBasicInformation : AbstractModel
    {
        
        /// <summary>
        /// 视频宽度
        /// </summary>
        [JsonProperty("FrameWidth")]
        public long? FrameWidth{ get; set; }

        /// <summary>
        /// 视频高度
        /// </summary>
        [JsonProperty("FrameHeight")]
        public long? FrameHeight{ get; set; }

        /// <summary>
        /// 视频帧速率(FPS)
        /// </summary>
        [JsonProperty("FramesPerSecond")]
        public long? FramesPerSecond{ get; set; }

        /// <summary>
        /// 视频时长
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 视频帧数
        /// </summary>
        [JsonProperty("TotalFrames")]
        public long? TotalFrames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FrameWidth", this.FrameWidth);
            this.SetParamSimple(map, prefix + "FrameHeight", this.FrameHeight);
            this.SetParamSimple(map, prefix + "FramesPerSecond", this.FramesPerSecond);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "TotalFrames", this.TotalFrames);
        }
    }
}

