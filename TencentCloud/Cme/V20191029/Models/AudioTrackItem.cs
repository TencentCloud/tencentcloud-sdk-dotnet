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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackItem : AbstractModel
    {
        
        /// <summary>
        /// 音频媒体来源类型，取值有：
        /// <ul>
        /// <li>VOD ：素材来源于云点播文件 ；</li>
        /// <li>CME ：视频来源于制作云媒体文件 ；</li>
        /// <li>EXTERNAL ：视频来源于媒资绑定，如果媒体不是存储在腾讯云点播中或者云创中，都需要使用媒资绑定。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 音频媒体，可取值为：
        /// <ul>
        /// <li>当 SourceType 为 VOD 时，参数填云点播 FileId ；</li>
        /// <li>当 SourceType 为 CME 时，参数填云剪媒体 Id；</li>
        /// <li>当 SourceType 为 EXTERNAL 时，目前仅支持外部媒体 URL(如`https://www.example.com/a.mp3`)，参数填写规则请参见注意事项。</li>
        /// </ul>
        /// 
        /// 注意：
        /// <li>当 SourceType 为 EXTERNAL 并且媒体 URL Scheme 为 `https` 时(如：`https://www.example.com/a.mp3`)，参数为：`1000000:www.example.com/a.mp3`。</li>
        /// <li>当 SourceType 为 EXTERNAL 并且媒体 URL Scheme 为 `http` 时(如：`http://www.example.com/b.mp3`)，参数为：`1000001:www.example.com/b.mp3`。</li>
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// 音频片段取自媒体文件的起始时间，单位为秒。0 表示从媒体开始位置截取。默认为0。
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// 音频片段的时长，单位为秒。默认和媒体本身长度一致，表示截取全部媒体。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

