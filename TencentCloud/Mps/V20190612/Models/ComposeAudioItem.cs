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

    public class ComposeAudioItem : AbstractModel
    {
        
        /// <summary>
        /// 元素对应媒体信息。
        /// </summary>
        [JsonProperty("SourceMedia")]
        public ComposeSourceMedia SourceMedia{ get; set; }

        /// <summary>
        /// 元素在轨道时间轴上的时间信息，不填则紧跟上一个元素。
        /// </summary>
        [JsonProperty("TrackTime")]
        public ComposeTrackTime TrackTime{ get; set; }

        /// <summary>
        /// 对音频进行操作，如静音等。
        /// </summary>
        [JsonProperty("AudioOperations")]
        public ComposeAudioOperation[] AudioOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SourceMedia.", this.SourceMedia);
            this.SetParamObj(map, prefix + "TrackTime.", this.TrackTime);
            this.SetParamArrayObj(map, prefix + "AudioOperations.", this.AudioOperations);
        }
    }
}

