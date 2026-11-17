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

    public class CloneVoiceAsyncRequest : AbstractModel
    {
        
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
        /// <p>克隆音频base64编码。</p>
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// <p>克隆音频Url，AudioData为空时有效</p>
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// <p>克隆文件FileID，AudioData及AudioUrl为空时有效</p>
        /// </summary>
        [JsonProperty("AudioFileId")]
        public string AudioFileId{ get; set; }

        /// <summary>
        /// <p>语言增强，如 "zh" "en" "auto"，默认 "auto"</p>
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p><strong>ExtParam</strong> JSON 字符串字段，用于指定各模型的高级音色参数。</p><hr><h3 id="Clone">通用参数</h3><ul><li>text（string）：试听文本，最大 1000 字符；传入后返回试听音频 DemoAudio</li><li>tts_model（string）：试听文本合成模型，text 非空时必填；按 ModelName 模型系列白名单校验</li><li>text_lang（string）：试听文本语言，如 zh</li><li>voice_profile.name（string）：音色名称</li><li>voice_profile.description（string）：音色描述</li><li>voice_profile.gender（string）：性别，可选 male、female、unknown</li><li>voice_profile.age（string）：年龄段，可选 child、teenager、youth、middle_aged、senior、unknown</li><li>voice_profile.languages（array of string）：语言，如 ["zh"]</li><li>voice_profile.labels（array of string）：标签，如 ["磁性"]</li><li>voice_profile.scenes（array of string）：场景，如 ["解说"]</li></ul><hr><h3 id="CloneElevenLabs">ElevenLabs</h3><ul><li>voice_name（string）：音色名称；未传时回退取 voice_profile.name，两者都缺时使用默认名称</li><li>description（string）：音色描述；未传时回退取 voice_profile.description</li><li>labels（map&lt;string,string&gt;）：音色标签，官方推荐键 language、accent、gender、age；最多 16 项，键值各不超过 256 字节</li><li>remove_background_noise（boolean）：是否用音频隔离模型去除背景噪声，默认 false；样本本身无噪声时开启可能降低质量</li></ul><hr>
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
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioFileId", this.AudioFileId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

