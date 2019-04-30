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

namespace TencentCloud.Tbp.V20190311.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PostAudioRequest : AbstractModel
    {
        
        /// <summary>
        /// 机器人标识
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 语音识别引擎类型,{8k_0、16k_0、16k_en}
        /// </summary>
        [JsonProperty("EngineModelType")]
        public string EngineModelType{ get; set; }

        /// <summary>
        /// 输入音频文件编码格式。1：wav(pcm)；4：speex(sp)；6：silk
        /// </summary>
        [JsonProperty("AsrVoiceFormat")]
        public ulong? AsrVoiceFormat{ get; set; }

        /// <summary>
        /// asr请求Id。长度为16位的字符串，同一句话VoiceId保持一致
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// 语音分片序列号。同一句话必须从0开始，依次递增
        /// </summary>
        [JsonProperty("Seq")]
        public ulong? Seq{ get; set; }

        /// <summary>
        /// 是否为尾包。传递最后一个语音分片时为true，其他为false
        /// </summary>
        [JsonProperty("IsEnd")]
        public bool? IsEnd{ get; set; }

        /// <summary>
        /// 待识别音频字节流
        /// </summary>
        [JsonProperty("WaveData")]
        public string WaveData{ get; set; }

        /// <summary>
        /// 子账户id，每个终端对应一个
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 机器人版本号。BotVersion/BotEnv二选一：二者均填，仅BotVersion有效；二者均不填，默认BotEnv=dev
        /// </summary>
        [JsonProperty("BotVersion")]
        public string BotVersion{ get; set; }

        /// <summary>
        /// 识别返回文本编码格式	0：UTF-8（默认）；1：GB2312；2：GBK；3：BIG5
        /// </summary>
        [JsonProperty("ResultTextFormat")]
        public ulong? ResultTextFormat{ get; set; }

        /// <summary>
        /// 透传字段，传递给后台
        /// </summary>
        [JsonProperty("SessionAttributes")]
        public string SessionAttributes{ get; set; }

        /// <summary>
        /// 是否将机器人回答合成音频并返回url
        /// </summary>
        [JsonProperty("NeedTts")]
        public bool? NeedTts{ get; set; }

        /// <summary>
        /// 音量大小，范围：[0，10]。默认值为0，代表正常音量
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// 语速，范围：[-2，2]。0代表1.0倍
        /// </summary>
        [JsonProperty("Speed")]
        public long? Speed{ get; set; }

        /// <summary>
        /// 音色,{0：女声,1:男声}
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 返回音频的采样率{8k,16k}。默认16k
        /// </summary>
        [JsonProperty("SampleRate")]
        public string SampleRate{ get; set; }

        /// <summary>
        /// 机器人环境{dev:测试;release:线上}。BotVersion/BotEnv二选一：二者均填，仅BotVersion有效；二者均不填，默认BotEnv=dev
        /// </summary>
        [JsonProperty("BotEnv")]
        public string BotEnv{ get; set; }

        /// <summary>
        /// TTS合成音频格式，{0：wav}。该字段在当前版本仅支持取值为0。
        /// </summary>
        [JsonProperty("TtsVoiceFormat")]
        public ulong? TtsVoiceFormat{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "EngineModelType", this.EngineModelType);
            this.SetParamSimple(map, prefix + "AsrVoiceFormat", this.AsrVoiceFormat);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "WaveData", this.WaveData);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "BotVersion", this.BotVersion);
            this.SetParamSimple(map, prefix + "ResultTextFormat", this.ResultTextFormat);
            this.SetParamSimple(map, prefix + "SessionAttributes", this.SessionAttributes);
            this.SetParamSimple(map, prefix + "NeedTts", this.NeedTts);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "BotEnv", this.BotEnv);
            this.SetParamSimple(map, prefix + "TtsVoiceFormat", this.TtsVoiceFormat);
        }
    }
}

