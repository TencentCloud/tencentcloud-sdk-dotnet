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

    public class ReviewAudioVideoSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// 嫌疑片段起始的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 嫌疑片段结束的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 嫌疑片段涉及令人反感的信息的分数。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 嫌疑片段鉴别涉及违规信息的结果建议，取值范围：
        /// <li>review：疑似违规，建议复审；</li>
        /// <li>block：确认违规，建议封禁。</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 嫌疑片段最可能的违规的标签，取值范围：
        /// <li>Porn：色情；</li>
        /// <li>Terrorism：暴恐；</li>
        /// <li>Political：令人不适宜的信息。</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 当 Form 为 Image 或 Voice 时有效，表示当前标签（Label）下的二级标签。
        /// 当 Form 为 Image 且 Label 为 Porn 时，取值范围：
        /// <li>porn：色情；</li>
        /// <li>vulgar：低俗。</li>
        /// 
        /// 当 Form 为 Image 且 Label 为 Terrorism 时，取值范围：
        /// <li>guns：武器枪支；</li>
        /// <li>bloody：血腥画面；</li>
        /// <li>banners：暴恐旗帜；</li>
        /// <li> scenario：暴恐画面；</li>
        /// <li>explosion：爆炸火灾。</li>
        /// 
        /// 当 Form 为 Image 且 Label 为 Political 时，取值范围：
        /// <li>violation_photo：违规图标；</li>
        /// <li>nation_politician：国家领导人；</li>
        /// <li>province_politician：省部级领导人；</li>
        /// <li>county_politician：市/县级领导人；</li>
        /// <li>sensitive_politician：敏感相关人物；</li>
        /// <li>foreign_politician：国外政治人物；</li>
        /// <li>sensitive_entertainment：敏感娱乐明星；</li>
        /// <li>sensitive_military：敏感军事人物。</li>
        /// 
        /// 当 Form 为 Voice 且 Label 为 Porn 时，取值范围：
        /// <li>moan：娇喘。</li>
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// 嫌疑片段违禁的形式，取值范围：
        /// <li>Image：画面上的人物或图标；</li>
        /// <li>OCR：画面上的文字；</li>
        /// <li>ASR：语音中的文字；</li>
        /// <li>Voice：声音。</li>
        /// </summary>
        [JsonProperty("Form")]
        public string Form{ get; set; }

        /// <summary>
        /// 当 Form 为 Image 或 OCR 时有效，表示嫌疑人物、图标或文字出现的区域坐标 (像素级)，[x1, y1, x2, y2]，即左上角坐标、右下角坐标。
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// 当 Form 为 OCR 或 ASR 时有效，表示识别出来的 OCR 或 ASR 文本内容。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 当 Form 为 OCR 或 ASR 时有效，表示嫌疑片段命中的违规关键词列表。
        /// </summary>
        [JsonProperty("KeywordSet")]
        public string[] KeywordSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Form", this.Form);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArraySimple(map, prefix + "KeywordSet.", this.KeywordSet);
        }
    }
}

