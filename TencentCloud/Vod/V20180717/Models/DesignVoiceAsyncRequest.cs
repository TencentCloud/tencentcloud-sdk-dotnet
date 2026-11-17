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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DesignVoiceAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>音色描述</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>点播应用 ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>模型名，不填默认为MiniMax模型。</p> 枚举值： <ul><li>MiniMax</li><li>ElevenLabs</li></ul>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>音色设置</p>
        /// </summary>
        [JsonProperty("VoiceSettings")]
        public VoiceSettings VoiceSettings{ get; set; }

        /// <summary>
        /// <p>试听合成文本，最大 500 字符</p>
        /// </summary>
        [JsonProperty("PreviewText")]
        public string PreviewText{ get; set; }

        /// <summary>
        /// <p><strong>ExtParam</strong> JSON 字符串字段，用于指定各模型的高级设计参数。</p><hr><h3 id="ElevenLabs">ElevenLabs</h3><ul><li>model_id（string）：TTV 模型，可选 eleven_multilingual_ttv_v2（默认）、eleven_ttv_v3</li><li>voice_name（string）：音色名称，用于设计完成后正式创建音色</li><li>labels（map&lt;string,string&gt;）：音色标签，最多 16 项，键值各不超过 256 字节</li><li>auto_generate_text（boolean）：是否自动生成与描述匹配的试听文本，默认 false</li><li>loudness（float）：音量，取值范围 [-1, 1]，默认 0.5</li><li>seed（integer）：采样种子，取值范围 [0, 2147483647]</li><li>guidance_scale（float）：提示词遵循程度，取值范围 [0, 100]，默认 5</li><li>quality（float）：输出质量，取值范围 [-1, 1]，越高质量越好但多样性越低</li><li>should_enhance（boolean）：是否用 AI 扩写音色描述，默认 false</li><li>reference_audio_base64（string）：参考音频 base64，仅 eleven_ttv_v3 支持</li><li>prompt_strength（float）：提示词与参考音频权重，取值范围 [0, 1]，仅 eleven_ttv_v3 支持</li><li>audio_setting.format（string）：音频格式，可选 mp3、opus、alaw、pcm</li><li>audio_setting.sample_rate（integer）：采样率，与 format 组合受限</li><li>audio_setting.bitrate（integer）：比特率，需与 format、sample_rate 匹配</li></ul><hr>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }

        /// <summary>
        /// <p>标识来源上下文，用于透传用户请求信息，在回调和任务流状态变更回调将返回该字段值，最长 1000 个字符。</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>用于任务去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamObj(map, prefix + "VoiceSettings.", this.VoiceSettings);
            this.SetParamSimple(map, prefix + "PreviewText", this.PreviewText);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

