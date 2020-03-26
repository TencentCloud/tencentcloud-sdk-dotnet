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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Video.", this.Video);
            this.SetParamObj(map, prefix + "Audio.", this.Audio);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
        }
    }
}

