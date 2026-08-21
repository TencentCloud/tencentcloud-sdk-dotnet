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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectEnvAndSoundQualityRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>标注文本信息 ID</p>
        /// </summary>
        [JsonProperty("TextId")]
        public string TextId{ get; set; }

        /// <summary>
        /// <p>语音数据 要使用base64编码(采用python语言时注意读取文件时需要转成base64字符串编码，例如：str(base64.b64encode(open(&quot;input.aac&quot;, mode=&quot;rb&quot;).read()), encoding=&#39;utf-8&#39;) )。</p>
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// <p>1:环境检测 2:音质检测</p>
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }

        /// <summary>
        /// <p>音频格式，音频类型(wav,mp3,aac,m4a)</p>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>音频采样率。<br>16000：16k（默认）；<br>24000：24k（仅一句话声音复刻支持）；<br>48000：48k（仅一句话声音复刻支持）。</p>
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// <p>复刻类型。5 - 一句话声音复刻。</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TextId", this.TextId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

