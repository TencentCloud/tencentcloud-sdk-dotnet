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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixOutputParams : AbstractModel
    {
        
        /// <summary>
        /// 输出流名称。
        /// </summary>
        [JsonProperty("OutputStreamName")]
        public string OutputStreamName{ get; set; }

        /// <summary>
        /// 输出流类型，取值范围[0,1]。
        /// 不填默认为0。
        /// 当输出流为输入流 list 中的一条时，填写0。
        /// 当期望生成的混流结果成为一条新流时，该值填为1。
        /// 该值为1时，output_stream_id 不能出现在 input_stram_list 中，且直播后台中，不能存在相同 ID 的流。
        /// </summary>
        [JsonProperty("OutputStreamType")]
        public long? OutputStreamType{ get; set; }

        /// <summary>
        /// 输出流比特率。取值范围[1，50000]。
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputStreamBitRate")]
        public long? OutputStreamBitRate{ get; set; }

        /// <summary>
        /// 输出流GOP大小。取值范围[1,10]。
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputStreamGop")]
        public long? OutputStreamGop{ get; set; }

        /// <summary>
        /// 输出流帧率大小。取值范围[1,60]。
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputStreamFrameRate")]
        public long? OutputStreamFrameRate{ get; set; }

        /// <summary>
        /// 输出流音频比特率。取值范围[1,500]
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputAudioBitRate")]
        public long? OutputAudioBitRate{ get; set; }

        /// <summary>
        /// 输出流音频采样率。取值范围[96000, 88200, 64000, 48000, 44100, 32000,24000, 22050, 16000, 12000, 11025, 8000]。
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputAudioSampleRate")]
        public long? OutputAudioSampleRate{ get; set; }

        /// <summary>
        /// 输出流音频声道数。取值范围[1,2]。
        /// 不填的情况下，系统会自动判断。
        /// </summary>
        [JsonProperty("OutputAudioChannels")]
        public long? OutputAudioChannels{ get; set; }

        /// <summary>
        /// 输出流中的sei信息。如果无特殊需要，不填。
        /// </summary>
        [JsonProperty("MixSei")]
        public string MixSei{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputStreamName", this.OutputStreamName);
            this.SetParamSimple(map, prefix + "OutputStreamType", this.OutputStreamType);
            this.SetParamSimple(map, prefix + "OutputStreamBitRate", this.OutputStreamBitRate);
            this.SetParamSimple(map, prefix + "OutputStreamGop", this.OutputStreamGop);
            this.SetParamSimple(map, prefix + "OutputStreamFrameRate", this.OutputStreamFrameRate);
            this.SetParamSimple(map, prefix + "OutputAudioBitRate", this.OutputAudioBitRate);
            this.SetParamSimple(map, prefix + "OutputAudioSampleRate", this.OutputAudioSampleRate);
            this.SetParamSimple(map, prefix + "OutputAudioChannels", this.OutputAudioChannels);
            this.SetParamSimple(map, prefix + "MixSei", this.MixSei);
        }
    }
}

