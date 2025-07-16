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

    public class SegmentRecognitionItem : AbstractModel
    {
        
        /// <summary>
        /// 置信度。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 片段起始时间偏移。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 片段结束时间偏移。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 拆条片段URL。
        /// </summary>
        [JsonProperty("SegmentUrl")]
        public string SegmentUrl{ get; set; }

        /// <summary>
        /// 拆条片段封面。
        /// </summary>
        [JsonProperty("CovImgUrl")]
        public string CovImgUrl{ get; set; }

        /// <summary>
        /// 分段标题。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 分段概要。
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 分段关键词。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 直播切片对应直播起始时间点，采用 ISO 日期格式。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 直播切片对应直播结束时间点，采用 ISO 日期格式。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 直播拆条用，音频url。
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 直播拆条用，音频对应起始时间戳；
        /// </summary>
        [JsonProperty("AudioBeginTime")]
        public float? AudioBeginTime{ get; set; }

        /// <summary>
        /// 直播拆条用，音频对应结束时间戳。
        /// </summary>
        [JsonProperty("AudioEndTime")]
        public float? AudioEndTime{ get; set; }

        /// <summary>
        /// 直播拆条用，人物位置参考信息用于横转竖。
        /// </summary>
        [JsonProperty("PersonPositionUrl")]
        public string PersonPositionUrl{ get; set; }

        /// <summary>
        /// 指定人物ID。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "SegmentUrl", this.SegmentUrl);
            this.SetParamSimple(map, prefix + "CovImgUrl", this.CovImgUrl);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioBeginTime", this.AudioBeginTime);
            this.SetParamSimple(map, prefix + "AudioEndTime", this.AudioEndTime);
            this.SetParamSimple(map, prefix + "PersonPositionUrl", this.PersonPositionUrl);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
        }
    }
}

