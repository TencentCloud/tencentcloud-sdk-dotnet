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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TurnPushInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频帧率，单位fps。
        /// </summary>
        [JsonProperty("VideoFps")]
        public long? VideoFps{ get; set; }

        /// <summary>
        /// 音频帧率，单位fps。
        /// </summary>
        [JsonProperty("AudioFps")]
        public long? AudioFps{ get; set; }

        /// <summary>
        /// 视频码率，单位bps。
        /// </summary>
        [JsonProperty("VideoRate")]
        public long? VideoRate{ get; set; }

        /// <summary>
        /// 音频码率，单位bps。
        /// </summary>
        [JsonProperty("AudioRate")]
        public long? AudioRate{ get; set; }

        /// <summary>
        /// 流标识。
        /// </summary>
        [JsonProperty("StreamFlag")]
        public string StreamFlag{ get; set; }

        /// <summary>
        /// 时间，utc格式：yyyy-mm-ddTHH:MM:SSZ，参考https://cloud.tencent.com/document/product/266/11732#I。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoFps", this.VideoFps);
            this.SetParamSimple(map, prefix + "AudioFps", this.AudioFps);
            this.SetParamSimple(map, prefix + "VideoRate", this.VideoRate);
            this.SetParamSimple(map, prefix + "AudioRate", this.AudioRate);
            this.SetParamSimple(map, prefix + "StreamFlag", this.StreamFlag);
            this.SetParamSimple(map, prefix + "Time", this.Time);
        }
    }
}

