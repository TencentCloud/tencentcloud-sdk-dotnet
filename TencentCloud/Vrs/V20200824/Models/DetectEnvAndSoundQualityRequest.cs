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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectEnvAndSoundQualityRequest : AbstractModel
    {
        
        /// <summary>
        /// 标注文本信息 ID
        /// </summary>
        [JsonProperty("TextId")]
        public string TextId{ get; set; }

        /// <summary>
        /// 语音数据 要使用base64编码(采用python语言时注意读取文件时需要转成base64字符串编码，例如：str(base64.b64encode(open("input.aac", mode="rb").read()), encoding='utf-8') )。
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// 音频格式，音频类型(wav,mp3,aac,m4a)
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 1:环境检测 2:音质检测
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }

        /// <summary>
        /// 音频采样率：
        /// 
        /// 16000：16k（默认）
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TextId", this.TextId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
        }
    }
}

