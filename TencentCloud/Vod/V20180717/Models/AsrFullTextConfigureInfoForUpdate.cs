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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrFullTextConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 语音全文识别任务开关，可选值：
        /// <li>ON：开启智能语音全文识别任务；</li>
        /// <li>OFF：关闭智能语音全文识别任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 字幕格式列表操作信息。
        /// </summary>
        [JsonProperty("SubtitleFormatsOperation")]
        public SubtitleFormatsOperation SubtitleFormatsOperation{ get; set; }

        /// <summary>
        /// 生成的字幕文件格式，<font color='red'>填空字符串</font>表示不生成字幕文件，可选值：
        /// <li>vtt：生成 WebVTT 字幕文件；</li>
        /// <li>srt：生成 SRT 字幕文件。</li>
        /// <font color='red'>注意：此字段已废弃，建议使用 SubtitleFormatsOperation。</font>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// 媒体源语言，取值范围：
        /// <li>zh：中文普通话；</li>
        /// <li>en：英语；</li>
        /// <li>ja：日语；</li>
        /// <li>zh-ca：粤语。</li>
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// 指定字幕名称，长度限制：64 个字符。该值将用于播放器展示。
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "SubtitleFormatsOperation.", this.SubtitleFormatsOperation);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

