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

    public class AiAnalysisTaskVideoComprehensionOutput : AbstractModel
    {
        
        /// <summary>
        /// 视频（音频）理解内容详情
        /// </summary>
        [JsonProperty("VideoComprehensionAnalysisResult")]
        public string VideoComprehensionAnalysisResult{ get; set; }

        /// <summary>
        /// 视频（音频）理解扩展信息
        /// </summary>
        [JsonProperty("VideoComprehensionExtInfo")]
        public string VideoComprehensionExtInfo{ get; set; }

        /// <summary>
        /// 视频分镜理解结果
        /// </summary>
        [JsonProperty("VideoComprehensionResultList")]
        public VideoComprehensionResultItem[] VideoComprehensionResultList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoComprehensionAnalysisResult", this.VideoComprehensionAnalysisResult);
            this.SetParamSimple(map, prefix + "VideoComprehensionExtInfo", this.VideoComprehensionExtInfo);
            this.SetParamArrayObj(map, prefix + "VideoComprehensionResultList.", this.VideoComprehensionResultList);
        }
    }
}

