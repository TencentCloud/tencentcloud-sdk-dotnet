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

    public class PlaybackInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>program持续时间，单位毫秒，直播有效。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// <p>program启动方式，直播只支持Absolute，点播还支持Relative。</p>
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// <p>unix时间戳，Absolute场景下program的开始执行时间。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>和所选program的插入顺序关系，分After和Before。</p>
        /// </summary>
        [JsonProperty("RelativePosition")]
        public string RelativePosition{ get; set; }

        /// <summary>
        /// <p>所选的插入参考program id。</p>
        /// </summary>
        [JsonProperty("RelativeProgramId")]
        public string RelativeProgramId{ get; set; }

        /// <summary>
        /// <p>垫片配置。</p>
        /// </summary>
        [JsonProperty("ClipRangeConf")]
        public ClipRangeInfo ClipRangeConf{ get; set; }

        /// <summary>
        /// <p>RelativeProgramName。</p>
        /// </summary>
        [JsonProperty("RelativeProgramName")]
        public string RelativeProgramName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RelativePosition", this.RelativePosition);
            this.SetParamSimple(map, prefix + "RelativeProgramId", this.RelativeProgramId);
            this.SetParamObj(map, prefix + "ClipRangeConf.", this.ClipRangeConf);
            this.SetParamSimple(map, prefix + "RelativeProgramName", this.RelativeProgramName);
        }
    }
}

