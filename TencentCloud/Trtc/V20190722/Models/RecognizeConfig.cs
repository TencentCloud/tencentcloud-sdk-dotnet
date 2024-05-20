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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeConfig : AbstractModel
    {
        
        /// <summary>
        /// 支持的语言，目前支持语言如下：
        ///     Chinese = "zh"
        ///     Chinese_TW = "zh-TW"
        ///     English = "en"
        ///     Vietnamese = "vi"
        ///     Japanese = "ja"
        ///     Korean = "ko"
        ///     Indonesia = "id"
        ///     Thai = "th"
        ///     Portuguese = "pt"
        ///     Turkish = "tr"
        ///     Arabic = "ar"
        ///     Spanish = "es"
        ///     Hindi = "hi"
        ///     French = "fr"
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 选填，如果填写，则会启用翻译，不填则忽略。支持语言同Language字段。
        /// </summary>
        [JsonProperty("TranslationLanguage")]
        public string TranslationLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "TranslationLanguage", this.TranslationLanguage);
        }
    }
}

