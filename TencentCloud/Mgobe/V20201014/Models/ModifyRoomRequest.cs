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

namespace TencentCloud.Mgobe.V20201014.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏资源Id。
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 房间ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 发起者的PlayerId。
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// 需要修改的房间选项，0表示房间名称，1表示房主，2表示是否允许观战，3表示是否支持邀请码/密码，4表示是否私有，5表示是否自定义房间属性，6表示是否禁止加人。
        /// </summary>
        [JsonProperty("ChangeRoomOptionList")]
        public long?[] ChangeRoomOptionList{ get; set; }

        /// <summary>
        /// 房间名称。
        /// </summary>
        [JsonProperty("RoomName")]
        public string RoomName{ get; set; }

        /// <summary>
        /// 变更房主。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 是否支持观战。
        /// </summary>
        [JsonProperty("IsViewed")]
        public bool? IsViewed{ get; set; }

        /// <summary>
        /// 是否支持邀请码/密码。
        /// </summary>
        [JsonProperty("IsInvited")]
        public bool? IsInvited{ get; set; }

        /// <summary>
        /// 是否私有。
        /// </summary>
        [JsonProperty("IsPrivate")]
        public bool? IsPrivate{ get; set; }

        /// <summary>
        /// 自定义房间属性。
        /// </summary>
        [JsonProperty("CustomProperties")]
        public string CustomProperties{ get; set; }

        /// <summary>
        /// 房间是否禁止加人。
        /// </summary>
        [JsonProperty("IsForbidJoin")]
        public bool? IsForbidJoin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamArraySimple(map, prefix + "ChangeRoomOptionList.", this.ChangeRoomOptionList);
            this.SetParamSimple(map, prefix + "RoomName", this.RoomName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "IsViewed", this.IsViewed);
            this.SetParamSimple(map, prefix + "IsInvited", this.IsInvited);
            this.SetParamSimple(map, prefix + "IsPrivate", this.IsPrivate);
            this.SetParamSimple(map, prefix + "CustomProperties", this.CustomProperties);
            this.SetParamSimple(map, prefix + "IsForbidJoin", this.IsForbidJoin);
        }
    }
}

