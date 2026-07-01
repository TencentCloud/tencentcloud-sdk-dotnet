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

    public class TextToSpeechRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要转语音的文字内容，最大支持2000字符</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>文本转语音的声音配置</p>
        /// </summary>
        [JsonProperty("Voice")]
        public Voice Voice{ get; set; }

        /// <summary>
        /// <p>TRTC的SdkAppId</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>文本转语音的输出音频的格式</p>
        /// </summary>
        [JsonProperty("AudioFormat")]
        public AudioFormat AudioFormat{ get; set; }

        /// <summary>
        /// <p>TTS的API密钥</p>
        /// </summary>
        [JsonProperty("APIKey")]
        [System.Obsolete]
        public string APIKey{ get; set; }

        /// <summary>
        /// <p>TTS的模型，支持flow_02_turbo，flow_01_ex，默认为flow_02_turbo</p><p>枚举值：</p><ul><li>flow_02_turbo： 高性价比模型，兼顾效果和成本</li><li>flow_01_ex： 高天花板模型，能力全面，在音色克隆上表现更优</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>需要合成的语言，默认为空，表示自动识别</p><p>flow_02_turbo支持以下语言：</p><ul><li>zh：中文</li><li>en：英文</li><li>ja：日语</li><li>ko：韩语</li><li>yue：粤语</li><li>ms：马来语</li><li>ar：阿拉伯语</li><li>id：印尼语</li><li>th：泰语</li><li>vi：越南语</li></ul><p>flow_01_ex支持以下语言：</p><ul><li>zh：中文（简体） (Chinese Simplified)</li><li>zh-tw：中文（繁体） (Chinese Traditional)</li><li>en：英语 (English)</li><li>ja：日语 (Japanese)</li><li>ko：韩语 (Korean)</li><li>ms：马来语 (Malay)</li><li>yue：粤语 (Cantonese)</li><li>ar：阿拉伯语 (Arabic)</li><li>ru：俄语 (Russian)</li><li>es：西班牙语 (Spanish)</li><li>fr：法语 (French)</li><li>pt：葡萄牙语 (Portuguese)</li><li>de：德语 (German)</li><li>tr：土耳其语 (Turkish)</li><li>nl：荷兰语 (Dutch)</li><li>uk：乌克兰语 (Ukrainian)</li><li>vi：越南语 (Vietnamese)</li><li>id：印尼语 (Indonesian)</li><li>it：意大利语 (Italian)</li><li>th：泰语 (Thai)</li><li>pl：波兰语 (Polish)</li><li>ro：罗马尼亚语 (Romanian)</li><li>el：希腊语 (Greek)</li><li>cs：捷克语 (Czech)</li><li>fi：芬兰语 (Finnish)</li><li>hi：印地语 (Hindi)</li><li>bg：保加利亚语 (Bulgarian)</li><li>da：丹麦语 (Danish)</li><li>he：希伯来语 (Hebrew)</li><li>fa：波斯语（法尔西语） (Persian)</li><li>sk：斯洛伐克语 (Slovak)</li><li>sv：瑞典语 (Swedish)</li><li>hr：克罗地亚语 (Croatian)</li><li>tl：菲律宾语（他加禄语） (Filipino)</li><li>hu：匈牙利语 (Hungarian)</li><li>no：挪威语 (Norwegian)</li><li>sl：斯洛文尼亚语 (Slovenian)</li><li>ca：加泰罗尼亚语 (Catalan)</li><li>nn：新挪威语 (Nynorsk)</li><li>ta：泰米尔语 (Tamil)</li><li>af：南非荷兰语 (Afrikaans)</li></ul>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>多音字/生僻字发音纠正词典条目。指定特定词语在本次请求中使用的发音。</p>
        /// </summary>
        [JsonProperty("PronunciationDict")]
        public PronunciationDict[] PronunciationDict{ get; set; }

        /// <summary>
        /// <p>字幕级别</p><p>枚举值：</p><ul><li>0： 无字幕</li><li>1： 句子级别字幕</li><li>2： 词级别字幕，目前只有flow_01_ex支持词级别字幕</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("AlignmentMode")]
        public ulong? AlignmentMode{ get; set; }

        /// <summary>
        /// <p>json字符串，用于拓展用法</p>
        /// </summary>
        [JsonProperty("ExtraParams")]
        public string ExtraParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "AudioFormat.", this.AudioFormat);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamArrayObj(map, prefix + "PronunciationDict.", this.PronunciationDict);
            this.SetParamSimple(map, prefix + "AlignmentMode", this.AlignmentMode);
            this.SetParamSimple(map, prefix + "ExtraParams", this.ExtraParams);
        }
    }
}

