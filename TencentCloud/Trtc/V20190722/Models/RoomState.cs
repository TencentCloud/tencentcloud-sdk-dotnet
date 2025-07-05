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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoomState : AbstractModel
    {
        
        /// <summary>
        /// 通话ID（唯一标识一次通话）
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        [JsonProperty("RoomString")]
        public string RoomString{ get; set; }

        /// <summary>
        /// 房间创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 房间销毁时间
        /// </summary>
        [JsonProperty("DestroyTime")]
        public ulong? DestroyTime{ get; set; }

        /// <summary>
        /// 房间是否已经结束
        /// </summary>
        [JsonProperty("IsFinished")]
        public bool? IsFinished{ get; set; }

        /// <summary>
        /// 房间创建者Id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommId", this.CommId);
            this.SetParamSimple(map, prefix + "RoomString", this.RoomString);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "IsFinished", this.IsFinished);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

