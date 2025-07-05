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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoAppearInfo : AbstractModel
    {
        
        /// <summary>
        /// 视觉信息起始时间戳，从0开始
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public float? StartTimeStamp{ get; set; }

        /// <summary>
        /// 视觉信息终止时间戳，从0开始
        /// 关键词在视觉信息中的区间为[StartTimeStamp, EndTimeStamp)
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public float? EndTimeStamp{ get; set; }

        /// <summary>
        /// 关键词在视觉信息中的封面图片
        /// </summary>
        [JsonProperty("ImageURL")]
        public string ImageURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "EndTimeStamp", this.EndTimeStamp);
            this.SetParamSimple(map, prefix + "ImageURL", this.ImageURL);
        }
    }
}

