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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddOnAudio : AbstractModel
    {
        
        /// <summary>
        /// <p>音频文件输入信息。注意：（1）音频流的编码格式支持：aac、ac3、eac3、flac、opus和mp3；（2）当转自适应码流模板中设置的切片类型为ts的时候，音频流的编码格式不能为flac。</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>音轨名称，如：中文、English。注意：仅支持中文、英文、数字、空格、下划线(_)、短横线(-)、句点(.)和中英文括号，长度不能超过64个字符。</p>
        /// </summary>
        [JsonProperty("AudioName")]
        public string AudioName{ get; set; }

        /// <summary>
        /// <p>音轨语言，如：chi、eng，遵循 ISO 639-2</p>
        /// </summary>
        [JsonProperty("AudioLanguage")]
        public string AudioLanguage{ get; set; }

        /// <summary>
        /// <p>默认音频轨道。为true时指定当前音频为默认音频轨道，最多可指定1条默认音频轨道。</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("DefaultTrack")]
        public bool? DefaultTrack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "AudioName", this.AudioName);
            this.SetParamSimple(map, prefix + "AudioLanguage", this.AudioLanguage);
            this.SetParamSimple(map, prefix + "DefaultTrack", this.DefaultTrack);
        }
    }
}

