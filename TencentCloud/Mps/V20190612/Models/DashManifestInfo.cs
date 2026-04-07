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

    public class DashManifestInfo : AbstractModel
    {
        
        /// <summary>
        /// 每个清单的总持续时间（以秒为单位）。[30, 3600]，类型：整数，默认值60。
        /// </summary>
        [JsonProperty("Windows")]
        public long? Windows{ get; set; }

        /// <summary>
        /// 播放器在缓冲区中保持的最小缓存时间（以秒为单位）。[2, 60]，类型：整数，默认值30。
        /// </summary>
        [JsonProperty("MinBufferTime")]
        public long? MinBufferTime{ get; set; }

        /// <summary>
        /// 播放器在请求更新清单之前应等待的最短时间（以秒为单位）。[2, 60]，类型：整数，默认值2。
        /// </summary>
        [JsonProperty("MinUpdatePeriod")]
        public long? MinUpdatePeriod{ get; set; }

        /// <summary>
        /// 播放器启播时距离最新直播时间点的时间，是一个回退量（以秒为单位）。[2, 60]，类型：整数，默认值10。
        /// </summary>
        [JsonProperty("SuggestedPresentationDelay")]
        public long? SuggestedPresentationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Windows", this.Windows);
            this.SetParamSimple(map, prefix + "MinBufferTime", this.MinBufferTime);
            this.SetParamSimple(map, prefix + "MinUpdatePeriod", this.MinUpdatePeriod);
            this.SetParamSimple(map, prefix + "SuggestedPresentationDelay", this.SuggestedPresentationDelay);
        }
    }
}

