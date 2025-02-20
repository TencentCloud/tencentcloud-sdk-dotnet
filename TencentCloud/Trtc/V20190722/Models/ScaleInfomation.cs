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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleInfomation : AbstractModel
    {
        
        /// <summary>
        /// 每天开始的时间
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// 房间人数，用户重复进入同一个房间为1次
        /// </summary>
        [JsonProperty("UserNumber")]
        public ulong? UserNumber{ get; set; }

        /// <summary>
        /// 房间人次，用户每次进入房间为一次
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }

        /// <summary>
        /// sdkappid下一天内的房间数
        /// </summary>
        [JsonProperty("RoomNumbers")]
        public ulong? RoomNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "UserNumber", this.UserNumber);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "RoomNumbers", this.RoomNumbers);
        }
    }
}

