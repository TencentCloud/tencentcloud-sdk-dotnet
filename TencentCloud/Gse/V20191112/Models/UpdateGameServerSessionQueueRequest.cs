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

    public class UpdateGameServerSessionQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// 游戏服务器会话队列名字，长度1~128
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 目的服务器舰队（可为别名）列表
        /// </summary>
        [JsonProperty("Destinations")]
        public GameServerSessionQueueDestination[] Destinations{ get; set; }

        /// <summary>
        /// 延迟策略集合
        /// </summary>
        [JsonProperty("PlayerLatencyPolicies")]
        public PlayerLatencyPolicy[] PlayerLatencyPolicies{ get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [JsonProperty("TimeoutInSeconds")]
        public ulong? TimeoutInSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamArrayObj(map, prefix + "PlayerLatencyPolicies.", this.PlayerLatencyPolicies);
            this.SetParamSimple(map, prefix + "TimeoutInSeconds", this.TimeoutInSeconds);
        }
    }
}

