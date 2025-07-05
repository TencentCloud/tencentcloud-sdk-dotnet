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

    public class ComposeTrackTime : AbstractModel
    {
        
        /// <summary>
        /// 元素在轨道上的起始时间，时间点支持：
        /// <li>以 s 结尾，表示时间点单位为秒，如 3.5s 表示时间点为第3.5秒；</li>
        /// 注意：不填则默认为前一个元素的结束时间，此时可以通过 ComposeEmptyItem 元素来进行占位，实现轨道起始时间设置。
        /// </summary>
        [JsonProperty("Start")]
        public string Start{ get; set; }

        /// <summary>
        /// 元素时长，时间支持：
        /// <li>以 s 结尾，表示时间点单位为秒，如 3.5s 表示时间点为第3.5秒；</li>
        /// 默认：取对应 ComposeSourceMedia 媒体的有效时长（即 EndTime-StartTime），没有 ComposeSourceMedia 则默认为 1 秒。
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

