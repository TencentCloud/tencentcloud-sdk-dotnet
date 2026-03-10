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

    public class TranslationParam : AbstractModel
    {
        
        /// <summary>
        /// 翻译的目标语言，示例值["en", "ja"]。目标语种列表[中文 "zh"，英语 "en"，越南语 "vi"，日语 "ja"，韩语 "ko"，印度尼西亚语 "id"，泰语 "th"，葡萄牙语 "pt"，阿拉伯语 "ar"，西班牙语 "es"，法语 "fr"，马来语 "ms"，德语 "de"，意大利语 "it"，俄语 "ru"]。
        /// </summary>
        [JsonProperty("TargetLang")]
        public string[] TargetLang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetLang.", this.TargetLang);
        }
    }
}

