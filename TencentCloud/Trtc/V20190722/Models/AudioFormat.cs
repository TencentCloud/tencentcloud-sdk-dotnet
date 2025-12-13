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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioFormat : AbstractModel
    {
        
        /// <summary>
        /// 生成的音频格式
        /// 
        /// - TextToSpeech流式接口
        /// 
        ///  支持 pcm, 默认: pcm
        /// 
        /// - TextToSpeech非流式接口
        /// 
        ///  支持 pcm,wav,  默认: pcm
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 生成的音频采样率，默认24000
        /// 可选
        /// - 16000
        /// - 24000 
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
        }
    }
}

