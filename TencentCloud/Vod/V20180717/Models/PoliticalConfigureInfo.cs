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

    public class PoliticalConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// 画面鉴别涉及令人不适宜的信息的控制参数。
        /// </summary>
        [JsonProperty("ImgReviewInfo")]
        public PoliticalImgReviewTemplateInfo ImgReviewInfo{ get; set; }

        /// <summary>
        /// 语音鉴别涉及令人不适宜的信息的控制参数。
        /// </summary>
        [JsonProperty("AsrReviewInfo")]
        public PoliticalAsrReviewTemplateInfo AsrReviewInfo{ get; set; }

        /// <summary>
        /// 文本鉴别涉及令人不适宜的信息的控制参数。
        /// </summary>
        [JsonProperty("OcrReviewInfo")]
        public PoliticalOcrReviewTemplateInfo OcrReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImgReviewInfo.", this.ImgReviewInfo);
            this.SetParamObj(map, prefix + "AsrReviewInfo.", this.AsrReviewInfo);
            this.SetParamObj(map, prefix + "OcrReviewInfo.", this.OcrReviewInfo);
        }
    }
}

