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

    public class AudioTrackItem : AbstractModel
    {
        
        /// <summary>
        /// 音频素材的媒体文件来源。可以是点播的文件 ID，也可以是其它文件的 URL。
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// 音频片段取自素材文件的起始时间，单位为秒。0 表示从素材开始位置截取。默认为0。
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// 音频片段的时长，单位为秒。默认和素材本身长度一致，表示截取全部素材。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 对音频片段进行的操作，如音量调节等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioOperations")]
        public AudioTransform[] AudioOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "AudioOperations.", this.AudioOperations);
        }
    }
}

