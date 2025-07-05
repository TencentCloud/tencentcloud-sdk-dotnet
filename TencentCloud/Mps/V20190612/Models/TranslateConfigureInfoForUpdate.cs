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

    public class TranslateConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 语音翻译任务开关，可选值：
        /// <li>ON：开启智能语音翻译任务；</li>
        /// <li>OFF：关闭智能语音翻译任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 视频源语言。
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// 翻译目标语言。
        /// </summary>
        [JsonProperty("DestinationLanguage")]
        public string DestinationLanguage{ get; set; }

        /// <summary>
        /// 生成的字幕文件格式，填空字符串表示不生成字幕文件，可选值：
        /// <li>vtt：生成 WebVTT 字幕文件。</li>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "DestinationLanguage", this.DestinationLanguage);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
        }
    }
}

