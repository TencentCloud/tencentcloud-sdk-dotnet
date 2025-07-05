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

    public class AiContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，可以取的值有：
        /// <li>Porn：图片鉴别是否涉及令人反感的信息</li>
        /// <li>Terrorism：图片鉴别是否涉及令人不安全的信息</li>
        /// <li>Political：图片鉴别是否涉及令人不适宜的信息</li>
        /// <li>Porn.Asr：Asr 文字（ 音频中的文字）鉴别是否涉及令人反感的信息</li>
        /// <li>Porn.Ocr：Ocr 文字鉴别是否涉及令人反感的信息</li>
        /// <li>Political.Asr：Asr 文字（ 音频中的文字）鉴别是否涉及令人不适宜的信息</li>
        /// <li>Political.Ocr：Ocr 文字鉴别是否涉及令人不适宜的信息</li>
        /// <li>Terrorism.Ocr：Ocr 文字鉴别是否涉及令人不安全的信息</li>
        /// <li>Prohibited.Asr：Asr 文字（ 音频中的文字）鉴违禁</li>
        /// <li>Prohibited.Ocr：Ocr 文字鉴违禁</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（画面涉及令人反感的信息）的查询结果，当任务类型为 Porn 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornTask")]
        public AiReviewTaskPornResult PornTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（画面涉及令人不安全的信息）的查询结果，当任务类型为 Terrorism 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorismTask")]
        public AiReviewTaskTerrorismResult TerrorismTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（画面涉及令人不适宜的信息）的查询结果，当任务类型为 Political 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticalTask")]
        public AiReviewTaskPoliticalResult PoliticalTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（Asr 文字涉及令人反感的信息）的查询结果，当任务类型为 Porn.Asr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornAsrTask")]
        public AiReviewTaskPornAsrResult PornAsrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（Ocr 文字涉及令人反感的信息）的查询结果，当任务类型为 Porn.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornOcrTask")]
        public AiReviewTaskPornOcrResult PornOcrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（Asr 文字涉及令人不适宜的信息）的查询结果，当任务类型为 Political.Asr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticalAsrTask")]
        public AiReviewTaskPoliticalAsrResult PoliticalAsrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（Ocr 文字涉及令人不适宜的信息）的查询结果，当任务类型为 Political.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticalOcrTask")]
        public AiReviewTaskPoliticalOcrResult PoliticalOcrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核任务（ Ocr 文字涉及令人不安全的信息）的查询结果，当任务类型为 Terrorism.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorismOcrTask")]
        public AiReviewTaskTerrorismOcrResult TerrorismOcrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核 Ocr 文字鉴违禁任务的查询结果，当任务类型为 Prohibited.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProhibitedOcrTask")]
        public AiReviewTaskProhibitedOcrResult ProhibitedOcrTask{ get; set; }

        /// <summary>
        /// 视频音视频审核 Asr 文字鉴违禁任务的查询结果，当任务类型为 Prohibited.Asr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProhibitedAsrTask")]
        public AiReviewTaskProhibitedAsrResult ProhibitedAsrTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PornTask.", this.PornTask);
            this.SetParamObj(map, prefix + "TerrorismTask.", this.TerrorismTask);
            this.SetParamObj(map, prefix + "PoliticalTask.", this.PoliticalTask);
            this.SetParamObj(map, prefix + "PornAsrTask.", this.PornAsrTask);
            this.SetParamObj(map, prefix + "PornOcrTask.", this.PornOcrTask);
            this.SetParamObj(map, prefix + "PoliticalAsrTask.", this.PoliticalAsrTask);
            this.SetParamObj(map, prefix + "PoliticalOcrTask.", this.PoliticalOcrTask);
            this.SetParamObj(map, prefix + "TerrorismOcrTask.", this.TerrorismOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedOcrTask.", this.ProhibitedOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedAsrTask.", this.ProhibitedAsrTask);
        }
    }
}

