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

    public class MediaAiAnalysisHighlightItem : AbstractModel
    {
        
        /// <summary>
        /// 智能精彩集锦地址。
        /// </summary>
        [JsonProperty("HighlightUrl")]
        public string HighlightUrl{ get; set; }

        /// <summary>
        /// 智能精彩集锦封面地址。
        /// </summary>
        [JsonProperty("CovImgUrl")]
        public string CovImgUrl{ get; set; }

        /// <summary>
        /// 智能精彩集锦的可信度，取值范围是 0 到 100。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 智能精彩集锦持续时间。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 智能精彩集锦子片段列表，精彩集锦片段由这些子片段拼接生成。
        /// </summary>
        [JsonProperty("SegmentSet")]
        public HighlightSegmentItem[] SegmentSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighlightUrl", this.HighlightUrl);
            this.SetParamSimple(map, prefix + "CovImgUrl", this.CovImgUrl);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
        }
    }
}

