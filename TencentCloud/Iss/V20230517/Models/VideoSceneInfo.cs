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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoSceneInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>分析周期（秒）：每隔多少秒从云端录像中截取一个视频片段进行分析。例如 Interval=3600、Duration=600，表示每隔1小时 取一个 10 分钟的视频片段进行分析。需满足 Duration ≤ Interval，否则相邻片段将重叠。取值范围［5,86400］。</p>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// <p>分析片段时长（秒）：每次分析截取的视频片段长度，即单次分析覆盖的视频时长。取值范围［5,12800］。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>抽帧率（FPS）：在片段内每隔1/Fps 秒截取一帧进行分析。取值越大，分析越精细，单次分析的帧数越多。默认值1，取值范围［0.1,1</p>
        /// </summary>
        [JsonProperty("Fps")]
        public float? Fps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
        }
    }
}

