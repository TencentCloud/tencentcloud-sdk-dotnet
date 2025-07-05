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

    public class DescribePlayerRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏资源Id。
        /// </summary>
        [JsonProperty("GameId")]
        public string GameId{ get; set; }

        /// <summary>
        /// 玩家OpenId。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 玩家PlayerId，由后台分配，当OpenId不传的时候，PlayerId必传，传入PlayerId可以查询当前PlayerId的玩家信息，当OpenId传入的时候，PlayerId可不传，按照OpenId查询玩家信息。
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameId", this.GameId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
        }
    }
}

