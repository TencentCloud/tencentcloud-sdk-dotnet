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

    public class MediaSubtitleItem : AbstractModel
    {
        
        /// <summary>
        /// 字幕的唯一标识。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 字幕名字。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字幕语言。常见的取值如下：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>ja：日文；</li>
        /// <li>ko：韩文；</li>
        /// <li>vi：越南语；</li>
        /// <li>ms：马来语；</li>
        /// <li>th：泰语；</li>
        /// <li>pt：葡萄牙语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ar：阿拉伯语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>hi：印地语；</li>
        /// <li>fr：法语。</li>
        /// 其他取值参考 [RFC5646](https://tools.ietf.org/html/rfc5646)
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 字幕格式。取值范围如下：
        /// <li>vtt</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 字幕 URL。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 字幕来源，取值范围：
        /// <li>UserUploaded：用户上传；</li>
        /// <li>AIRecognition：AI 识别，通过语音识别或语音翻译生成。</li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

