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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeEventIdFilterConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>包含的云存事件 ID 集合</p>
        /// </summary>
        [JsonProperty("IncludeOnly")]
        public string[] IncludeOnly{ get; set; }

        /// <summary>
        /// <p>排除的云存事件 ID 集合</p>
        /// </summary>
        [JsonProperty("Exclude")]
        public string[] Exclude{ get; set; }

        /// <summary>
        /// <p>触发分析的时机</p><p>枚举值：</p><ul><li>end： 在云存事件结束时触发视频理解</li><li>start： 在云存事件开始时触发视频理解</li><li>image_and_video： 上传云存事件缩略图后触发图片理解，并且在云存事件结束时触发视频理解</li></ul><p>默认值：end</p>
        /// </summary>
        [JsonProperty("TriggerAt")]
        public string TriggerAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IncludeOnly.", this.IncludeOnly);
            this.SetParamArraySimple(map, prefix + "Exclude.", this.Exclude);
            this.SetParamSimple(map, prefix + "TriggerAt", this.TriggerAt);
        }
    }
}

