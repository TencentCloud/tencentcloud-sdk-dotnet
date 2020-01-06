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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHighlightsRequest : AbstractModel
    {
        
        /// <summary>
        /// 表情配置开关项。
        /// </summary>
        [JsonProperty("Functions")]
        public HLFunction Functions{ get; set; }

        /// <summary>
        /// 视频url。
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 视频类型及来源，目前只支持点播类型："vod_url"。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 需要检索的人脸合集库，不在库中的人脸将不参与精彩集锦。
        /// </summary>
        [JsonProperty("LibIds")]
        public string[] LibIds{ get; set; }

        /// <summary>
        /// 视频处理的抽帧间隔，单位毫秒。建议留空。
        /// </summary>
        [JsonProperty("FrameInterval")]
        public long? FrameInterval{ get; set; }

        /// <summary>
        /// 关键词语言类型，0为英文，1为中文。
        /// </summary>
        [JsonProperty("KeywordsLanguage")]
        public long? KeywordsLanguage{ get; set; }

        /// <summary>
        /// 关键词数组，当且仅当Funtions中的EnableKeywordWonderfulTime为true时有意义，匹配相应的关键字。
        /// </summary>
        [JsonProperty("KeywordsStrings")]
        public string[] KeywordsStrings{ get; set; }

        /// <summary>
        /// 处理视频的总时长，单位毫秒。该值为0或未设置时，默认值两小时生效；当该值大于视频实际时长时，视频实际时长生效；当该值小于视频实际时长时，该值生效；当获取视频实际时长失败时，若该值设置则生效，否则默认值生效。建议留空。
        /// </summary>
        [JsonProperty("MaxVideoDuration")]
        public long? MaxVideoDuration{ get; set; }

        /// <summary>
        /// 人脸检索的相似度阈值，默认值0.89。建议留空。
        /// </summary>
        [JsonProperty("SimThreshold")]
        public float? SimThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "LibIds.", this.LibIds);
            this.SetParamSimple(map, prefix + "FrameInterval", this.FrameInterval);
            this.SetParamSimple(map, prefix + "KeywordsLanguage", this.KeywordsLanguage);
            this.SetParamArraySimple(map, prefix + "KeywordsStrings.", this.KeywordsStrings);
            this.SetParamSimple(map, prefix + "MaxVideoDuration", this.MaxVideoDuration);
            this.SetParamSimple(map, prefix + "SimThreshold", this.SimThreshold);
        }
    }
}

