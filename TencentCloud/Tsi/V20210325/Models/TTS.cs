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

namespace TencentCloud.Tsi.V20210325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TTS : AbstractModel
    {
        
        /// <summary>
        /// 返回音频格式，可取值：wav，mp3，pcm
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 音色 ID，只包括标准音色（注，日文只有一个固定音色）。
        /// 完整的音色 ID 列表请参见[音色列表](https://cloud.tencent.com/document/product/1073/92668)。
        /// </summary>
        [JsonProperty("VoiceType")]
        public ulong? VoiceType{ get; set; }

        /// <summary>
        /// 音量大小，范围[-10，10]，对应音量大小。默认为0，代表正常音量，值越大音量越高。
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// 语速，范围：[-2，6]，分别对应不同语速：
        /// 
        /// - -2代表0.6倍
        /// - -1代表0.8倍
        /// - 0代表1.0倍（默认）
        /// - 1代表1.2倍
        /// - 2代表1.5倍
        /// - 6代表2.5倍
        /// 
        /// 如果需要更细化的语速，可以保留小数点后 2 位，例如0.5/1.25/2.81等。
        /// 参数值与实际语速转换，可参考[代码示例](https://sdk-1300466766.cos.ap-shanghai.myqcloud.com/sample/speed_sample.tar.gz)
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 音频采样率：
        /// 
        /// - 16000：16k（默认）
        /// - 8000：8k
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
        }
    }
}

