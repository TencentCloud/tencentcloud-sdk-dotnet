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

    public class GenerateLiveAvatarScriptBroadcastRequest : AbstractModel
    {
        
        /// <summary>
        /// 数字人直播间 ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 话术 ID。
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 音色 Key。如果不填，则默认使用数字人直播已经保存的音色。
        /// </summary>
        [JsonProperty("TimbreKey")]
        public string TimbreKey{ get; set; }

        /// <summary>
        /// 语速（1.0为正常语速，范围[0.6-2.5]，值为0.6时播报语速最慢，值为2.5时播报语速最快。不传默认使用数字人直播间已设置的语速。
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }

        /// <summary>
        /// 音量大小，范围[0，10]，对应音量大小。默认为5，代表正常音量，值越大音量越高。不传使用数字人直播已设置的音量。
        /// </summary>
        [JsonProperty("SpeechVolume")]
        public long? SpeechVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "TimbreKey", this.TimbreKey);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
            this.SetParamSimple(map, prefix + "SpeechVolume", this.SpeechVolume);
        }
    }
}

