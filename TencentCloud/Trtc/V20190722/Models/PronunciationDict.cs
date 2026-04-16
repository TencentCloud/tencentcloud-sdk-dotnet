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

    public class PronunciationDict : AbstractModel
    {
        
        /// <summary>
        /// 需要纠正发音的词语，前后空格自动去除。同一请求中若有重复词语，以最后一条为准。
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// 目标发音，支持以下格式：<br>① 带声调数字的拼音（1=阴平，2=阳平，3=上声，4=去声，5=轻声），如 yin2 hang2；<br>② 拼音连写（无空格），如 yin2hang2；<br>③ 文字+拼音混写，如 银hang2；<br>④ 直接文本替换，会将原始文本替换为目标文本
        /// </summary>
        [JsonProperty("Pronunciation")]
        public string Pronunciation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "Pronunciation", this.Pronunciation);
        }
    }
}

