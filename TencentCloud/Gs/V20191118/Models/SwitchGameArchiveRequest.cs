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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchGameArchiveRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 游戏存档Url
        /// </summary>
        [JsonProperty("GameArchiveUrl")]
        public string GameArchiveUrl{ get; set; }

        /// <summary>
        /// 游戏相关参数
        /// </summary>
        [JsonProperty("GameContext")]
        public string GameContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "GameArchiveUrl", this.GameArchiveUrl);
            this.SetParamSimple(map, prefix + "GameContext", this.GameContext);
        }
    }
}

