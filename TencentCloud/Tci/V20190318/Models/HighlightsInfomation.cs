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

    public class HighlightsInfomation : AbstractModel
    {
        
        /// <summary>
        /// 专注的起始与终止时间信息。
        /// </summary>
        [JsonProperty("Concentration")]
        public TimeType[] Concentration{ get; set; }

        /// <summary>
        /// 微笑的起始与终止时间信息。
        /// </summary>
        [JsonProperty("Smile")]
        public TimeType[] Smile{ get; set; }

        /// <summary>
        /// 高光集锦视频地址，保存剪辑好的视频地址。
        /// </summary>
        [JsonProperty("HighlightsUrl")]
        public string HighlightsUrl{ get; set; }

        /// <summary>
        /// 片段中识别出来的人脸ID。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Concentration.", this.Concentration);
            this.SetParamArrayObj(map, prefix + "Smile.", this.Smile);
            this.SetParamSimple(map, prefix + "HighlightsUrl", this.HighlightsUrl);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
        }
    }
}

