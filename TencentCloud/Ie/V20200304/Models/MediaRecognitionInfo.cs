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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaRecognitionInfo : AbstractModel
    {
        
        /// <summary>
        /// 帧标签识别
        /// </summary>
        [JsonProperty("FrameTagRec")]
        public FrameTagRec FrameTagRec{ get; set; }

        /// <summary>
        /// 语音字幕识别
        /// </summary>
        [JsonProperty("SubtitleRec")]
        public SubtitleRec SubtitleRec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FrameTagRec.", this.FrameTagRec);
            this.SetParamObj(map, prefix + "SubtitleRec.", this.SubtitleRec);
        }
    }
}

