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

    public class ContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// 结果类型，取值范围：
        /// <li>Porn.Image：图片画面中的鉴别令人反感的信息结果；</li>
        /// <li>Terrorism.Image：图片画面中的鉴别令人不安全的信息结果；</li>
        /// <li>Political.Image：图片画面中的鉴别令人不适宜信息结果；</li>
        /// <li>Porn.Ocr：图片 OCR 文字中的鉴别令人反感的信息结果；</li>
        /// <li>Terrorism.Ocr：图片 OCR 文字中的鉴别令人不安全的信息结果；</li>
        /// <li>Political.Ocr：图片 OCR 文字中的鉴别令人不适宜信息结果。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 图片画面中的鉴别令人反感的信息结果，当 Type 为 Porn.Image 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornImageResult")]
        public PornImageResult PornImageResult{ get; set; }

        /// <summary>
        /// 图片画面中的鉴别令人不安全的信息结果，当 Type 为 Terrorism.Image 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorismImageResult")]
        public TerrorismImageResult TerrorismImageResult{ get; set; }

        /// <summary>
        /// 图片画面中的鉴别令人不适宜信息结果，当 Type 为 Political.Image 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticalImageResult")]
        public PoliticalImageResult PoliticalImageResult{ get; set; }

        /// <summary>
        /// 图片 OCR 文字中的鉴别令人反感的信息结果，当 Type 为 Porn.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornOcrResult")]
        public ContentReviewOcrResult PornOcrResult{ get; set; }

        /// <summary>
        /// 图片 OCR 中的鉴别令人不安全的信息结果，当 Type 为 Terrorism.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorismOcrResult")]
        public ContentReviewOcrResult TerrorismOcrResult{ get; set; }

        /// <summary>
        /// 图片 OCR 文字中的鉴别令人不适宜信息结果，当 Type 为 Political.Ocr 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticalOcrResult")]
        public ContentReviewOcrResult PoliticalOcrResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PornImageResult.", this.PornImageResult);
            this.SetParamObj(map, prefix + "TerrorismImageResult.", this.TerrorismImageResult);
            this.SetParamObj(map, prefix + "PoliticalImageResult.", this.PoliticalImageResult);
            this.SetParamObj(map, prefix + "PornOcrResult.", this.PornOcrResult);
            this.SetParamObj(map, prefix + "TerrorismOcrResult.", this.TerrorismOcrResult);
            this.SetParamObj(map, prefix + "PoliticalOcrResult.", this.PoliticalOcrResult);
        }
    }
}

