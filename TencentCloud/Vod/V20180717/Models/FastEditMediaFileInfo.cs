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

    public class FastEditMediaFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒体的 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 操作的音视频类型，可选值有：
        /// <li>Transcode：转码输出；</li>
        /// <li>Original：原始音视频。</li>
        /// 注意：操作的音视频，必须为 HLS 格式。
        /// </summary>
        [JsonProperty("AudioVideoType")]
        public string AudioVideoType{ get; set; }

        /// <summary>
        /// 当 AudioVideoType 为 Transcode 时有效，表示操作媒体的的转码模板 ID。
        /// </summary>
        [JsonProperty("TranscodeDefinition")]
        public long? TranscodeDefinition{ get; set; }

        /// <summary>
        /// 媒体剪辑起始的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 媒体剪辑结束的时间偏移，单位：秒。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "AudioVideoType", this.AudioVideoType);
            this.SetParamSimple(map, prefix + "TranscodeDefinition", this.TranscodeDefinition);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

