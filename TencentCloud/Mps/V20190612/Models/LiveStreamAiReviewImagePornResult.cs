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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamAiReviewImagePornResult : AbstractModel
    {
        
        /// <summary>
        /// 嫌疑片段起始的 PTS 时间，单位：秒。
        /// </summary>
        [JsonProperty("StartPtsTime")]
        public float? StartPtsTime{ get; set; }

        /// <summary>
        /// 嫌疑片段结束的 PTS 时间，单位：秒。
        /// </summary>
        [JsonProperty("EndPtsTime")]
        public float? EndPtsTime{ get; set; }

        /// <summary>
        /// 嫌疑片段涉黄分数。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 嫌疑片段鉴黄结果建议，取值范围：
        /// <li>pass</li>
        /// <li>review</li>
        /// <li>block</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 视频鉴黄结果标签，取值范围：
        /// <li>porn：色情。</li>
        /// <li>sexy：性感。</li>
        /// <li>vulgar：低俗。</li>
        /// <li>intimacy：亲密行为。</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 嫌疑图片 URL （图片不会永久存储，到达
        /// PicUrlExpireTime 时间点后图片将被删除）。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 嫌疑图片 URL 失效时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("PicUrlExpireTime")]
        public string PicUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartPtsTime", this.StartPtsTime);
            this.SetParamSimple(map, prefix + "EndPtsTime", this.EndPtsTime);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "PicUrlExpireTime", this.PicUrlExpireTime);
        }
    }
}

