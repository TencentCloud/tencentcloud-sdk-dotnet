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

    public class UserDefineConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 用户自定义人物审核控制参数。
        /// </summary>
        [JsonProperty("FaceReviewInfo")]
        public UserDefineFaceReviewTemplateInfoForUpdate FaceReviewInfo{ get; set; }

        /// <summary>
        /// 用户自定义语音审核控制参数。
        /// </summary>
        [JsonProperty("AsrReviewInfo")]
        public UserDefineAsrTextReviewTemplateInfoForUpdate AsrReviewInfo{ get; set; }

        /// <summary>
        /// 用户自定义文本审核控制参数。
        /// </summary>
        [JsonProperty("OcrReviewInfo")]
        public UserDefineOcrTextReviewTemplateInfoForUpdate OcrReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FaceReviewInfo.", this.FaceReviewInfo);
            this.SetParamObj(map, prefix + "AsrReviewInfo.", this.AsrReviewInfo);
            this.SetParamObj(map, prefix + "OcrReviewInfo.", this.OcrReviewInfo);
        }
    }
}

