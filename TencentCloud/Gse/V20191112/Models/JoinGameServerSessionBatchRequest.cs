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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JoinGameServerSessionBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏服务器会话ID，最小长度1个ASCII字符，最大长度不超过256个ASCII字符
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// 玩家ID列表，最小1组，最大25组
        /// </summary>
        [JsonProperty("PlayerIds")]
        public string[] PlayerIds{ get; set; }

        /// <summary>
        /// 玩家自定义数据
        /// </summary>
        [JsonProperty("PlayerDataMap")]
        public PlayerDataMap PlayerDataMap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamArraySimple(map, prefix + "PlayerIds.", this.PlayerIds);
            this.SetParamObj(map, prefix + "PlayerDataMap.", this.PlayerDataMap);
        }
    }
}

