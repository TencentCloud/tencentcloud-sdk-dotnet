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

    public class Voice : AbstractModel
    {
        
        /// <summary>
        /// <p>音色 ID，可从音色列表获取，或使用声音克隆生成的自定义音色 ID</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>语速调节，0.5 为半速慢放，2.0 为两倍速快放，1.0 为正常语速，区间：[0.5, 2.0]，默认1.0</p>
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// <p>音量调节，默认1.0，10 为最大音量，建议保持默认值 1.0，区间：(0, 10]</p>
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// <p>音高调节，负值声音更低沉，正值声音更尖锐，0 为原始音高，区间 [-12, 12],  默认0</p>
        /// </summary>
        [JsonProperty("Pitch")]
        public long? Pitch{ get; set; }

        /// <summary>
        /// <p>情绪控制，目前仅flow_01_ex模型支持</p><p>枚举值：</p><ul><li>happy： 高兴</li><li>sad： 悲伤</li><li>angry： 愤怒</li><li>fearful： 害怕</li><li>disgusted： 厌恶</li><li>surprised： 惊讶</li><li>calm： 中性</li><li>fluent： 生动</li><li>whisper： 低语</li></ul>
        /// </summary>
        [JsonProperty("Emotion")]
        public string Emotion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
            this.SetParamSimple(map, prefix + "Emotion", this.Emotion);
        }
    }
}

