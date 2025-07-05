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

    public class Room : AbstractModel
    {
        
        /// <summary>
        /// 表示房间名称。最长不超过32个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 表示房间最大玩家数量。最大不超过100人。
        /// </summary>
        [JsonProperty("MaxPlayers")]
        public long? MaxPlayers{ get; set; }

        /// <summary>
        /// 表示房主OpenId。最长不超过16个字符。
        /// </summary>
        [JsonProperty("OwnerOpenId")]
        public string OwnerOpenId{ get; set; }

        /// <summary>
        /// 表示是否私有，私有指的是不允许其他玩家通过匹配加入房间。
        /// </summary>
        [JsonProperty("IsPrivate")]
        public bool? IsPrivate{ get; set; }

        /// <summary>
        /// 表示玩家详情列表。
        /// </summary>
        [JsonProperty("Players")]
        public Player[] Players{ get; set; }

        /// <summary>
        /// 表示团队属性列表。
        /// </summary>
        [JsonProperty("Teams")]
        public Team[] Teams{ get; set; }

        /// <summary>
        /// 表示房间 ID。出参用，由后端返回。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 表示房间类型。最长不超过32个字符。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 表示创建方式：0.单人主动发起创建房间请求；1.多人在线匹配请求分配房间；2. 直接创建满员房间。调用云API的创房请求默认为3，目前通过云API调用只支持第3种方式。
        /// </summary>
        [JsonProperty("CreateType")]
        public long? CreateType{ get; set; }

        /// <summary>
        /// 表示自定义房间属性，不传为空字符串。最长不超过1024个字符。
        /// </summary>
        [JsonProperty("CustomProperties")]
        public string CustomProperties{ get; set; }

        /// <summary>
        /// 表示房间帧同步状态。0表示未开始帧同步，1表示已开始帧同步，用于出参。
        /// </summary>
        [JsonProperty("FrameSyncState")]
        public long? FrameSyncState{ get; set; }

        /// <summary>
        /// 表示帧率。由控制台设置，用于出参。
        /// </summary>
        [JsonProperty("FrameRate")]
        public long? FrameRate{ get; set; }

        /// <summary>
        /// 表示路由ID。用于出参。
        /// </summary>
        [JsonProperty("RouteId")]
        public string RouteId{ get; set; }

        /// <summary>
        /// 表示房间创建的时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 表示开始帧同步时的时间戳（单位：秒）,未开始帧同步时返回为0。
        /// </summary>
        [JsonProperty("StartGameTime")]
        public long? StartGameTime{ get; set; }

        /// <summary>
        /// 表示是否禁止加入房间。出参使用，默认为False，通过SDK的ChangeRoom接口可以修改。
        /// </summary>
        [JsonProperty("IsForbidJoin")]
        public bool? IsForbidJoin{ get; set; }

        /// <summary>
        /// 表示房主PlayerId。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MaxPlayers", this.MaxPlayers);
            this.SetParamSimple(map, prefix + "OwnerOpenId", this.OwnerOpenId);
            this.SetParamSimple(map, prefix + "IsPrivate", this.IsPrivate);
            this.SetParamArrayObj(map, prefix + "Players.", this.Players);
            this.SetParamArrayObj(map, prefix + "Teams.", this.Teams);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreateType", this.CreateType);
            this.SetParamSimple(map, prefix + "CustomProperties", this.CustomProperties);
            this.SetParamSimple(map, prefix + "FrameSyncState", this.FrameSyncState);
            this.SetParamSimple(map, prefix + "FrameRate", this.FrameRate);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartGameTime", this.StartGameTime);
            this.SetParamSimple(map, prefix + "IsForbidJoin", this.IsForbidJoin);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
        }
    }
}

