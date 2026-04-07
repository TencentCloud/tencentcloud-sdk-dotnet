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

    public class PlaybackInfoReq : AbstractModel
    {
        
        /// <summary>
        /// program启动方式，直播只支持Absolute，点播还支持Relative。PlaybackMode类型为Linear的VOD支持Absolute和Relative。PlaybackMode类型为Loop的VOD只支持Relative
        /// </summary>
        [JsonProperty("TransitionType")]
        public string TransitionType{ get; set; }

        /// <summary>
        /// unix时间戳，absolute场景下program的开始执行时间。最多大于当前90天（7776000）。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// program持续时间，单位毫秒，直播有效。支持600000-86400000。默认600000。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 和所选program的插入顺序关系，分After和Before。
        /// </summary>
        [JsonProperty("RelativePosition")]
        public string RelativePosition{ get; set; }

        /// <summary>
        /// 所选的插入参考program id。
        /// </summary>
        [JsonProperty("RelativeProgramId")]
        public string RelativeProgramId{ get; set; }

        /// <summary>
        /// 垫片配置。
        /// </summary>
        [JsonProperty("ClipRangeConf")]
        public ClipRangeInfo ClipRangeConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransitionType", this.TransitionType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RelativePosition", this.RelativePosition);
            this.SetParamSimple(map, prefix + "RelativeProgramId", this.RelativeProgramId);
            this.SetParamObj(map, prefix + "ClipRangeConf.", this.ClipRangeConf);
        }
    }
}

