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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncDubbingRequest : AbstractModel
    {
        
        /// <summary>
        /// 合成文本，语音合成时必填，文本长度不超过2000字符
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文本语言，不填默认中文。
        /// 当前支持语言：
        /// zh	中文 (Chinese)
        /// en	英语 (English)
        /// ja	日语 (Japanese)
        /// de	德语 (German)
        /// fr	法语 (French)
        /// ko	韩语 (Korean)
        /// ru	俄语 (Russian)
        /// uk	乌克兰语 (Ukrainian)
        /// pt	葡萄牙语 (Portuguese)
        /// it	意大利语 (Italian)
        /// es	西班牙语 (Spanish)
        /// id	印度尼西亚语 (Indonesian)
        /// nl	荷兰语 (Dutch)
        /// tr	土耳其语 (Turkish)
        /// fil	菲律宾语 (Filipino)
        /// ms	马来语 (Malay)
        /// el	希腊语 (Greek)
        /// fi	芬兰语 (Finnish)
        /// hr	克罗地亚语 (Croatian)
        /// sk	斯洛伐克语 (Slovak)
        /// pl	波兰语 (Polish)
        /// sv	瑞典语 (Swedish)
        /// hi	印地语 (Hindi)
        /// bg	保加利亚语 (Bulgarian)
        /// ro	罗马尼亚语 (Romanian)
        /// ar	阿拉伯语 (Arabic)
        /// cs	捷克语 (Czech)
        /// da	丹麦语 (Danish)
        /// ta	泰米尔语 (Tamil)
        /// hun	匈牙利语（Hungarian）
        /// vi	越南语（Vietnamese）
        /// no	挪威语（Norwegian）
        /// yue	粤语（Cantonese）
        /// th	泰语（Thai）
        /// he	希伯来语（Hebrew）
        /// ca	加泰罗尼亚语（Catalan）
        /// nn	尼诺斯克语（Nynorsk）
        /// af	阿非利卡语（Afrikaans）
        /// fa	波斯语（Persian）
        /// sl	斯洛文尼亚语（Slovenian）
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// 音色Id，指定音色合成时填写，支持系统音色和克隆音色。
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// 克隆音频base64编码。
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// 克隆音频语言，默认中文。
        /// 当前支持语言同TextLang
        /// </summary>
        [JsonProperty("AudioLang")]
        public string AudioLang{ get; set; }

        /// <summary>
        /// 扩展参数，json字符串
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioLang", this.AudioLang);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

