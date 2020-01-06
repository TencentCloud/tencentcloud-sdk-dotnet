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

    public class AiRecognitionTaskSegmentSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// 文件 ID。仅当处理的是点播文件并且拆条生成的子片段为点播文件时有效。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 视频拆条片段 Url。
        /// </summary>
        [JsonProperty("SegmentUrl")]
        public string SegmentUrl{ get; set; }

        /// <summary>
        /// 拆条片段置信度。取值：0~100。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 拆条片段起始的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 拆条片段终止的偏移时间，单位：秒。
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 拆条封面图片 Url。
        /// </summary>
        [JsonProperty("CovImgUrl")]
        public string CovImgUrl{ get; set; }

        /// <summary>
        /// 特殊字段，请忽略。
        /// </summary>
        [JsonProperty("SpecialInfo")]
        public string SpecialInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SegmentUrl", this.SegmentUrl);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "CovImgUrl", this.CovImgUrl);
            this.SetParamSimple(map, prefix + "SpecialInfo", this.SpecialInfo);
        }
    }
}

