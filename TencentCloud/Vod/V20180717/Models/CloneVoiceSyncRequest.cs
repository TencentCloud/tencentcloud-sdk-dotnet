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

    public class CloneVoiceSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>点播应用 ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

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
        /// <p>同步音色克隆拓展参数。<code>ExtParam</code> 支持的字段：</p><ul>  <li><code>text</code> (string)：试听合成文本，最大 <code>1000</code> 字符；非空时必须同时传 <code>tts_model</code>，克隆成功后返回试听音频 <code>DemoAudio</code>。</li>  <li><code>model</code> (string)：克隆模型，缺省 <code>minimax-voice-clone</code>。</li>  <li><code>tts_model</code> (string)：合成试听音频用的模型，可选 <code>minimax-speech-2.8-hd</code>、<code>minimax-speech-2.8-turbo</code>、<code>minimax-speech-2.6-hd</code>、<code>minimax-speech-2.6-turbo</code>、<code>minimax-speech-02-hd</code>、<code>minimax-speech-02-turbo</code>；<code>text</code> 非空时必填。</li>  <li><code>text_lang</code> (string)：试听文本语言。</li>  <li><code>voice_profile</code> (object)：音色画像，可选字段：    <ul>      <li><code>name</code> (string)：音色名称。</li>      <li><code>description</code> (string)：音色描述。</li>      <li><code>gender</code> (string)：性别，可选 <code>male</code> / <code>female</code> / <code>unknown</code>。</li>      <li><code>age</code> (string)：年龄段，可选 <code>child</code> / <code>teenager</code> / <code>youth</code> / <code>middle_aged</code> / <code>senior</code> / <code>unknown</code>。</li>      <li><code>languages</code> (string[])：支持语言，如 <code>["zh", "en"]</code>。</li>      <li><code>labels</code> (string[])：音色标签，如 <code>["磁性"]</code>。</li>      <li><code>scenes</code> (string[])：适用场景，如 <code>["解说"]</code>。</li>    </ul>  </li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioFileId", this.AudioFileId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

