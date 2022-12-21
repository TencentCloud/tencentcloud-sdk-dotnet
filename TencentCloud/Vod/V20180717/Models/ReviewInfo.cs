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

    public class ReviewInfo : AbstractModel
    {
        
        /// <summary>
        /// 审核模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 审核的结果建议，取值范围：
        /// <li>pass：建议通过；</li>
        /// <li>review：建议复审；</li>
        /// <li>block：建议封禁。</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 审核类型，当 Suggestion 为 review 或 block 时有效，格式为：Form.Label。
        /// Form 表示违禁的形式，取值范围：
        /// <li>Image：画面上的人物或图标；</li>
        /// <li>OCR：画面上的文字；</li>
        /// <li>ASR：语音中的文字；</li>
        /// <li>Voice：声音。</li>
        /// Label 表示违禁的标签，取值范围：
        /// <li>Porn：色情；</li>
        /// <li>Terror：暴恐；</li>
        /// <li>Polity：不适宜的信息；</li>
        /// <li>Ad：广告；</li>
        /// <li>Illegal：违法；</li>
        /// <li>Religion：宗教；</li>
        /// <li>Abuse：谩骂；</li>
        /// <li>Moan：娇喘。</li>
        /// </summary>
        [JsonProperty("TypeSet")]
        public string[] TypeSet{ get; set; }

        /// <summary>
        /// 审核时间，使用  [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("ReviewTime")]
        public string ReviewTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArraySimple(map, prefix + "TypeSet.", this.TypeSet);
            this.SetParamSimple(map, prefix + "ReviewTime", this.ReviewTime);
        }
    }
}

