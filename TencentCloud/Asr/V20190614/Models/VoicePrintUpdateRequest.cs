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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoicePrintUpdateRequest : AbstractModel
    {
        
        /// <summary>
        /// 音频格式 0: pcm, 1: wav
        /// </summary>
        [JsonProperty("VoiceFormat")]
        public long? VoiceFormat{ get; set; }

        /// <summary>
        /// 音频采样率 目前仅支持16000 单位Hz
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 说话人id， 说话人唯一标识
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 音频数据, base64 编码, 音频时长不能超过30s，数据大小不超过2M	
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 说话人昵称  不超过32字节
        /// </summary>
        [JsonProperty("SpeakerNick")]
        public string SpeakerNick{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoiceFormat", this.VoiceFormat);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "SpeakerNick", this.SpeakerNick);
        }
    }
}

