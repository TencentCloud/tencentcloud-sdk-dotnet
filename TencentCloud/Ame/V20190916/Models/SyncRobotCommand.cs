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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncRobotCommand : AbstractModel
    {
        
        /// <summary>
        /// 可同时传入多个指令，顺序执行。取值有：
        /// <li>Play：播放</li>
        /// <li>Pause：暂停</li>
        /// <li>SwitchPrevious：上一首</li>
        /// <li>SwitchNext：下一首</li>
        /// <li>SetPlayMode：设置播放模式</li>
        /// <li>Seek：调整播放进度</li>
        /// <li>SetPlaylist：歌单变更</li>
        /// <li>SetAudioParam：音频参数变更</li>
        /// <li>SendMessage：发送自定义消息</li>
        /// <li>SetDestroyMode：设置销毁模式</li>
        /// <li><del>SetVolume：设置音量</del>（已废弃，请采用 SetRealVolume）</li>
        /// <li>SetRealVolume：设置真实音量</li>
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 播放参数。
        /// </summary>
        [JsonProperty("PlayCommandInput")]
        public PlayCommandInput PlayCommandInput{ get; set; }

        /// <summary>
        /// 播放列表变更信息，当Command取SetPlaylist时，必填。
        /// </summary>
        [JsonProperty("SetPlaylistCommandInput")]
        public SetPlaylistCommandInput SetPlaylistCommandInput{ get; set; }

        /// <summary>
        /// 播放进度，当Command取Seek时，必填。
        /// </summary>
        [JsonProperty("SeekCommandInput")]
        public SeekCommandInput SeekCommandInput{ get; set; }

        /// <summary>
        /// 音频参数，当Command取SetAudioParam时，必填。
        /// </summary>
        [JsonProperty("SetAudioParamCommandInput")]
        public SetAudioParamCommandInput SetAudioParamCommandInput{ get; set; }

        /// <summary>
        /// 自定义消息，当Command取SendMessage时，必填。
        /// </summary>
        [JsonProperty("SendMessageCommandInput")]
        public SendMessageCommandInput SendMessageCommandInput{ get; set; }

        /// <summary>
        /// 播放模式，当Command取SetPlayMode时，必填。
        /// </summary>
        [JsonProperty("SetPlayModeCommandInput")]
        public SetPlayModeCommandInput SetPlayModeCommandInput{ get; set; }

        /// <summary>
        /// 销毁模式，当Command取SetDestroyMode时，必填。
        /// </summary>
        [JsonProperty("SetDestroyModeCommandInput")]
        public SetDestroyModeCommandInput SetDestroyModeCommandInput{ get; set; }

        /// <summary>
        /// <del>音量，当Command取SetVolume时，必填。</del>
        /// （已废弃，请采用 SetRealVolumeCommandInput）
        /// </summary>
        [JsonProperty("SetVolumeCommandInput")]
        public SetVolumeCommandInput SetVolumeCommandInput{ get; set; }

        /// <summary>
        /// 真实音量，当Command取SetRealVolume时，必填。
        /// </summary>
        [JsonProperty("SetRealVolumeCommandInput")]
        public SetRealVolumeCommandInput SetRealVolumeCommandInput{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "PlayCommandInput.", this.PlayCommandInput);
            this.SetParamObj(map, prefix + "SetPlaylistCommandInput.", this.SetPlaylistCommandInput);
            this.SetParamObj(map, prefix + "SeekCommandInput.", this.SeekCommandInput);
            this.SetParamObj(map, prefix + "SetAudioParamCommandInput.", this.SetAudioParamCommandInput);
            this.SetParamObj(map, prefix + "SendMessageCommandInput.", this.SendMessageCommandInput);
            this.SetParamObj(map, prefix + "SetPlayModeCommandInput.", this.SetPlayModeCommandInput);
            this.SetParamObj(map, prefix + "SetDestroyModeCommandInput.", this.SetDestroyModeCommandInput);
            this.SetParamObj(map, prefix + "SetVolumeCommandInput.", this.SetVolumeCommandInput);
            this.SetParamObj(map, prefix + "SetRealVolumeCommandInput.", this.SetRealVolumeCommandInput);
        }
    }
}

