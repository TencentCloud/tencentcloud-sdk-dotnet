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

    public class ChangeRoomPlayerProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏资源Id。
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 发起修改的玩家Id。
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// 需要修改的玩家自定义属性。
        /// </summary>
        [JsonProperty("CustomProfile")]
        public string CustomProfile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamSimple(map, prefix + "CustomProfile", this.CustomProfile);
        }
    }
}

