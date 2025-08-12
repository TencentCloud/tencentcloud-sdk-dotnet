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

    public class ComplexAdaptiveDynamicStreamingTaskAudioInput : AbstractModel
    {
        
        /// <summary>
        /// 音频源的媒体 ID。固定取该媒体中的首个音频流，视频流和其它音频流（如有）将被忽略。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 输出的自适应码流中的音频流名称，长度限制为16个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 输出的自适应码流中的音频流语言，长度限制为16个字符。要求符合 RFC5646 规范。
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 是否设置为自适应码流的默认音频。取值：
        /// <li>YES：设置为默认音频；</li>
        /// <li>NO：不设置为默认音频（默认值）。</li>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 音轨序号，表示选择音频源中的第几个音轨，从0开始计数。默认值为0，表示选择最靠前的音轨。
        /// </summary>
        [JsonProperty("AudioTrackIdx")]
        public ulong? AudioTrackIdx{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "AudioTrackIdx", this.AudioTrackIdx);
        }
    }
}

