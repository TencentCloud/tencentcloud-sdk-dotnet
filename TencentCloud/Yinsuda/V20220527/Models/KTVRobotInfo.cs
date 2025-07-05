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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KTVRobotInfo : AbstractModel
    {
        
        /// <summary>
        /// 机器人Id。
        /// </summary>
        [JsonProperty("RobotId")]
        public string RobotId{ get; set; }

        /// <summary>
        /// 状态，取值有：
        /// <li>Play：播放</li>
        /// <li>Pause：暂停</li>
        /// <li>Destroy：销毁</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 播放列表。
        /// </summary>
        [JsonProperty("Playlists")]
        public string[] Playlists{ get; set; }

        /// <summary>
        /// 当前歌单索引位置。
        /// </summary>
        [JsonProperty("CurIndex")]
        public long? CurIndex{ get; set; }

        /// <summary>
        /// 播放进度，单位：毫秒。
        /// </summary>
        [JsonProperty("Position")]
        public ulong? Position{ get; set; }

        /// <summary>
        /// 音频参数。
        /// </summary>
        [JsonProperty("SetAudioParamInput")]
        public SetAudioParamCommandInput SetAudioParamInput{ get; set; }

        /// <summary>
        /// 进房信息。
        /// </summary>
        [JsonProperty("JoinRoomInput")]
        public JoinRoomInput JoinRoomInput{ get; set; }

        /// <summary>
        /// RTC厂商类型，取值有：
        /// <li>TRTC</li>
        /// </summary>
        [JsonProperty("RTCSystem")]
        public string RTCSystem{ get; set; }

        /// <summary>
        /// 播放模式，PlayMode取值有：
        /// <li>RepeatPlaylist：列表循环</li>
        /// <li>Order：顺序播放</li>
        /// <li>RepeatSingle：单曲循环</li>
        /// <li>Shuffle：随机播放</li>
        /// </summary>
        [JsonProperty("SetPlayModeInput")]
        public SetPlayModeCommandInput SetPlayModeInput{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RobotId", this.RobotId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Playlists.", this.Playlists);
            this.SetParamSimple(map, prefix + "CurIndex", this.CurIndex);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamObj(map, prefix + "SetAudioParamInput.", this.SetAudioParamInput);
            this.SetParamObj(map, prefix + "JoinRoomInput.", this.JoinRoomInput);
            this.SetParamSimple(map, prefix + "RTCSystem", this.RTCSystem);
            this.SetParamObj(map, prefix + "SetPlayModeInput.", this.SetPlayModeInput);
        }
    }
}

