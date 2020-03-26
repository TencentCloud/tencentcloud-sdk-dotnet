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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpeningEndingTaskResultItem : AbstractModel
    {
        
        /// <summary>
        /// 视频片头的结束时间点，单位：秒。
        /// </summary>
        [JsonProperty("OpeningTimeOffset")]
        public float? OpeningTimeOffset{ get; set; }

        /// <summary>
        /// 片头识别置信度，取值范围是 0 到 100。
        /// </summary>
        [JsonProperty("OpeningConfidence")]
        public float? OpeningConfidence{ get; set; }

        /// <summary>
        /// 视频片尾的开始时间点，单位：秒。
        /// </summary>
        [JsonProperty("EndingTimeOffset")]
        public float? EndingTimeOffset{ get; set; }

        /// <summary>
        /// 片尾识别置信度，取值范围是 0 到 100。
        /// </summary>
        [JsonProperty("EndingConfidence")]
        public float? EndingConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpeningTimeOffset", this.OpeningTimeOffset);
            this.SetParamSimple(map, prefix + "OpeningConfidence", this.OpeningConfidence);
            this.SetParamSimple(map, prefix + "EndingTimeOffset", this.EndingTimeOffset);
            this.SetParamSimple(map, prefix + "EndingConfidence", this.EndingConfidence);
        }
    }
}

