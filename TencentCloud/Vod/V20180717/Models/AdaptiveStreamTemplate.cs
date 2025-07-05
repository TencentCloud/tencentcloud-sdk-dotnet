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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdaptiveStreamTemplate : AbstractModel
    {
        
        /// <summary>
        /// 视频参数信息。
        /// </summary>
        [JsonProperty("Video")]
        public VideoTemplateInfo Video{ get; set; }

        /// <summary>
        /// 音频参数信息。
        /// </summary>
        [JsonProperty("Audio")]
        public AudioTemplateInfo Audio{ get; set; }

        /// <summary>
        /// 是否移除音频流，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public ulong? RemoveAudio{ get; set; }

        /// <summary>
        /// 是否移除视频流，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public ulong? RemoveVideo{ get; set; }

        /// <summary>
        /// 极速高清转码参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Video.", this.Video);
            this.SetParamObj(map, prefix + "Audio.", this.Audio);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
        }
    }
}

