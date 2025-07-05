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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCastPlayInfo : AbstractModel
    {
        
        /// <summary>
        /// 点播转直播项目运行状态，取值有：
        /// <li> Working : 运行中；</li>
        /// <li> Idle: 空闲状态。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前播放的输入源 Id。
        /// </summary>
        [JsonProperty("CurrentSourceId")]
        public string CurrentSourceId{ get; set; }

        /// <summary>
        /// 当前播放的输入源的播放位置，单位：秒。
        /// </summary>
        [JsonProperty("CurrentSourcePosition")]
        public float? CurrentSourcePosition{ get; set; }

        /// <summary>
        /// 当前播放的输入源时长，单位：秒。
        /// </summary>
        [JsonProperty("CurrentSourceDuration")]
        public float? CurrentSourceDuration{ get; set; }

        /// <summary>
        /// 输出源状态信息。
        /// </summary>
        [JsonProperty("DestinationStatusSet")]
        public MediaCastDestinationStatus[] DestinationStatusSet{ get; set; }

        /// <summary>
        /// 已经循环播放的次数。
        /// </summary>
        [JsonProperty("LoopCount")]
        public long? LoopCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentSourceId", this.CurrentSourceId);
            this.SetParamSimple(map, prefix + "CurrentSourcePosition", this.CurrentSourcePosition);
            this.SetParamSimple(map, prefix + "CurrentSourceDuration", this.CurrentSourceDuration);
            this.SetParamArrayObj(map, prefix + "DestinationStatusSet.", this.DestinationStatusSet);
            this.SetParamSimple(map, prefix + "LoopCount", this.LoopCount);
        }
    }
}

