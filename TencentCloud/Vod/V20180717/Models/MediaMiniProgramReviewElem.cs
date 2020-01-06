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

    public class MediaMiniProgramReviewElem : AbstractModel
    {
        
        /// <summary>
        /// 审核类型。 
        /// <li>Porn：画面涉黄，</li>
        /// <li>Porn.Ocr：文字涉黄，</li>
        /// <li>Porn.Asr：声音涉黄，</li>
        /// <li>Terrorism：画面涉暴恐，</li>
        /// <li>Political：画面涉政，</li>
        /// <li>Political.Ocr：文字涉政，</li>
        /// <li>Political.Asr：声音涉政。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 审核意见。
        /// <li>pass：确认正常，</li>
        /// <li>block：确认违规，</li>
        /// <li>review：疑似违规。</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 审核结果置信度。取值 0~100。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

