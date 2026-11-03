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

    public class CreateVRSTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>唯一请求 ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>音色名称</p>
        /// </summary>
        [JsonProperty("VoiceName")]
        public string VoiceName{ get; set; }

        /// <summary>
        /// <p>音色性别:</p><p>1-male</p><p>2-female</p>
        /// </summary>
        [JsonProperty("VoiceGender")]
        public long? VoiceGender{ get; set; }

        /// <summary>
        /// <p>语言类型：</p><p>1-中文</p>
        /// </summary>
        [JsonProperty("VoiceLanguage")]
        public long? VoiceLanguage{ get; set; }

        /// <summary>
        /// <p>音频ID集合。（一句话声音复刻仅需填写一个音质检测接口返回的AudioId）</p>
        /// </summary>
        [JsonProperty("AudioIdList")]
        public string[] AudioIdList{ get; set; }

        /// <summary>
        /// <p>音频采样率：</p><p>16000：16k</p>
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// <p>音频格式，音频类型(wav,mp3,aac,m4a)</p>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>回调 URL，用户自行搭建的用于接收结果的服务URL。如果用户使用轮询方式获取识别结果，则无需提交该参数。（注意：回调方式暂不支持一句话版声音复刻）<br>回调采用POST请求方式，Content-Type为application/json，回调数据格式如下:{&quot;TaskId&quot;:&quot;xxxxxxxxxxxxxx&quot;,&quot;Status&quot;:2,&quot;StatusStr&quot;:&quot;success&quot;,&quot;VoiceType&quot;:xxxxx,&quot;ErrorMsg&quot;:&quot;&quot;}</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>模型类型 1:在线 2:离线  默认为1</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// <p>复刻类型。<br>5 - 一句话声音复刻。</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// <p>校验音频ID。（仅基础版声音复刻使用）</p>
        /// </summary>
        [JsonProperty("VPRAudioId")]
        public string VPRAudioId{ get; set; }

        /// <summary>
        /// <p>是否开启语音增强，0 - 关闭，1 - 开启 。默认关闭<br>语音增强仅适用于一句话复刻场景</p>
        /// </summary>
        [JsonProperty("EnableVoiceEnhance")]
        public ulong? EnableVoiceEnhance{ get; set; }

        /// <summary>
        /// <p>模型引擎，可选值：</p><ul><li><p>WXZL（默认）</p></li><li><p>YTLX_V2（新版）</p></li></ul><p>示例：YTLX_V2</p>
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "VoiceName", this.VoiceName);
            this.SetParamSimple(map, prefix + "VoiceGender", this.VoiceGender);
            this.SetParamSimple(map, prefix + "VoiceLanguage", this.VoiceLanguage);
            this.SetParamArraySimple(map, prefix + "AudioIdList.", this.AudioIdList);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "VPRAudioId", this.VPRAudioId);
            this.SetParamSimple(map, prefix + "EnableVoiceEnhance", this.EnableVoiceEnhance);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
        }
    }
}

