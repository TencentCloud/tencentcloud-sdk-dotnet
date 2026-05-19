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

    public class VoiceProfile : AbstractModel
    {
        
        /// <summary>
        /// <p>音色名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>音色描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>性别</p><p>枚举值：</p><ul><li>male： 男性</li><li>female： 女性</li><li>unknown： 未知</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>年龄</p><p>枚举值：</p><ul><li>child： 儿童</li><li>teenager： 少年</li><li>youth： 青年</li><li>middle_aged： 中年</li><li>senior： 老年</li><li>unknown： 未知</li></ul>
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// <p>语言，当前支持：<br>zh 中文 (Chinese)<br>en 英语 (English)<br>ja 日语 (Japanese)<br>de 德语 (German)<br>fr 法语 (French)<br>ko 韩语 (Korean)<br>ru 俄语 (Russian)<br>uk 乌克兰语 (Ukrainian)<br>pt 葡萄牙语 (Portuguese)<br>it 意大利语 (Italian)<br>es 西班牙语 (Spanish)<br>id 印度尼西亚语 (Indonesian)<br>nl 荷兰语 (Dutch)<br>tr 土耳其语 (Turkish)<br>fil 菲律宾语 (Filipino)<br>ms 马来语 (Malay)<br>el 希腊语 (Greek)<br>fi 芬兰语 (Finnish)<br>hr 克罗地亚语 (Croatian)<br>sk 斯洛伐克语 (Slovak)<br>pl 波兰语 (Polish)<br>sv 瑞典语 (Swedish)<br>hi 印地语 (Hindi)<br>bg 保加利亚语 (Bulgarian)<br>ro 罗马尼亚语 (Romanian)<br>ar 阿拉伯语 (Arabic)<br>cs 捷克语 (Czech)<br>da 丹麦语 (Danish)<br>ta 泰米尔语 (Tamil)<br>hun 匈牙利语（Hungarian）<br>vi 越南语（Vietnamese）<br>no 挪威语（Norwegian）<br>yue 粤语（Cantonese）<br>th 泰语（Thai）<br>he 希伯来语（Hebrew）<br>ca 加泰罗尼亚语（Catalan）<br>nn 尼诺斯克语（Nynorsk）<br>af 阿非利卡语（Afrikaans）<br>fa 波斯语（Persian）<br>sl 斯洛文尼亚语（Slovenian）</p>
        /// </summary>
        [JsonProperty("Languages")]
        public string[] Languages{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// <p>使用场景</p>
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamArraySimple(map, prefix + "Languages.", this.Languages);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
        }
    }
}

