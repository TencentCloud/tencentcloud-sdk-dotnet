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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlayRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>房间ID。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// <p>用户ID。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>单次播放会话ID。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>播放开始时间，unix时间戳（秒）。</p>
        /// </summary>
        [JsonProperty("PlayBeginTime")]
        public ulong? PlayBeginTime{ get; set; }

        /// <summary>
        /// <p>播放结束时间，unix时间戳（秒）。</p>
        /// </summary>
        [JsonProperty("PlayEndTime")]
        public ulong? PlayEndTime{ get; set; }

        /// <summary>
        /// <p>播放时长（毫秒）。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "PlayBeginTime", this.PlayBeginTime);
            this.SetParamSimple(map, prefix + "PlayEndTime", this.PlayEndTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

