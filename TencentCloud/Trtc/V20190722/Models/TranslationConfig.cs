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

    public class TranslationConfig : AbstractModel
    {
        
        /// <summary>
        /// 翻译的目标语言，目标语种列表（ISO 639-1）
        /// </summary>
        [JsonProperty("TargetLanguages")]
        public string[] TargetLanguages{ get; set; }

        /// <summary>
        ///  1： 仅文字翻译，  2： 语音同传
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 语音同传配置，开启同传时，需要传递
        /// </summary>
        [JsonProperty("TTSConfig")]
        public TTSConfig TTSConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetLanguages.", this.TargetLanguages);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
        }
    }
}

