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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGameServerSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 最大玩家数量，最小值不小于0
        /// </summary>
        [JsonProperty("MaximumPlayerSessionCount")]
        public ulong? MaximumPlayerSessionCount{ get; set; }

        /// <summary>
        /// 别名ID。每个请求需要指定别名ID 或者舰队 ID，如果两个同时指定时，优先选择舰队 ID
        /// </summary>
        [JsonProperty("AliasId")]
        public string AliasId{ get; set; }

        /// <summary>
        /// 创建者ID，最大长度不超过1024个ASCII字符
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 舰队ID。每个请求需要指定别名ID 或者舰队 ID，如果两个同时指定时，优先选择舰队 ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 游戏属性，最大长度不超过16组
        /// </summary>
        [JsonProperty("GameProperties")]
        public GameProperty[] GameProperties{ get; set; }

        /// <summary>
        /// 游戏服务器会话属性详情，最大长度不超过4096个ASCII字符
        /// </summary>
        [JsonProperty("GameServerSessionData")]
        public string GameServerSessionData{ get; set; }

        /// <summary>
        /// 游戏服务器会话自定义ID，最大长度不超过4096个ASCII字符
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// 幂等token，最大长度不超过48个ASCII字符
        /// </summary>
        [JsonProperty("IdempotencyToken")]
        public string IdempotencyToken{ get; set; }

        /// <summary>
        /// 游戏服务器会话名称，最大长度不超过1024个ASCII字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaximumPlayerSessionCount", this.MaximumPlayerSessionCount);
            this.SetParamSimple(map, prefix + "AliasId", this.AliasId);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "GameServerSessionData", this.GameServerSessionData);
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "IdempotencyToken", this.IdempotencyToken);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

