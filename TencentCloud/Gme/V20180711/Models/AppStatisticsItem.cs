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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppStatisticsItem : AbstractModel
    {
        
        /// <summary>
        /// 实时语音统计数据
        /// </summary>
        [JsonProperty("RealtimeSpeechStatisticsItem")]
        public RealTimeSpeechStatisticsItem RealtimeSpeechStatisticsItem{ get; set; }

        /// <summary>
        /// 语音消息统计数据
        /// </summary>
        [JsonProperty("VoiceMessageStatisticsItem")]
        public VoiceMessageStatisticsItem VoiceMessageStatisticsItem{ get; set; }

        /// <summary>
        /// 语音过滤统计数据
        /// </summary>
        [JsonProperty("VoiceFilterStatisticsItem")]
        public VoiceFilterStatisticsItem VoiceFilterStatisticsItem{ get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 录音转文本用量统计数据
        /// </summary>
        [JsonProperty("AudioTextStatisticsItem")]
        public AudioTextStatisticsItem AudioTextStatisticsItem{ get; set; }

        /// <summary>
        /// 流式转文本用量数据
        /// </summary>
        [JsonProperty("StreamTextStatisticsItem")]
        public StreamTextStatisticsItem StreamTextStatisticsItem{ get; set; }

        /// <summary>
        /// 海外转文本用量数据
        /// </summary>
        [JsonProperty("OverseaTextStatisticsItem")]
        public OverseaTextStatisticsItem OverseaTextStatisticsItem{ get; set; }

        /// <summary>
        /// 实时语音转文本用量数据
        /// </summary>
        [JsonProperty("RealtimeTextStatisticsItem")]
        public RealtimeTextStatisticsItem RealtimeTextStatisticsItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RealtimeSpeechStatisticsItem.", this.RealtimeSpeechStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceMessageStatisticsItem.", this.VoiceMessageStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceFilterStatisticsItem.", this.VoiceFilterStatisticsItem);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamObj(map, prefix + "AudioTextStatisticsItem.", this.AudioTextStatisticsItem);
            this.SetParamObj(map, prefix + "StreamTextStatisticsItem.", this.StreamTextStatisticsItem);
            this.SetParamObj(map, prefix + "OverseaTextStatisticsItem.", this.OverseaTextStatisticsItem);
            this.SetParamObj(map, prefix + "RealtimeTextStatisticsItem.", this.RealtimeTextStatisticsItem);
        }
    }
}

