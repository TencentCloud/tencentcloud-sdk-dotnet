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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrtcTimeNewUsage : AbstractModel
    {
        
        /// <summary>
        /// 时间点。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 通话人数。仅供参考。在线人数以仪表盘查询结果为准。
        /// </summary>
        [JsonProperty("VoiceUserNum")]
        public ulong? VoiceUserNum{ get; set; }

        /// <summary>
        /// 音视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("VideoTime")]
        public ulong? VideoTime{ get; set; }

        /// <summary>
        /// 标清视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("Class1VideoTime")]
        public ulong? Class1VideoTime{ get; set; }

        /// <summary>
        /// 高清视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("Class2VideoTime")]
        public ulong? Class2VideoTime{ get; set; }

        /// <summary>
        /// 超高清视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("Class3VideoTime")]
        public ulong? Class3VideoTime{ get; set; }

        /// <summary>
        /// 音频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("AudioTime")]
        public ulong? AudioTime{ get; set; }

        /// <summary>
        /// 带宽。单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// 2k视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("Video2KTime")]
        public ulong? Video2KTime{ get; set; }

        /// <summary>
        /// 4k视频通话时长。单位：秒。
        /// </summary>
        [JsonProperty("Video4KTime")]
        public ulong? Video4KTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "VoiceUserNum", this.VoiceUserNum);
            this.SetParamSimple(map, prefix + "VideoTime", this.VideoTime);
            this.SetParamSimple(map, prefix + "Class1VideoTime", this.Class1VideoTime);
            this.SetParamSimple(map, prefix + "Class2VideoTime", this.Class2VideoTime);
            this.SetParamSimple(map, prefix + "Class3VideoTime", this.Class3VideoTime);
            this.SetParamSimple(map, prefix + "AudioTime", this.AudioTime);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Video2KTime", this.Video2KTime);
            this.SetParamSimple(map, prefix + "Video4KTime", this.Video4KTime);
        }
    }
}

